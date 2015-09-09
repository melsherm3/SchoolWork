<?php
	session_start();
	//Declare and initialize the $Body for the html content
	$Body = "";
	//Declare and initialize the error count
	$errors = 0;
	//Declare and initialize the username and newusername variables
	$username = "";
	$newUsername = "";
	//If nothing is posted from a form, assign $username the value of the session's username 
	if (empty($_POST))
	{
		$username = $_SESSION['username'];
	}
	//If something was posted but both the new and existing fields are blank, show an error
	else if (empty($_POST['username']) && empty($_POST['newUsername'])) {
		++$errors;
		$Body .= "<p class='error'>You need to enter either an existing username or a new one.</p>\n";
	}
	//If both the new and existing username fields are fille din, show an error
	else if (!empty($_POST['username']) && !empty($_POST['newUsername'])) {
		++$errors;
		$Body .= "<p class='error'>You need to enter either an existing username or a new one, but you can't enter both.</p>\n";
	}
	//If everything is entered as expected.
	else {
		//Give the username session value the value of the newUsername if it's filled out
		if (empty($_POST['username'])) {
			$_SESSION['username'] = stripslashes($_POST['newUsername']);
			//Give the newUsername variable the value entered
			$newUsername = $_SESSION['username'];				
		}
		//Or if the existing username field is filled out, give the username session value the value of the existing username that was entered
		else {
			$_SESSION['username'] = stripslashes($_POST['username']);
			//Give the username variable the value entered
			$username = $_SESSION['username'];			
		}
	}


	//Connect to database server and open red_arrow database
	$DBConnect = FALSE;
	//If you haven't run into errors
	if ($errors == 0) {
		//Connect to the database
		$DBConnect = @mysqli_connect("localhost", "root", "");
		//Show an error if connecting doesn't work
		if ($DBConnect === FALSE) {				
			$Body .= "<p class='error'>Unable to connect to the database server. " . "Error code " . mysqli_errno() . ": " . mysqli_error() . "</p>\n";
			++$errors;
		}
		//Create a new database if it doesn't already exist
		else {
			$DBName = "red_arrow";
			$query = "CREATE DATABASE $DBName";
			if (mysqli_query($DBConnect, $query) === FALSE) 
			{
				$errorCode = mysqli_errno($DBConnect);
				//If it does exist already, then use it
				if ($errorCode = 1007){
					$query = "USE $DBName";
					//Show an error if the connection doesn't work.
					if (mysqli_query($DBConnect, $query) === FALSE) {
						$Body .= "<p class='error'>Unable to select the database. " . "Error code " . mysqli_errno($DBConnect) . ": " . mysqli_error($DBConnect) . "</p>\n";
						++$errors;
					}
				}
			}
		}
	}
	//Open/create athlete_workouts table
	$TableName = "athlete_workouts";
	//If there are no errors
	if ($errors == 0) {
		//Create a new table to hold the athlete workouts
		$SQLstring = "CREATE TABLE $TableName (username varchar(30) NOT NULL, date datetime, mileage int(3), details varchar(255), comments varchar(255))";
		$QueryResult = @mysqli_query($DBConnect, $SQLstring);
		if ($QueryResult === FALSE) {
			$createError = mysqli_errno($DBConnect);
			//If the table already exists, run a query on it
			if ($createError = 1050)
			{
				//Look if username exists				
				$SQLCheckstring = "SELECT count(*) FROM $TableName WHERE username='$username'";
				$CheckQueryResult = @mysqli_query($DBConnect, $SQLCheckstring);
				if ($CheckQueryResult !== FALSE) {
					$Row = mysqli_fetch_row($CheckQueryResult);
					//Show an error if the username doesn't exist
					if ($Row[0]==0 && $username!="") {
						$Body .= '<p class="error">This username does not exist or has not added any workouts. Go back and create a new username and add a workout.</p>';
						++$errors;
					}
				}
				//See if newUsername was filled out
				if ($newUsername != "") {
					$username = $newUsername;
					//Look if username exists				
					$SQLCheck2string = "SELECT count(*) FROM $TableName WHERE username='$username'";
					$CheckQuery2Result = @mysqli_query($DBConnect, $SQLCheck2string);
					if ($CheckQuery2Result !== FALSE) {
						$Row = mysqli_fetch_row($CheckQuery2Result);
						//Show an error if the username already exists
						if ($Row[0]>0) {
							$Body .= '<p class="error">This username already exists.</p>';
							++$errors;
						}
					}
				}
				
				//If there are no errors
				if ($errors == 0) {
					//Select rows from the table relevant to the user
					$SQLSelectString = "SELECT * from $TableName WHERE username='$username' ORDER BY date DESC";
					$SelectQueryResult = @mysqli_query($DBConnect, $SQLSelectString);
					//If the select doesn't work, show an error.
					if ($SelectQueryResult === FALSE) {
						$selectError = mysqli_errno($DBConnect);
						//If it thinks the database doesn't exist because it was just created, get the user to refresh the page
						if ($selectError == 1046) {
							$Body .= "<p>Welcome new user. Click here <a href='athlete-login.php'>to get started</a>.</p>";
							++$errors;
						}
						else {
							$Body .= "<p class='error'>Unable to select the table. " . "Error code " . mysqli_errno($DBConnect) . ": " . mysqli_error($DBConnect) . "</p>\n";
							++$errors;							
						}
					}
					//Otherwise show the workouts for that user
					else {
						$Body .= "<div class='welcome'>";
						$Body .= "<div class='scrolling'><h3>Workout History:</h3>";
						$Body .= "<table class='workouttable'>";
						$Body .= "<tr><th>Date</th><th>Mileage</th><th>Details</th><th>Comments</th></tr>";
						//For each row result of the query, show the data
						while (($Row = mysqli_fetch_assoc($SelectQueryResult)) != FALSE) {
							$day = new DateTime("{$Row['date']}");
							$thisDay = $day->format('m-d-Y');
							$Body .= "<tr><td>$thisDay</td>";
							$Body .= "<td>{$Row['mileage']}</td>";
							$Body .= "<td>{$Row['details']}</td>";
							$Body .= "<td>{$Row['comments']}</td></tr>";
						}
						$Body .= "</table>";
						$Body .= "</div></div>";
						//Clear the query
						mysqli_free_result($SelectQueryResult);
					}
				}
			}
			//If create the table doesn't work, show an error.
			else {
				$Body .= "<p class='error'>Unable to create the table. " . "Error code " . mysqli_errno($DBConnect) . ": " . mysqli_error($DBConnect) . "</p>\n";
				++$errors;			
			}
		}
	}
	//Create a cookie for the username
	setcookie("username", $username, time()+(60*60*24*7*4));
	//Close the sql connection
	@mysqli_close($DBConnect);

	//Show message if there were errors
	if ($errors > 0) {
		$Body .= "<p><a href='athletes.php'>Click here to go back</a> to the login page.</p>\n";
	}
	//Include add workout form  if there were no errors
	if ($errors == 0) {
		$Body .= "<div class='addworkout'>\n";
		$Body .= "<h3>Add a workout:</h3>\n";
		$Body .= "<form method='post' action='addworkout.php?" . SID . "'>\n";
		//Check if user is using IE or Firefox. 
		if (preg_match('~MSIE|Internet Explorer~i', $_SERVER['HTTP_USER_AGENT']) || (strpos($_SERVER['HTTP_USER_AGENT'], 'Trident/7.0; rv:11.0') || strpos($_SERVER["HTTP_USER_AGENT"], 'Firefox'))) {
			//Show date format tip
			$Body .= "Date:<br /> (Enter as YYYY-MM-DD)<br /> <input type='date' name='date' /><br />\n";
		}
		//Otherwise don't show date format tip
		else {
			$Body .= "Date:<br /><input type='date' name='date' /><br />\n";
		}
		$Body .= "Mileage:<br /> <input type='number' name='mileage' /><br />\n";
		$Body .= "Workout Details:<br /> <textarea name='details'></textarea><br />\n";
		$Body .= "Comments:<br /> <textarea name='comments' ></textarea><br />\n";
		$Body .= "<input type='submit' name='Submit' value='Submit' id='submit' />\n";
		$Body .= "</form>\n";
		$Body .= "</div>";
	}

?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8">
    <title>Red Arrow Racing - Run Coaching</title>
    <link rel="stylesheet" href="css/style.css" type="text/css" media="screen">
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Oswald" media="screen">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no">
</head>
<body>
    <div class="header">
        <img src="img/logo-white.png" alt="Red Arrow Racing" />
	</div>
    <nav class="coachtool">
		&nbsp;WELCOME <?php echo $username; ?>
		<a class="home" href="toolhome.php">HOME</a>
    </nav>
    <div class="mainimage">
	<?php
	echo $Body;
	?>

    </div>
    <div class="footer">
        <p>&copy; 2015 Red Arrow Racing</p>
    </div>

</body>
</html>
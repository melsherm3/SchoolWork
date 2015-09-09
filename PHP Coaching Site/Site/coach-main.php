<?php
	session_start();
	//Declare and initialize body variable and error count
	$Body = "";
	$errors = 0;
	//Set the coach password to "arrow"
	$password = "arrow";
	//Create a variable for the password enteredPassword
	$enteredPassword = "";
	//If nothing is passed in a form, use the password from the session 
	if (empty($_POST))
	{
		$enteredPassword = $_SESSION['password'];
	}
	//Otherwise, use the password that was sent in the form and save it to the session
	else {
		$enteredPassword = stripslashes($_POST['password']);	
		$_SESSION['password'] = $enteredPassword;
	}

	//If the enteredPassword and real password don't match, show an error
	if ($enteredPassword != $password){
		$Body .= "<h1 class='error'>Sorry, invalid password.</h1>";
		++$errors;
	}
	//Otherwise allow access to the program
	else {
		//Connect to database server and open red_arrow database
		$DBConnect = FALSE;
		if ($errors == 0) {
			$DBConnect = @mysqli_connect("localhost", "root", "");
			//If you can't connect, show an error
			if ($DBConnect === FALSE) {				
				$Body .= "<p class='error'>Unable to connect to the database server. " . "Error code " . mysqli_errno() . ": " . mysqli_error() . "</p>\n";
				++$errors;
			}
			//Otherwise try to create the database
			else {
				$DBName = "red_arrow";
				$query = "CREATE DATABASE $DBName";
				if (mysqli_query($DBConnect, $query) === FALSE) 
				{
					$errorCode = mysqli_errno($DBConnect);
					//If you can't create it because it exists, use it
					if ($errorCode = 1007){
						$query = "USE $DBName";
						//Show an error if you can't select the database
						if (mysqli_query($DBConnect, $query) === FALSE) {
							$Body .= "<p class='error'>Unable to select the database. " . "Error code " . mysqli_errno($DBConnect) . ": " . mysqli_error($DBConnect) . "</p>\n";
							++$errors;
						}
					}
				}
			}
		}
		//Open/create athlete_profiles table
		$TableName = "athlete_profiles";
		if ($errors == 0) {
			//Try to create the table
			$SQLstring = "CREATE TABLE $TableName (username varchar(30) NOT NULL UNIQUE, firstname varchar(30), lastname varchar(30), email varchar(50), phone varchar(20))";
			$QueryResult = @mysqli_query($DBConnect, $SQLstring);
			if ($QueryResult === FALSE) {
				$createError = mysqli_errno($DBConnect);
				//If you can't create it because it exists, then use it
				if ($createError = 1050)
				{
					//Create variables for "last week's mileage"
					$startDay = strtotime("last sunday -7days");
					$endDay = strtotime("last saturday");
					$startDay = date("Y/m/d",$startDay);
					$endDay = date("Y/m/d",$endDay);
					//Create a select query to show a summary of each athlete that had mileage from the last week date range
					$SQLSelectString = "SELECT firstname, lastname, SUM(mileage) as weeksMileage, email, phone FROM $TableName INNER JOIN athlete_workouts on athlete_workouts.username=athlete_profiles.username WHERE date >= '$startDay' AND  date <= '$endDay' GROUP BY athlete_profiles.username ORDER BY date DESC";
					$SelectQueryResult = @mysqli_query($DBConnect, $SQLSelectString);
					//Show an error if the select query doesn't work
					if ($SelectQueryResult === FALSE) {
						$selectError = mysqli_errno($DBConnect);
						//If it thinks the database doesn't exist because it was just created, send the user to create an athlete table first
						if ($selectError == 1046) {
							$Body .= "<p>Welcome new user. Before you can add an athlete, you must have your athlete <a href='athletes.php'>add a workout here</a>.</p>";
							++$errors;
						}
						//If no athletes have added workouts, show error
						else if ($selectError == 1146) {
							$Body .= "<p>You have no athletes. You must have an athlete <a href='athletes.php'>add a workout here</a> Before you can see reports.</p>";
							++$errors;
						}
						//Otherwise show an error
						else {
							$Body .= "<p class='error'>Unable to select the table. " . "Error code " . mysqli_errno($DBConnect) . ": " . mysqli_error($DBConnect) . "</p>\n";
							++$errors;
						}
					}
					//Otherwise..
					else {
							//Show table with athlete summary
							$Body .= "<div class='athletesummary'>\n";
							$Body .= "<table class='summary'>\n";
							$Body .= "<tr>\n";
							$Body .= "<th>Athlete Name</th><th>Last Week's Mileage <br />($startDay - $endDay)</th><th>Email</th><th>Phone</th>\n";
							$Body .= "</tr>\n";
							//For each row, show the data
							while (($Row = mysqli_fetch_assoc($SelectQueryResult)) != FALSE) {
								$finame = "{$Row['firstname']}";
								$laname = "{$Row['lastname']}";
								$Body .= "<tr>\n";
								$Body .= "<td>$finame $laname</td>"; 
								$Body .= "<td>{$Row['weeksMileage']}</td>";
								$Body .= "<td>{$Row['email']}</td>";
								$Body .= "<td>{$Row['phone']}</td></tr>\n";
							}
							$Body .= "</table> \n";
							$Body .= "<p>*Note: You must add an athlete using the form to the left for them to show up in this report. <br />*Athletes only show if they have mileage from last week.</p>";
							$Body .= "</div>\n";
							//Clear the query result
							mysqli_free_result($SelectQueryResult);
					}
				}
				//Otherwise show an error
				else {
					$Body .= "<p class='error'>Unable to create the table. " . "Error code " . mysqli_errno($DBConnect) . ": " . mysqli_error($DBConnect) . "</p>\n";
					++$errors;			
				}
			}
		}
		//Close the db connection
		@mysqli_close($DBConnect);
		
		//Add Athlete Form if no errors
		if($errors == 0) {
			$Body .= "<div class='addworkout'>\n";
			$Body .= "<h3>Add new athlete:</h3>\n";
			$Body .= "<form method='post' action='addathlete.php?" . SID . "'>\n";
			$Body .= "Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type='text' name='uname' /><br />\n";
			$Body .= "First Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type='text' name='fname' /><br />\n";
			$Body .= "Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type='text' name='lname' /><br />\n";
			$Body .= "Email Address:&nbsp;&nbsp;<input type='text' name='email' /><br />\n";
			$Body .= "Phone Number:  <input type='text' name='phone' /><br /><br />\n";
			$Body .= "<input type='submit' name='Submit' value='Submit' id='submitathlete' />\n";
			$Body .= "</form>	\n";
			$Body .= "</div>\n";		
		}

	}
	//Show message if there were errors
	if ($errors > 0) {
		$Body .= "<p><a href='coach-entry.php'>Click here to go back</a> to the login page.</p>\n";
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
		&nbsp;COACHING REPORT
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
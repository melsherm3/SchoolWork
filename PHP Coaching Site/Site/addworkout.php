<?php
	session_start();
	//Declare and initialize $Body and $errors
	$Body = "";
	$errors = 0;
	//Assign username the username value in the session
	$username = $_SESSION['username'];
	if(is_numeric($_POST['mileage']) == false) {
		$Body .= "<p class='error'>Mileage must be an integer.</p>";	
		++$errors;
	}
	//If user left out the date, mileage or details in the form, show an error
	else if(empty($_POST['date']) || empty($_POST['mileage']) || empty($_POST['details'])) {
		$Body .= "<p class='error'>You must fill in the date, mileage, and details!</p>";	
		++$errors;
	}

	//Otherwise, save the posted values to variables
	else {
		$date = $_POST['date'];
		$mileage = $_POST['mileage'];
		$details = stripslashes($_POST['details']);
		$comments = stripslashes($_POST['comments']);
		//Connect to the database
		$DBConnect = @mysqli_connect("localhost", "root", "");
		//Show an error if connection doesn't work
		if ($DBConnect === FALSE) {
			echo "<p class='error'>Unable to connect to the database server.</p>" . "<p>Error code " . mysqli_errno() . ": " . mysqli_error() . "</p>";
			++$errors;			
		}
		//Otherwise, use the database
		else {
				$DBName = "red_arrow";
				$query = "USE $DBName";
				//Show error if database can't be selected
				if (mysqli_query($DBConnect, $query) === FALSE) {
					$Body .= "<p class='error'>Unable to select the database. " . "Error code " . mysqli_errno($DBConnect) . ": " . mysqli_error($DBConnect) . "</p>\n";
					++$errors;
					}
		}
		//Open athlete_workouts table
		$TableName = "athlete_workouts";
		//If there are no errors insert the workout based on the variables
		if ($errors == 0) {
			$SQLInsertString = "INSERT INTO $TableName VALUES ('$username', '$date', '$mileage', '$details', '$comments')";
			$InsertQueryResult = @mysqli_query($DBConnect, $SQLInsertString);
			//Show an error if the insert doesn't work
			if ($InsertQueryResult === FALSE) {
				$Body .= "<p class='error'>Unable to add to the table. " . "Error code " . mysqli_errno($DBConnect) . ": " . mysqli_error($DBConnect) . "</p>\n";
				++$errors;
			}
			//If everything works, show a success message
			else {
				$Body .= "<h1>Workout on $date has been added.</h1>";
			}
		}
		//Close the database connection
		mysqli_close($DBConnect);
	}
	//Show link to go back
	$Body .= "<h2><a href='athlete-login.php?' . SID . '>Go Back</a></h2>\n";
?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8">
    <title>Athlete - Add a Workout</title>
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
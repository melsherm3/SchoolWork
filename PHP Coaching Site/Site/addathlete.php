<?php
	session_start();
	//Declare and initialize body and errors
	$Body = "";
	$errors = 0;
	//Set the entered password to the session password
	$enteredPassword = $_SESSION['password'];
	//If any field is left blank, show an error
	if(empty($_POST['uname']) || empty($_POST['fname']) || empty($_POST['lname']) || empty($_POST['email']) || empty($_POST['phone'])) {
		$Body .= "<p class='error'>You must fill in the username, first name, last name, email and phone number!</p>";
		++$errors;		
	}
	else if(isEmail(stripslashes($_POST['email']))==false){
		$Body .= "<p class='error'>Email address was not valid.</p>";
		++$errors;
	}
	else if(isPhoneNumber(stripslashes($_POST['phone']))==false){
		$Body .= "<p class='error'>Phone Number was not valid.</p>";
		++$errors;
	}
	//Otherwise assign variables for all of the submitted form data
	else {
		$uname = stripslashes($_POST['uname']);
		$fname = stripslashes($_POST['fname']);
		$lname = stripslashes($_POST['lname']);
		$email = stripslashes($_POST['email']);
		$phone = stripslashes($_POST['phone']);
		//Connect to the database server
		$DBConnect = @mysqli_connect("localhost", "root", "");
		//If it doesn't connect, show an error
		if ($DBConnect === FALSE) {
			echo "<p class='error'>Unable to connect to the database server.</p>" . "<p>Error code " . mysqli_errno() . ": " . mysqli_error() . "</p>";
			++$errors;			
		}
		//Otherwise use the red_arrow database
		else {
				$DBName = "red_arrow";
				$query = "USE $DBName";
				//If you can't select the database, show an error
				if (mysqli_query($DBConnect, $query) === FALSE) {
					$Body .= "<p class='error'>Unable to select the database. " . "Error code " . mysqli_errno($DBConnect) . ": " . mysqli_error($DBConnect) . "</p>\n";
					++$errors;
				}
		}
		//Open athlete_profiles table
		$TableName = "athlete_profiles";
		if ($errors == 0) {
			$SQLInsertString = "INSERT INTO $TableName VALUES ('$uname', '$fname', '$lname', '$email', '$phone')";
			$InsertQueryResult = @mysqli_query($DBConnect, $SQLInsertString);
			//Show error if insert query doesn't work
			if ($InsertQueryResult === FALSE) {
				$Body .= "<p class='error'>Unable to add to the table. " . "Error code " . mysqli_errno($DBConnect) . ": " . mysqli_error($DBConnect) . "</p>\n";
				++$errors;
			}
			//Show success message if insert query worked
			else {
				$Body .= "<h1>Athlete $fname $lname has been added.</h1>";
			}
		}
		//Close the db connection
		mysqli_close($DBConnect);
	}
	$Body .= "<h2><a href='coach-main.php?' . SID . '>Go Back</a></h2>\n";

//Function to check if text is an email address
function isEmail($string) {
	if(preg_match("/[a-zA-Z0-9_\.\+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-\.]+/",$string)==1)
				return true;
		else
				return false;
}

//Function to check if text is a phone number
function isPhoneNumber($string) {
	if(preg_match("/^(1?(?: |\-|\.)?(?:\(\d{3}\)|\d{3})(?: |\-|\.)?\d{3}(?: |\-|\.)?\d{4})$/",$string)==1)
			return true;
	else
			return false;
}
?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8">
    <title>Coach - Add an Athlete</title>
    <link rel="stylesheet" href="css/style.css" type="text/css" media="screen">
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Oswald" media="screen">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no">
</head>
<body>
    <div class="header">
        <img src="img/logo-white.png" alt="Red Arrow Racing" />
	</div>
    <nav class="coachtool">
		&nbsp;ADD AN ATHLETE
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
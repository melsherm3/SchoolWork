<?php
	session_start();
	$_SESSION = array();
	session_destroy();
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
		&nbsp;ATHLETES - ENTER YOUR USERNAME OR CREATE A NEW ONE
		<a class="home" href="toolhome.php">HOME</a>
    </nav>
    <div class="mainimage">
		<div class="login">
			<form action="athlete-login.php?<?php echo SID; ?>" method="post">
			Existing Username:<input type="text" name="username" <?php if(isset($_COOKIE['username'])) {$uname = $_COOKIE['username']; echo "value='$uname'";} ?>  /><br /><br />
			Create a New Username:<input type="text" name="newUsername" /><br />(add a workout to save your username)<br /> 	
			<input type="submit" name="Submit" value="Submit" />
		</div>
    </div>
    <div class="footer">
        <p>&copy; 2015 Red Arrow Racing</p>
    </div>

</body>
</html>
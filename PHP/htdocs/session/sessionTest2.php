<?php
// Author: Don Bowers/Eric Coffin
// Date: Sept 8, 2014
// Purpose: Demo how easy it is to use Sessions

// at the end of the file we print a form to the screen
// with a hidden field named killSession
// and a button that says "Kill Session"
// if the user clicks this button we... kill the session.

// this part we use for later, when we want to end the session
if ( ! empty($_POST['killSession']) )
{
	session_start(); // need to use this whenever we want to access the session array!
	session_destroy(); // this destroys the current session

    // this part gets rid of the session cookie that php puts on the users machine
	if (ini_get("session.use_cookies")) {
		$params = session_get_cookie_params();
		setcookie(session_name(), '', time() - 42000,
			$params["path"], $params["domain"],
			$params["secure"], $params["httponly"]
		);
	}
	
	echo "<p>Session ended</p>";
	echo "<a 'href=sessionTest.php'>Start again</a>";

} else {

	// any time we want to access the session we call this method.
	session_start();

	if(isset($_SESSION['testVar']) )
	{
		echo "<p>Whoopie! The session works! The single variable we stored was set to: ". $_SESSION['testVar'] .
			"</p>";

		// we can update the value stored in the session variable.
		$_SESSION['testVar'] += 1;
		
	}

    // check for session var nameArray - if it exists store it in a local copy of $nameArray and then print the array contents
	if(isset($_SESSION['nameArray']) )
	{
		$nameArray = $_SESSION['nameArray'];
		print_r($nameArray);
	}
}
?>
<!-- Kill session form -->
<form method="POST" action="sessionTest2.php">
<input type="hidden" name="killSession" value="1" />
<input type="submit" value="kill session" />
</form>


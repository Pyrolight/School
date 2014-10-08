<?php
    // Author: Don Bowers/Eric Coffin
    // Date: Sept 8, 2014
    // we will first run the require_login.php script before we do anything
    // on this page.
    /*
	login.php
	====
	Prompt the user for a username and add this to a cookie called userName.
	If the user loads this page and they have the cookie userName already. We will forward them to page2.php.

	*/

	// if the user has not logged in yet, we need to set the cookie !
	
	if ( ! isset($_COOKIE["userName"] ) )
	{
		// first see if the user has submitted a form providing us the username.
		if ( empty($_POST["userName"] ))
		{
			// get userName from user with a form
			?>
			<!DOCTYPE html><html><body> <h1>Login Page</h1>
            <p>This is the login page. It is public and asks the user for their username.</p><form method="POST" action="login.php">
			Username:<input type="text" name="userName" />
			<input type="submit" />
			</form></body></html>
			<?php
		}
		else  
		{
			// There is no cookie and
			// user has submitted the form and userName has
			// a value
			$userName = $_POST["userName"];
			
			// set the cookie with the value the user gave us from the text input called
			// userName.  This will expire in 24 hours.
			setcookie("userName",$userName,time() + 60*60*24);
			
			echo "<!DOCTYPE html><html><body><h1>Thank you for logging in " . $userName . "</h1>";

			// The user can now proceed another page, where we will check for the
			// existance of the cookie.  If they don't have it, we will send them
			// back here.
			
			echo "<a href=\"index.php\">Continue</a></body></html>";
		}
	}	
	else
	{
		// the cookie is set... so we will send the user back to page2.php. 
		// no need to get username again.  they need to click 'logout' button
		// in order to delete cookie.	
		
		header('Location: index.php');
	}
        
	
?>
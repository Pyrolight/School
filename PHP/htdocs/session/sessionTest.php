<?php
// Author: Don Bowers/Eric Coffin
// Date: Sept 8, 2014
// Purpose: Demo how easy it is to use Sessions

// we use this whenever we want to access the session!
session_start();

// we can 'name' our vars whatever we want and set them to a value. We simply access the superglobal $_SESSION array and set it up
$_SESSION['testVar'] = 1;

// we can even add arrays inside our session vars
$_SESSION['nameArray'] = array('Peter','Paul','Mary');

echo "<p>Session has been started...<br />I put three names into the session array...</p>";

echo "<a href='sessionTest2.php'>Go to next page and see that they still exist!</a>";

?>
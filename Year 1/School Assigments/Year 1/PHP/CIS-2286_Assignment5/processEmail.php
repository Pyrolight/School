<?php
$DOCUMENT_ROOT = $_SERVER['DOCUMENT_ROOT'];
$email;
$message;
// set message length constant.
define('MESSAGE_LENGTH', 500);
// validation regular expression from http://snipplr.com/view/35886/
$emailRegex = '/^([\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+\.)*[\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+@((((([a-z0-9]{1}[a-z0-9\-]{0,62}[a-z0-9]{1})|[a-z])\.)+[a-z]{2,6})|(\d{1,3}\.){3}\d{1,3}(\:\d{1,5})?)$/i';
?>

<!DOCTYPE html>

<!-- Author: Michael Fesser
     Date: Feb 27, 2014
     Purpose:  This page does all the validation for the user data submitted from the
               emailForm page.  It checks that there something has been entered into
               the fields and that each one conforms to the required validation rules.
     Last Revision: Feb 28, 2014
     Dependencies: emailForm.php
-->

<html>
    <head>
        <meta charset="UTF-8">
        <title>Process Email</title>
        <link href="emailForm.css" rel="stylesheet">
    </head>
    <body>
        <div class="banner">
            <div id ="titleImage"><span id = "title">Information System Designs Inc.</span></div> <!-- Title banner with background. --> 
        </div>
        <div id="box2">
            <div id="vetricalAlign">
                <?php
                /* check to see if the email field is empty */
                if (empty($_POST['email'])) {
                    // Taken from Amber on Stack Overflow.  Returns the user to the previous page.
                    echo "You left the email field empty.  Please click the link below to return to the previous page. <br />";
                    echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a>";
                    // End script.
                    exit;
                } else {
                    // Trim off any leading or trailing white space.
                    $email = trim($_POST['email']);
                }
                /* check to see if the message field is empty */
                if (empty($_POST['message'])) {
                    // Taken from Amber on Stack Overflow.  Returns the user to the previous page.
                    echo "You left the message field empty.   Please click the link below to return to the previous page. <br />";
                    echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a>";
                    // End script.
                    exit;
                } else {
                    // Trim off any leading or trailing white space.
                    $message = trim($_POST['message']);
                }
                /* Check to see if the email passes regular expression validation */
                if (!preg_match($emailRegex, $email)) {
                    // Taken from Amber on Stack Overflow.  Returns the user to the previous page.
                    echo "That is not a valid email.   Please click the link below to return to the previous page. <br />";
                    echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a>";
                    // End script.
                    exit;
                /* Check to see if the message is over MESSAGE_LENGTH characters */    
                } else if (strlen($message) > MESSAGE_LENGTH) {
                    // Taken from Amber on Stack Overflow.  Returns the user to the previous page.
                    echo "Sorry the message is too long by " . (strlen($message) - MESSAGE_LENGTH) . " characters.   Please click the link below to return to the previous page. <br />";
                    echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a>";
                    // End script.
                    exit;
                } else {
                    /* Tell the user their submission was acceptable */
                    echo "You message has been forwarded to the department requested.<br /><br />";
                }
                ?>
            </div>
        </div>
    </body>
</html>

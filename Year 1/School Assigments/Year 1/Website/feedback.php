<?php
$firstName;
$lastName;
$email;
$message;
date_default_timezone_set('Canada/Atlantic');
$date = date("g:i:sA e") . " on " . date("F d, Y");
define('MESSAGE_LENGTH', 500);
// validation regular expression from http://snipplr.com/view/35886/
$emailRegex = '/^([\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+\.)*[\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+@((((([a-z0-9]{1}[a-z0-9\-]{0,62}[a-z0-9]{1})|[a-z])\.)+[a-z]{2,6})|(\d{1,3}\.){3}\d{1,3}(\:\d{1,5})?)$/i';
$goBack = "  Please click the link below to return to the previous page. <br /> <a href=\"javascript:history.go(-1)\">Go back to previous page</a></div>";
?>

<!DOCTYPE html>
<html lang="en" id="backgroundFix">
    <head>

        <!-- Author: Michael Fesser
             Date: 3/24/2014
             Purpose: This page has my personal information, resume and contact form.
             Last Revision: 3/24/2014
             Dependencies: about.php
        -->

        <title>About</title>

        <?php
        include 'header.php';
        ?>

    </head>
    <body>

        <?php
        include './menu.php';
        ?>

        <div class="container topOffSet">
            <div class="row">
                <div class="box">
                    <div class="col-lg-12">
                        <?php
                        /* check to see if the first name field is empty */
                        if (empty($_POST['firstName'])) {
                            // Taken from Amber on Stack Overflow.  Returns the user to the previous page.
                            echo "<div class = 'text-center'>You left the first name field empty." . $goBack;
                            // End script.
                            exit;
                        } else {
                            // Trim off any leading or trailing white space.
                            $firstName = trim($_POST['firstName']);
                        }
                        /* check to see if the last name field is empty */
                        if (empty($_POST['lastName'])) {
                            echo "<div class = 'text-center'>You left the last name field empty." . $goBack;
                            exit;
                        } else {
                            $lastName = trim($_POST['lastName']);
                        }
                        if (empty($_POST['email'])) {
                            echo "<div class = 'text-center'>You left the email field empty." . $goBack;
                            exit;
                            /* Check to see if the email passes regular expression validation */
                        } else if (!preg_match($emailRegex, $_POST['email'])) {
                            echo "<div class = 'text-center'>That is not a valid email." . $goBack;
                            exit;
                        } else {
                            $email = trim($_POST['email']);
                        }
                        if (empty($_POST['message'])) {
                            echo "<div class = 'text-center'>You left the message field empty." . $goBack;
                            exit;
                            /* Check to see if the message is over MESSAGE_LENGTH characters */
                        } else if (strlen(trim($_POST['message'])) > MESSAGE_LENGTH) {
                            echo "<div class = 'text-center'>Sorry the message is too long by " . (strlen(trim($_POST['message'])) - MESSAGE_LENGTH) . " characters." . $goBack;
                            exit;
                        } else {
                            $message = trim($_POST['message']);

//                            //http://www.youtube.com/watch?v=ueWpNe0PG34
//                            $con = mysqli_connect('michaelfesserca.ipagemysql.com', 'pyrolight_ryuuko', 'aa_', 'mfdb');
//                            //$con = mysqli_connect('localhost', 'root', '', 'mfdb');
//                            if (!$con) {
//                                die('Could not connect: ' . mysql_error());
//                            }
//
//                            mysqli_query($con, "INSERT INTO feedback (firstName, lastName, email, message, date) VALUES ('$firstName', '$lastName', '$email', '$message', '$date')");
//                            mysqli_close($con);
//
//                            // Tell the user their submission was acceptable 
//                            echo "<div class = 'text-center'>Thank your for your feedback." . $goBack;
                            
                            //http://www.youtube.com/watch?v=ueWpNe0PG34
                            
                            $con = mysqli_connect('localhost', 'root', '', 'test');
                            //$con = mysqli_connect('localhost', 'root', '', 'mfdb');
                            if (!$con) {
                                die('Could not connect: ' . mysql_error());
                                exit();
                            }

                            mysqli_query($con, "INSERT INTO feedback (firstName, lastName, email, message, date) VALUES ('$firstName', '$lastName', '$email', '$message', '$date')");
                            mysqli_close($con);
                            
                            
                            $mysqli = new $mysqli('localhost', 'root', '', 'test');                           
                            if ($mysqli->connect_errno) {
                                die('Could not connect: ' . $mysqli->connect_errno);
                                exit(); 
                            }

                            $mysqli->query("INSERT INTO feedback (firstName, lastName, email, message, date) VALUES ('$firstName', '$lastName', '$email', '$message', '$date')");
                            $mysqli->close(); 

                            // Tell the user their submission was acceptable 
                            echo "<div class = 'text-center'>Thank your for your feedback." . $goBack;
                        }
                        ?>
                    </div>
                </div>
            </div>
        </div><!-- /.container -->

        <?php
        include 'footer.php';
        ?>

    </body>
</html>


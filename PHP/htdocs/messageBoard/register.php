<?php
/* Author: Michael Fesser
  Date: 10/14/2014
  Purpose: This is the registration page.  USer will be able to sign up for account here.  
  Various validation will occur.
  Last Revision: 10/14/2014
  Dependencies: None
 */

// Start the session and secure it against session fixation.
session_start();
session_regenerate_id(true);

// CATCHPA
require_once('recaptchalib.php');
// Used to populate fields when there is a registration error.
if (isset($_POST['registerUser'])) {
    $_SESSION['username'] = $_POST['username'];
    $_SESSION['firstName'] = $_POST['firstName'];
    $_SESSION['lastName'] = $_POST['lastName'];
    $_SESSION['email'] = $_POST['email'];
    // CATCHPA stuff.
    $privatekey = "6Lcu4PsSAAAAAKDjWsLF81zOfs8C6pYNwN9K6NVO";
    $resp = recaptcha_check_answer($privatekey, $_SERVER["REMOTE_ADDR"], $_POST["recaptcha_challenge_field"], $_POST["recaptcha_response_field"]);
    // If CATCHPA no valid
    if (!$resp->is_valid) {
        $_SESSION['failedCATCHPA'] = true;
    } else {
        // If valid run register function.
        include ('databaseFunctions.php');
        $_SESSION['failedCATCHPA'] = false;
        registration();
        // Goto index if registration successful.
        if ($_SESSION['accountCreated'] == true) {
            header('location:index.php');
            exit();
            // Clear username each time a fail happens.
        } else {
            $_SESSION['username'] = "";
        }
    }
}
?>

<html>
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta name="description" content="">
        <meta name="author" content="">

        <title>Register</title>

        <link href="css/bootstrap.min.css" rel="stylesheet">
        <link href="css/template.css" rel="stylesheet">

        <script src="js/bootstrap.min.js"></script>
        <script src="js/jquery-1.11.1.min.js"></script>
        <script src="js/validation.js"></script>
        <script src="ckeditor/ckeditor.js"></script>

         <!-- Script is from Kevin Liew @ http://www.queness.com, modifications by Michael Fesser -->
        <script>
        // Mixed scripts make formatting explode.      
        <?php
        // Needed due to a combining of scripts.  This will allow the script to deal with both clicks and auto open on it's own.
        if (isset($_SESSION['loginFailed']) || $_SESSION['accountCreated'] == true) {
        ?>
            //azzomer http://www.dynamicdrive.com/forums
            $(document).ready(function() {

            var id = '#dialog';
        <?php
        } else {
        ?>
            $(document).ready(function() {

            //select all the a tag with name equal to modal
            $('a[name=modal]').click(function(e) {
            //Cancel the link behavior
            e.preventDefault();
            //Get the A tag
            var id = $(this).attr('href');
        <?php
        }
        ?>
            //Get the screen height and width
            var maskHeight = $(document).height();
            var maskWidth = $(window).width();
            //Set heigth and width to mask to fill up the whole screen
                    $('#mask').css({'width': maskWidth, 'height': maskHeight});
                    //transition effect		
                    $('#mask').fadeIn();
                    $('#mask').fadeTo("fast", 0.8);
                    //Get the window height and width
                    var winH = $(window).height();
                    var winW = $(window).width();
                    //Set the popup window to center
                    $(id).css('top', winH / 2 - $(id).height() / 2);
                    $(id).css('left', winW / 2 - $(id).width() / 2);
                    //transition effect
                    $(id).fadeIn(2000);
        <?php
        if (!isset($_SESSION['loginFailed']) && ($_SESSION['accountCreated'] == false)) {
        ?>
            });
        <?php
        }
        ?>
            //if close button is clicked
            $('.window .cancel').click(function(e) {
            //Cancel the link behavior
            e.preventDefault();
                    $('#mask').hide();
                    $('.window').hide();
            });
                    //if mask is clicked
                    $('#mask').click(function() {
            $(this).hide();
                    $('.window').hide();
            });
                    $(window).resize(function() {

            var box = $('#boxes .window');
                    //Get the screen height and width
                    var maskHeight = $(document).height();
                    var maskWidth = $(window).width();
                    //Set height and width to mask to fill up the whole screen
                    $('#mask').css({'width': maskWidth, 'height': maskHeight});
                    //Get the window height and width
                    var winH = $(window).height();
                    var winW = $(window).width();
                    //Set the popup window to center
                    box.css('top', winH / 2 - box.height() / 2);
                    box.css('left', winW / 2 - box.width() / 2);
            });
            });</script>

        <!-- End Kevin Liew @ http://www.queness.com -->

        <!-- Style is from Kevin Liew @ http://www.queness.com -->
        <style>
            #mask {
                position:absolute;
                left:0;
                top:0;
                z-index:9000;
                background-color:#000;
                display:none;
            }

            #boxes .window {
                position:fixed;
                left:0;
                top:0;
                width:440px;
                height:200px;
                display:none;
                z-index:9999;
                padding:20px;
            }

            #boxes #dialog {
                width:330px; 
                height:330px;
                padding:10px;
                background-color:#ffffff;
                border-radius: 2px;
            }

            /* Input fix. */
            .modal-input{
                display:block;
                width:300px;
                height:34px;
                padding:6px 12px;
                font-size:14px;
                line-height:1.42857143;
                color:#555;
                background-color:#fff;
                background-image:none;
                border:1px solid #ccc;
                border-radius:4px;
                -webkit-box-shadow:inset 0 1px 1px rgba(0,0,0,.075);
                box-shadow:inset 0 1px 1px rgba(0,0,0,.075);
                -webkit-transition:border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
                -o-transition:border-color ease-in-out .15s,box-shadow ease-in-out .15s;
                transition:border-color ease-in-out .15s,box-shadow ease-in-out .15s;

            }

            .modal-input:focus{
                border-color:#66afe9;
                outline:0;
                -webkit-box-shadow:inset 0 1px 1px rgba(0,0,0,.075),0 0 8px rgba(102,175,233,.6);
                box-shadow:inset 0 1px 1px rgba(0,0,0,.075),0 0 8px rgba(102,175,233,.6)
            }

            .modal-input::-moz-placeholder{
                color:#777;opacity:1
            }

            .modal-input:-ms-input-placeholder{
                color:#777
            }

            .modal-input::-webkit-input-placeholder{
                color:#777
            }

            .input-error{
                font-size: 16px;
                color: red;
            }
        </style>
        <!-- End Kevin Liew @ http://www.queness.com -->
    </head>
    <body>
        <div id="menuContainer">
            <div class="menuBar">
                <?php
                include ('menuBar.php');
                ?>
            </div>
        </div>
        <div class="container offsetTop">
            <div class="banner text-center">
                <h1 id="vetricalAlign">The Wild World of Messages</h1>
            </div>
            <div class="box">
                <h3 class="text-center">Register a new account</h3>  
                <form id="registrationForm" action="register.php" method ="POST" onsubmit="return validateRegister(this);">
                    <div class="row">
                        <div class="form-group col-lg-4 col-md-offset-4">
                            <div>                             
                                <?php
                                // Display the CATCHPA error
                                if (isset($_SESSION['failedCATCHPA']) && $_SESSION['failedCATCHPA'] == true) {
                                    echo "<span class='input-error'>The reCAPTCHA wasn't entered correctly.</span>";
                                    // Remove the error.
                                    unset($_SESSION['failedCATCHPA']);
                                }
                                ?>
                            </div>
                            <div>
                                <?php
                                // Display the username taken error.
                                if (isset($_SESSION['usernameTaken']) && $_SESSION['usernameTaken'] == true) {
                                    echo "<span class='input-error'>Sorry the username is taken</span>";
                                }
                                ?>
                            </div>
                            <label>Username: </label><input type="text" id="username" class="form-control"  name="username" value="<?php echo (isset($_SESSION['username']) ? $_SESSION['username'] : ""); ?>"/>
                            <div id="usernameError" class="input-error">&nbsp;</div>
                            <label>First Name: </label><input type="text" id="firstName" class="form-control" name="firstName" value="<?php echo (isset($_SESSION['firstName']) ? $_SESSION['firstName'] : ""); ?>"/>
                            <div id="firstNameError" class="input-error">&nbsp;</div>
                            <label>Last Name: </label><input type="text"  id="lastName" class="form-control" name="lastName" value="<?php echo (isset($_SESSION['lastName']) ? $_SESSION['lastName'] : ""); ?>"/>
                            <div id="lastNameError" class="input-error">&nbsp;</div>           
                            <label>Email: </label><input type="text" id = "email" class="form-control" name="email" value="<?php echo (isset($_SESSION['email']) ? $_SESSION['email'] : ""); ?>" />
                            <div id="emailError" class="input-error">&nbsp;</div>
                            <label>Confirm Email: </label><input type="text" id="email2" class="form-control" name="email2" value="<?php echo (isset($_SESSION['email']) ? $_SESSION['email'] : ""); ?>"/>
                            <div id="emailError2" class="input-error">&nbsp;</div>
                            <label>Password: </label><input type="password" id="password" class="form-control" name="password" />
                            <div id="passwordError" class="input-error">&nbsp;</div>
                            <label>Confirm Password: </label><input type="password" id="password2" class="form-control" name="password2" />
                            <div id="passwordError2" class="input-error">&nbsp;</div><br/>
                            <input type="hidden" name="registerUser" />
                            <?php
                            $publickey = "6Lcu4PsSAAAAAOwCONvxiJyQT0JHq81xVwfba5-h"; // you got this from the signup page
                            echo recaptcha_get_html($publickey);
                            ?>                          
                            <input type="submit" name="submit" class="btn btn-default" value ="Submit" />
                        </div>
                    </div>
                </form>
            </div>           
            <?php
            // Include login.php.
            include ('login.php');
            ?>
        </div>
    </body>
</html>




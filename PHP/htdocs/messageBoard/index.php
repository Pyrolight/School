<?php
/* Author: Michael Fesser
  Date: 10/14/2014
  Purpose: This is the main page.  It is a very simple message board.Messages will be displayed, 
  and when a user logs in they will be able to add, edit and deleted messages.
  Last Revision: 10/14/2014
  Dependencies: none
 */

// Start the session and secure it against session fixation.
session_start();
session_regenerate_id(true);

// When the page loads run this.
if (!isset($_SESSION['sessionStart'])) {
    $_SESSION['sessionStart'] = true;
    $_SESSION['accountCreated'] = false;
}

// Add the database functions.
include ('databaseFunctions.php');

// If the user is logged in.
if (isset($_SESSION['userId'])) {
    // If the are posing a message.
    if (isset($_POST['message'])) {
        // If they are editing it.
        if (isset($_SESSION['editMessage'])) {
            editMessage();
        } else {
            // If it is a new message.
            insertMessage();
        }
    }

    // If the user clicked a link.
    if (isset($_GET['action'])) {
        // If the want to delete a message.
        if ($_GET['action'] == "delete") {
            deleteMessage();
            // Clear the message box after a delete.  Cleans up any edit -> delete clicks.
            unset($_SESSION['messageTitle']);
            unset($_SESSION['message']);
        // If they clicked the edit link.  This is used before the message is posted.
        } else if ($_GET['action'] == "edit") {
            prepareEditMessage();
        // Logout.
        } else if ($_GET['action'] == 'logout') {

            // kills server-side session.
            session_destroy();

            // kills client-side cookie that stores.
            // the session id.
            if (ini_get("session.use_cookies")) {
                $params = session_get_cookie_params();
                setcookie(session_name(), '', time() - 42000, $params["path"], $params["domain"], $params["secure"], $params["httponly"]);
            }
            // Clear actions and reload page.
            unset($_GET['action']);
            header('location:index.php');
            exit();
        }
        // Clear actions.
        unset($_GET['action']);
    } else {
        // Cleaned up an error, might be redundant now.
        unset($_SESSION['messageTitle']);
        unset($_SESSION['message']);
    }
}
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta name="description" content="">
        <meta name="author" content="">

        <title>Index</title>

        <link href="css/bootstrap.min.css" rel="stylesheet">
        <link href="css/template.css" rel="stylesheet">

        <script src="js/bootstrap.min.js"></script>
        <script src="js/jquery-1.11.1.min.js"></script>
        <script src="js/validation.js"></script>
        <script src="ckeditor/ckeditor.js"></script>

        <script src="js/bootstrap.min.js"></script>
        <script src="js/jquery-1.11.1.min.js"></script>
        <script src="js/validation.js"></script>
        <script src="ckeditor/ckeditor.js"></script>

        <!-- Script is from Kevin Liew @ http://www.queness.com, modifications by Michael Fesser -->
        <script>
        // Mixed scripts make formatting explode.      
        <?php
        // Needed due to a combining of scripts.  This will allow the script to deal with both clicks and auto open on it's own.
        if ((isset($_SESSION['loginFailed']) || $_SESSION['accountCreated'] == true) && !isset($_SESSION['userId'])) {
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
            //Cancel the link behaviour
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

            /* Input box fix. */
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
                font-size: 18px;
                color: red;
            }

        </style>
        <!-- End Kevin Liew @ http://www.queness.com -->
    </head>
    <body>
        <div id="menuContainer">
            <div class="menuBar">
                <?php
                // Add menu bar.
                include ('menuBar.php');
                ?>
            </div>
        </div>
        <div class="container offsetTop">
            <div class="banner text-center">
                <h1 id="vetricalAlign">The Wild World of Messages</h1>
            </div>
            <div class="box">
                <div>
                    <h3 class="text-center">What is on your Mind Today?</h3>
                </div><br/>
                <?php
                // Get messages.
                getMessage();
                // Display editor if user is logged in.
                if (isset($_SESSION['userId'])) {
                    ?>
                    <form id="messageForm" action="index.php" method="POST" onsubmit="return validateMessage(this);">
                        <div class="row">
                            <div class="form-group col-lg-4">
                                <label>Title</label>
                                
                                <input type="text" class="form-control" id="messageTitle" name="messageTitle" value="<?php echo (isset($_SESSION['messageTitle']) ? $_SESSION['messageTitle'] : ""); ?>"/>
                                <div id="messageTitleError" class="input-error">&nbsp;</div>
                            </div>
                        </div>  
                        <div class="row">
                            <div class="form-group col-lg-12">
                                <!-- The editor -->
                                <!-- Populate field if editing -->
                                <textarea name="message" cols="80" rows="10" id="message" ><?php echo (isset($_SESSION['message']) ? $_SESSION['message'] : ""); ?></textarea>                              
                                <script>
                                            $(window).load(function() {
                                    CKEDITOR.replace('message');
                                    });
                                </script>
                                <div id="messageError" class="input-error"></div>&nbsp;<br/>
                            </div>                
                            <div class="form-group col-lg-12">
                                <input type="submit" name="submit" id="submit" class="btn btn-default" value="Submit"/>                                                               
                            </div>
                        </div>
                    </form>  
                    <?php
                }
                // Add login.
                include ('login.php');
                ?>
            </div>          
        </div>
    </body>
</html>


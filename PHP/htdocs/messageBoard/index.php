<?php
session_start();
session_regenerate_id(true);

if (!isset($_SESSION['sessionStart'])) {
    $_SESSION['accountCreated'] = false;
    $_SESSION['sessionStart'] = true;
}

include ('databaseFunctions.php');

if (isset($_SESSION['userId'])) {
    if (isset($_POST['message'])) {
        if (isset($_SESSION['editMessage'])) {
            editMessage();
        } else {
            insertMessage();
        }
    }

    if (isset($_GET['action'])) {
        if ($_GET['action'] == "delete") {
            deleteMessage();
            unset($_SESSION['messageTitle']);
            unset($_SESSION['message']);
        } else if ($_GET['action'] == "edit") {
            prepareEditMessage();
        } else if ($_GET['action'] == 'logout') {

            // kills server-side session.
            session_destroy();

            // kills client-side cookie that stores.
            // the session id.
            if (ini_get("session.use_cookies")) {
                $params = session_get_cookie_params();
                setcookie(session_name(), '', time() - 42000, $params["path"], $params["domain"], $params["secure"], $params["httponly"]);
            }
            unset($_GET['action']);
            header('location:index.php');
            exit();
        }
        unset($_GET['action']);
    } else {
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

        <title></title>

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
            $(document).ready(function() {

                //select all the a tag with name equal to modal
                $('a[name=modal]').click(function(e) {
                    //Cancel the link behavior
                    e.preventDefault();

                    //Get the A tag
                    var id = $(this).attr('href');

                    //Get the screen height and width
                    var maskHeight = $(document).height();
                    var maskWidth = $(window).width();

                    //Set heigth and width to mask to fill up the whole screen
                    $('#mask').css({'width': maskWidth, 'height': maskHeight});

                    //transition effect		
                    $('#mask').fadeIn(100);
                    $('#mask').fadeTo("slow", 0.8);

                    //Get the window height and width
                    var winH = $(window).height();
                    var winW = $(window).width();

                    //Set the popup window to center
                    $(id).css('top', winH / 2 - $(id).height() / 2);
                    $(id).css('left', winW / 2 - $(id).width() / 2);

                    //transition effect
                    $(id).fadeIn(2000);
                });
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
            });
        </script>
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
                width:500px; 
                height:250px;
                padding:10px;
                background-color:#ffffff;
            }

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
            <div class="text-center box">
                <h1>Welcome to the website</h1>
            </div>
            <div class="box">
                <h1 class="text-center">The Wild World of Messages</h1>
                <?php
                getMessage();
                if (isset($_GET['action'])) {
                    if ($_GET['action'] == 'login') {
                        include ('login.php');
                    }
                }
                if (isset($_SESSION['userId'])) {
                    ?>
                    <form id="messageForm" action="index.php" method="POST" onsubmit="return validateMessage(this);">
                        <div class="row">
                            <div class="form-group col-lg-4">
                                <label>Title</label>
                                <input type="text" class="form-control" id="messageTitle" name="messageTitle" value="<?php echo (isset($_SESSION['messageTitle']) ? $_SESSION['messageTitle'] : ""); ?>"/>
                                <div id="messageTitleError">&nbsp;</div>
                            </div>
                        </div>  
                        <div class="row">
                            <div class="form-group col-lg-12">
                                <textarea name="message" cols="80" rows="10" id="message" ><?php echo (isset($_SESSION['message']) ? $_SESSION['message'] : ""); ?></textarea>                              
                                <script>
                                    $(window).load(function() {
                                        CKEDITOR.replace('message');
                                    });
                                </script>
                                <div id="messageError"></div><br/>
                            </div>                
                            <div class="form-group col-lg-12">
                                <input type="submit" name="submit" id="submit" class="btn btn-default" value="submit"/>                                                               
                            </div>
                        </div>
                    </form>  
                <?php }
                ?>
            </div>
            <!-- Kevin Liew @ http://www.queness.com, modifications by Michael Fesser -->
            <div id="boxes">
                <div id="dialog" class="window">
                    <div class="row">
                        <div class="form-group col-lg-4">
                            <form id="loginForm" action="login.php" method ="POST" onsubmit="return validateLogin(this);">        
                                <label>Username: </label><input type="text" id="username" class="modal-input" name="username"/>
                                <div id="usernameError" class="index-error-fix">&nbsp;</div>     
                                <label>Password: </label><input type="password" id="password" class="modal-input" name="password" />
                                <div id="passwordError" class="index-error-fix">&nbsp;</div><br/>
                                <input type="submit" name="submit" value ="submit" class="btn btn-default"/>
                                <input type="button" value="cancel" class="btn btn-default cancel"/>      
                            </form>
                        </div>
                    </div>
                </div>
                <div id="mask"></div>
            </div>
            <!-- End Kevin Liew @ http://www.queness.com -->
        </div>
    </body>
</html>


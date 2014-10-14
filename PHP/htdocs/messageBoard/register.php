<?php
require_once('recaptchalib.php');
if (isset($_POST['username'])) {
    $_SESSION['username'] = $_POST['username'];
    $_SESSION['firstName'] = $_POST['firstName'];
    $_SESSION['lastName'] = $_POST['lastName'];
    $_SESSION['email'] = $_POST['email'];
    $privatekey = "6Lcu4PsSAAAAAKDjWsLF81zOfs8C6pYNwN9K6NVO";
    $resp = recaptcha_check_answer($privatekey, $_SERVER["REMOTE_ADDR"], $_POST["recaptcha_challenge_field"], $_POST["recaptcha_response_field"]);
    if (!$resp->is_valid) {
        $_SESSION['failedCATCHPA'] = true;
    } else {
        include ('databaseFunctions.php');
        $_SESSION['failedCATCHPA'] = false;
        registration();
        if ($_SESSION['accountCreated'] == true) {
            header('location:index.php');
            exit();
        } else{
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

        <title></title>

        <link href="css/bootstrap.min.css" rel="stylesheet">
        <link href="css/template.css" rel="stylesheet">

        <script src="js/bootstrap.min.js"></script>
        <script src="js/jquery-1.11.1.min.js"></script>
        <script src="js/validation.js"></script>
        <script src="ckeditor/ckeditor.js"></script>
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
                <h3 class="text-center">Register a new account</h3>
                <div class="row">
                    <div class="form-group col-lg-4 col-md-offset-4 offsetTop">
                        <form id="registrationForm" action="register.php" method ="POST" onsubmit="return validateRegister(this);">
                            <div>
                                <?php
                                if (isset($_SESSION['failedCATCHPA']) && $_SESSION['failedCATCHPA'] == true) {
                                    echo "The reCAPTCHA wasn't entered correctly.";
                                    unset($_SESSION['failedCATCHPA']);
                                } 
                                ?>
                            </div>
                            <div>
                                <?php
                                if (isset($_SESSION['accountCreated']) && $_SESSION['accountCreated'] == false) {
                                    echo "Sorry the username is taken.";
                                } 
                                ?>
                            </div>
                            <label>Username: </label><input type="text" id="username" class="form-control"  name="username" value="<?php echo (isset($_SESSION['username']) ? $_SESSION['username'] : ""); ?>"/>
                            <div id="usernameError">&nbsp;</div>
                            <label>First Name: </label><input type="text" id="firstName" class="form-control" name="firstName" value="<?php echo (isset($_SESSION['firstName']) ? $_SESSION['firstName'] : ""); ?>"/>
                            <div id="firstNameError">&nbsp;</div>
                            <label>Last Name: </label><input type="text"  id="lastName" class="form-control" name="lastName" value="<?php echo (isset($_SESSION['lastName']) ? $_SESSION['lastName'] : ""); ?>"/>
                            <div id="lastNameError">&nbsp;</div>           
                            <label>Email: </label><input type="text" id = "email" class="form-control" name="email" value="<?php echo (isset($_SESSION['email']) ? $_SESSION['email'] : ""); ?>" />
                            <div id="emailError">&nbsp;</div>
                            <label>Confirm Email: </label><input type="text" id="email2" class="form-control" name="email2" value="<?php echo (isset($_SESSION['email']) ? $_SESSION['email'] : ""); ?>"/>
                            <div id="emailError2">&nbsp;</div>
                            <label>Password: </label><input type="password" id="password" class="form-control" name="password" />
                            <div id="passwordError">&nbsp;</div>
                            <label>Confirm Password: </label><input type="password" id="password2" class="form-control" name="password2" />
                            <div id="passwordError2">&nbsp;</div><br/>
                            <?php
                            $publickey = "6Lcu4PsSAAAAAOwCONvxiJyQT0JHq81xVwfba5-h"; // you got this from the signup page
                            echo recaptcha_get_html($publickey);
                            ?>                          
                            <input type="submit" name="submit" class="btn btn-default" value ="submit" />
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </body>
</html>




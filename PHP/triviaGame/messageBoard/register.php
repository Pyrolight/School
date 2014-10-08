<?php
include ('database.php');
if (isset($_POST['username'])) {
    registration();
    if ($_SESSION['accountCreated'] == false) {
        echo "Username is already taken";
    } else if ($_SESSION['accountCreated'] == true) {
        header('location:index.php');
        exit();
    }
}
?>
<html>
    <head>
        <meta charset="UTF-8">
        <link rel="stylesheet" type="text/css" href="messageBoard.css">
        <script src="validation.js"></script>
        <title></title>
    </head>
    <body>
        <div>
            <form id="registrationForm" action="register.php" method ="POST" onsubmit="return validateRegister(this);">
                <label>Username: </label><input type="text" id="username" name="username" /><div id="usernameError"></div>
                <label>First Name: </label><input type="text" id="firstName" name="firstName" value="<?php echo (isset($_SESSION['firstName']) ? $_SESSION['firstName'] : ""); ?>"/><div id="firstNameError"></div>
                <label>Last Name: </label><input type="text"  id="lastName" name="lastName" value="<?php echo (isset($_SESSION['lastName']) ? $_SESSION['lastName'] : ""); ?>"/><div id="lastNameError"></div>           
                <label>Email: </label><input type="text" id = "email" name="email" value="<?php echo (isset($_SESSION['email']) ? $_SESSION['email'] : ""); ?>" /><div id="emailError"></div>
                <label>Confirm Email: </label><input type="text" id="email2" name="email2" value="<?php echo (isset($_SESSION['email']) ? $_SESSION['email'] : ""); ?>"/><div id="emailError2"></div>
                <label>Password: </label><input type="password" id="password" name="password" /><div id="passwordError"></div>
                <label>Confirm Password: </label><input type="password" id="password2" name="password2" /><div id="passwordError2"></div>
                <input type="submit" name="submit" value ="submit" />
            </form>
        </div>
    </body>
</html>




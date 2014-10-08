<?php
// Make sure the exported database has admin privileges.
/*
  grant select,insert,update,delete on message_board.*
  to 'mfesser_user'@'localhost'
  identified by 'mfesser_password';
  flush privileges;
 */
session_start();
session_regenerate_id(true);

if (!isset($_SESSION['sessionStart'])) {
$_SESSION['accountCreated'] = false;
$_SESSION['sessionStart'] = true;
}

echo $_SESSION['accountCreated'];
if ($_SESSION['accountCreated'] == true){
    echo "acount created!";
}

include ('database.php');

if (isset($_POST['password'])) {
    login();
}
?>
<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <link rel="stylesheet" type="text/css" href="messageBoard.css">
        <script src="validation.js"></script>
        <title></title>
    </head>
    <body>
        <div id="mainDiv">
        <?php
        include ('menuBar.php');
        getMessages();
        if (isset($_GET['action'])){
            if ($_GET['action'] == 'login') {
        include ('login.php');
        }}
        ?>
        </div>
    </body>
</html>

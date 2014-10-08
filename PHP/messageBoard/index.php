<?php
session_start();
include ('database.php');

if (isset($_POST['username'])){
    registration();
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
<?php
include ('menuBar.php');
getMessages();
include ('register.php');
?>

    </body>
</html>

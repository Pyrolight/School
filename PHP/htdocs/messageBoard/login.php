<?php
include ('databaseFunctions.php');

if (isset($_POST['password'])) {
    login();
    header('location:index.php');
    exit();
}
?>


<?php
    // Author: Don Bowers/Eric Coffin
    // Date: Sept 8, 2014
    // Purpose: Check for cookie and if it is not set send user back to login. Note that we do not need any html on this page as nothing
    // actually gets rendered.
    if ( ! isset($_COOKIE['userName']) )
    {
        // if the user does not have a cookie 'userName', we send them packing back to
        // the login screen with the header() function.
        // in order to use setcookie() or header() we must not have any
        // text output to the user (eg. even something like a space before the <?php on line one
        // It will yield an error like:

        //Warning: Cannot modify header information - headers already sent by
        //(output started at C:\Program Files\XAMPP\htdocs\test\require_login.php:1)
        //in C:\Program Files\XAMPP\htdocs\test\require_login.php on line 8

        // ideally we will store this file in a directory that the user cannot access via URL.

        header('Location: login.php');
    }
?>
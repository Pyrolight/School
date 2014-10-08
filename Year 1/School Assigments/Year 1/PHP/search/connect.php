<?php

$con = new mysqli('localhost', 'root', '', 'largeco');

if ($con->connect_errno) {
    echo "$con->connect_errno";
}
?>

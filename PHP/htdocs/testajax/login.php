<?php
session_start();
$username = 'demouser';
$password = 'demopass';
if (isset($_POST)) {
	$post_username = $_POST['username'];
	$post_password = $_POST['password'];
	if ($username == $post_username && $password == $post_password) {
	$_SESSION['username'] = $post_username;
	echo $post_username;
	} 
}
?>
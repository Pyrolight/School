<?php

if (!isset($_POST['updateCustomer'])) {
    echo "Nope";
    exit();
}


$code = addslashes($_POST['code']);
$fName = addslashes($_POST['fName']);
$lName = addslashes($_POST['lName']);
$street = addslashes($_POST['street']);
$city = addslashes($_POST['city']);
$state = addslashes($_POST['state']);
$zip = addslashes($_POST['zip']);
$balance = addslashes($_POST['balance']);

require 'connect.php';

$query = "UPDATE lgcustomer SET cust_code=$code, cust_fname='$fName',cust_lname='$lName',cust_street='$street',cust_city='$city',cust_state='$state',cust_zip='$zip',cust_balance=$balance where cust_code=$code limit 1;";

$con->query($query);


?>


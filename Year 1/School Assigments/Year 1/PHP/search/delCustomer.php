<?php

require 'connect.php';

$code = addslashes($_GET['id']);

$query = "Delete from lgcustomer where cust_code = $code limit 1";

$con->query($query);

$con->close();



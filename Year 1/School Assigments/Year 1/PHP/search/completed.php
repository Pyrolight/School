<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <link href="template.css" rel="stylesheet">
        <title></title>
    </head>
    <body>
        <div class="mainDiv center">   

            <?php
            if (isset($_POST['newCustomer'])) {

                require 'connect.php';

                $code = addslashes($_POST['code']);
                $fName = addslashes($_POST['fName']);
                $lName = addslashes($_POST['lName']);
                $street = addslashes($_POST['street']);
                $city = addslashes($_POST['city']);
                $state = addslashes($_POST['state']);
                $zip = addslashes($_POST['zip']);
                $balance = addslashes($_POST['balance']);

                $query = "INSERT INTO lgcustomer(cust_code, cust_fname, cust_lname, cust_street, cust_city, cust_state, cust_zip, cust_balance) VALUES ($code,$fName,$lName,$street,$city,$state,$zip,$balance)";

                $con->query($query);
                $con->close();

                echo "The insert operation was completed";
            } else if (isset($_POST['updateCustomer'])) {


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

                echo "The edit operation was completed";
                
            } else if (!empty($_GET['id'])) {

                require 'connect.php';

                $code = addslashes($_GET['id']);

                $query = "Delete from lgcustomer where cust_code = $code limit 1";

                $con->query($query);

                $con->close();

                echo "The delete operation was completed";
            }
            echo "<br /><a href=\"index.php\">Go back to the main page.</a>"
            ?>
            
        </div>
    </body>
</html>

<?php
if (empty($_GET['id'])) {
    echo "no code";
    exit();
}

require 'connect.php';

$search = addslashes($_GET['id']);
$query = "select * from lgcustomer where cust_code = $search";

$result = $con->query($query);

if ($result->num_rows == 0) {
    echo "no results";
    exit();
}

$row = $result->fetch_assoc();
?>

<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
        <link href="template.css" rel="stylesheet">
    </head>
    <body>
        <div class="mainDiv">  
        <form action ="completed.php" method ="POST">
            <table>
                <tr>
                    <td>Customer Code</td><td><input type="text" name="code" value="<?php echo $row['cust_code']; ?>"/></td>
                </tr>
                <tr>
                    <td>First Name</td><td><input type="text" name="fName" value="<?php echo $row['cust_fname']; ?>"/></td>
                </tr>
                <tr>
                    <td> Last Name</td><td><input type="text" name="lName" value="<?php echo $row['cust_lname']; ?>"/></td>
                </tr>
                <tr>
                    <td> Street Address</td><td><input type="text" name="street" value="<?php echo $row['cust_street']; ?>"/></td>
                </tr>
                <tr>
                    <td>City</td><td><input type="text" name="city" value="<?php echo $row['cust_city']; ?>"/></td>
                </tr>
                <tr>
                    <td>State</td><td><input type="text" name="state" value="<?php echo $row['cust_state']; ?>"/></td>
                </tr>
                <tr>
                    <td>Zip Code</td><td><input type="text" name="zip" value="<?php echo $row['cust_zip']; ?>"/></td>
                </tr>
                <tr>
                    <td>Balance</td><td><input type="text" name="balance" value="<?php echo $row['cust_balance']; ?>"/></td>
                </tr>
                <tr>
                    <td></td><td><input type="submit" name="updateCustomer" value="Update Customer"/></td>  
                </tr>  
            </table>           
        </form>    
        </div>
    </body>
</html>
<?php
$result->free();
$con->close();
?>




<?php
if (!isset($_POST['submit'])) {
    echo "Nope";
    exit();
}

require 'connect.php';

$numRecords = addslashes($_POST['numRecords']);
$sortBy = addslashes($_POST['sortBy']);
$sort = addslashes($_POST['sort']);
$lName = addslashes($_POST['lName']);
$fName = addslashes($_POST['fName']);

$query = "select * from lgcustomer where cust_fname like '$fName%' AND cust_lname like '$lName%' order by $sortBy $sort  limit $numRecords;";
$result = $con->query($query);


if ($result->num_rows == 0) {
    echo "Sorry no results";
    exit();
}

$numResults = $result->num_rows;
?>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <link href="template.css" rel="stylesheet">
        <title></title>
    </head>
    <body>
        <div class="mainDiv">          
            <table id="secondTable">
                <tr><th>Customer Code</th><th>First Name</th><th>Last Name</th><th>Street Address</th><th>City</th><th>State</th><th>Zip Code</th><th>Balance</th><th>Edit</th><th>Delete</th><th>Add</th></tr>
                <?php
                while ($row = $result->fetch_assoc()) {
                    echo "<tr>";
                    echo"<td>" . stripslashes($row['cust_code']) . "</a></td><td>" . stripslashes($row['cust_fname']) . "</td><td>" . stripslashes($row['cust_lname']) . "</td><td>" . stripslashes($row['cust_street']) . "</td>"
                    . "<td>" . stripslashes($row['cust_city']) . "</td><td>" . stripslashes($row['cust_state']) . "</td><td>" . stripslashes($row['cust_zip']) . "</td><td>$" . stripslashes($row['cust_balance']) . "</td><td><a href=\"edit.php?id=" . stripslashes($row['cust_code']) . "\">Edit</a></td>\n"
                    . "<td><a href=\"delCustomer.php?id=" . stripslashes($row['cust_code']) . "\">Delete</a></td><td><a href=\"newCustomer.php\">Add</a></td>";
                    echo "</tr>\n";
                }
                $result->free();
                $con->close();
                ?>
            </table>
        </div>
    </body>
</html>


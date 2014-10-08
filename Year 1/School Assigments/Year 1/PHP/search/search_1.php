<?php
//if (!isset($_POST['submit'])) {
//    echo "Nope";
//    exit();
//}

require 'connect.php';

$numRecords = addslashes($_GET['numRecords']);
$pagation = addslashes($_GET['pagation']);
$sortBy = addslashes($_GET['sortBy']);
$sort = addslashes($_GET['sort']);
$lName = addslashes($_GET['lName']);
$fName = addslashes($_GET['fName']);

if (empty($_GET['id']) || $_GET['id'] == 1) {
    $start = 0;
    $index =1;
} else {
    $start = (addslashes($_GET['id'] -1 ) * $pagation + 1);
    $index = $_GET['id'];
}

$query = "select * from lgcustomer where cust_fname like '$fName%' AND cust_lname like '$lName%' order by $sortBy $sort  limit $start, $numRecords;";
$result = $con->query($query);
$numResults = $result->num_rows;
$pages = ceil($numResults / $pagation);


if ($result->num_rows == 0) {
    echo "Sorry no results";
    exit();
}
$result->free();

if ($pagation > $numRecords){
    $pagation = $numRecords;
}
$queryPage = "select * from lgcustomer where cust_fname like '$fName%' AND cust_lname like '$lName%' order by $sortBy $sort  limit $start, $pagation;";
$resultPage = $con->query($queryPage);


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
                while ($row = $resultPage->fetch_assoc()){              
                    echo "<tr>";
                    echo"<td>" . stripslashes($row['cust_code']) . "</a></td><td>" . stripslashes($row['cust_fname']) . "</td><td>" . stripslashes($row['cust_lname']) . "</td><td>" . stripslashes($row['cust_street']) . "</td>"
                    . "<td>" . stripslashes($row['cust_city']) . "</td><td>" . stripslashes($row['cust_state']) . "</td><td>" . stripslashes($row['cust_zip']) . "</td><td>$" . stripslashes($row['cust_balance']) . "</td><td><a href=\"edit.php?id=" . stripslashes($row['cust_code']) . "\">Edit</a></td>\n"
                    . "<td><a href=\"completed.php?id=" . stripslashes($row['cust_code']) . "\">Delete</a></td><td><a href=\"newCustomer.php\">Add</a></td>";
                    echo "</tr>\n";
                }               
                $con->close();
                ?>
            </table>
            <?php
            for ($i = 1; $i <= $pages; $i++) {
                echo "<a href=\"search_1.php?id=" . $i . "&fName=" . $fName . "&lName=" . $lName . "&sortBy=" . $sortBy . "&sort=" . $sort . "&numRecords=" . $numRecords . "&pagation=" . $pagation . "\">[" . $i . "]</a>";
            }
            ?>
        </div>
    </body>
</html>


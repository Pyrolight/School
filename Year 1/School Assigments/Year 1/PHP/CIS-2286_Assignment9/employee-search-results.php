<?php
$firstName = array();
$lastName = array();
$empNum = array();
$hired = array();
$dateOfBirth = array();
$firstNameInput = $_GET['firstName'];
$lastNameInput = $_GET['lastName'];
$orderBy = $_GET['orderBy'];
$numberRecordsToView = $_GET['view'];
$sortDriection = $_GET['sortDirection'];

// Connect to database.
$mysqli = new mysqli('localhost', 'root', '', 'employees');

// If connection fails output error.
if ($mysqli->connect_errno) {
    die('Could not connect: ' . $mysqli->connect_errno);
    exit();
}

$query = "SELECT * FROM employees WHERE first_name LIKE '$firstNameInput%' AND last_name LIKE '$lastNameInput%' ORDER BY $orderBy $sortDriection LIMIT $numberRecordsToView";

// Put the result sets in variables.
$result = $mysqli->query($query);

$numResults = $result->num_rows;

// Checks to see if there are any rows in results.
if ($result->num_rows > 0) {
    // While there are results return them as an associated array.
    while ($row = $result->fetch_assoc()) {
        array_push($dateOfBirth, $row['birth_date']);
        array_push($firstName, $row['first_name']);
        array_push($lastName, $row['last_name']);
        array_push($hired, $row['hire_date']);
        array_push($empNum, $row['emp_no']);
    }
}
// Free the results set.
$result->free();
$mysqli->close();

?>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Employee Search Results</title>
        <link href="template.css" rel="stylesheet">
    </head>
    <body>
        <?php
        echo "<div class=\"mainDiv\">";
        if ($numResults == 0){
            echo "Sorry there were no results found.</body></html>";
            exit();    
        }
        echo "Number of records found: " . $numResults;
        echo "<table id=\"secondTable\">";
        echo "<tr>";
        echo "<th>Name</th><th>Employee Number</th><th>Birth Date</th><th>Hire Date</th>";
        echo "</tr>";
        for ($i = 0; $i < $numberRecordsToView; $i++) {
            if ($i % 2 == 1){
            echo "<tr style = \"background-color: #DFDFE6;\">";
            } else {
            echo "<tr>";
            }
            echo "<td>" . $firstName[$i] . " " . $lastName[$i] . "</td><td>" . "<a href = \"employeeInfo.php?id=".$empNum[$i]."\">" .$empNum[$i] . "</a></td><td>" . $hired[$i] . "</td><td>" . $dateOfBirth[$i] . "</td>";
        }
        echo "</table>";
        echo "<a href=\"employee-search.php\">Return to Search</a>";
        echo "</div>";
        ?>
    </body>
</html>
<?php
/*   Author: Michael Fesser
 *   Date: April 10, 2014
 *   Purpose: This project is designed to connect to a database and return records
 *   based on an id entered in the address bar.  If no id is entered it will return
 *   the number of employee records.
 *   Last Revision: April 14, 2014
 *   Dependencies: None
 */

$firstName;
$lastName;
$title;
$hired;
$gender;
$dateOfBirth;
$department;
$salary = array();
$startDate = array();
$endDate = array();
$personalInfoTitles = ["Hired", "Gender", "DOB", "Department"];
$personalInfoDB = array();
// Set to 0 to default no records.
$numResults = 0;
// There two variables are used if an id is provided but the number does not match an id in the database.
$idResults = false;
$salaryResult = false;

// Used to clean up the error with an empty id.
if (empty($_GET['id'])) {
    $search = "";
} else {
    // Add slashes for security.
    $search = addslashes($_GET['id']);
}

// Connect to database.
$mysqli = new mysqli('localhost', 'root', '', 'employees');

// If connection fails output error.
if ($mysqli->connect_errno) {
    die('Could not connect: ' . $mysqli->connect_errno);
    exit();
}

// If there is a search id make two queries of the database returning the information about an employee matching that id.
if ($search) {
    //  This gets the employees table records, the department the employee is in, and their current title.  Interestingly a third natural join blanks the results.  
    $queryInfo = "SELECT * FROM departments NATURAL JOIN dept_emp NATURAL JOIN employees , titles WHERE departments.dept_no = dept_emp.dept_no AND dept_emp.emp_no = employees.emp_no AND employees.emp_no = titles.emp_no AND titles.to_date = (SELECT max(to_date) FROM titles) AND employees.emp_no = '$search'";
    //  This gets the salaries of the employee in descending order.
    $querySalary = "SELECT * FROM salaries WHERE emp_no = '$search' ORDER BY to_date DESC";
    // Put the result sets in variables.
    $resultInfo = $mysqli->query($queryInfo);
    $resultSalary = $mysqli->query($querySalary);

    // Checks to see if there are any rows in results.
    if ($resultInfo->num_rows > 0) {
        // While there are results return them as an associated array.
        while ($row = $resultInfo->fetch_assoc()) {
            $dateOfBirth = $row['birth_date'];
            $firstName = $row['first_name'];
            $lastName = $row['last_name'];
            $gender = $row['gender'];
            $hired = $row['hire_date'];
            $title = $row['title'];
            $department = $row['dept_name'];
            $personalInfoDB = [$gender, $hired, $title, $department];
        }
        // Free the results set.
        $resultInfo->free();
        // Used for the the if else in the output div.
        $idResults = true;
    }

    // Checks to see if there are any rows in results.
    if ($resultSalary->num_rows > 0) {
        // While there are results return them as an associated array.
        while ($row = $resultSalary->fetch_assoc()) {
            array_push($salary, $row['salary']);
            array_push($startDate, $row['from_date']);
            // Formatting for the 9999 date issue.
            if (stristr($row['to_date'], "9999")) {
                array_push($endDate, "-");
            } else {
                array_push($endDate, $row['to_date']);
            }
        }
        // Free the results set.
        $resultSalary->free();
        // Used for the the if else in the output div.
        $salaryResult = true;
    }
// If no id is supplied get the number of rows in the employee table.
} else {
    $queryCount = "SELECT emp_no FROM employees";
    $resultCount = $mysqli->query($queryCount);
    if ($resultCount->num_rows > 0) {
        // Count number of rows.
        $numResults = $resultCount->num_rows;
        // Free the results set.
        $resultCount->free();
    }
}

// Close the database connection.
$mysqli->close();
?>

<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Employee Info</title>
        <link href="template.css" rel="stylesheet">
    </head>
    <body>
        <?php
        echo"<div id=\"mainDiv\">";
        // If no id was supplied inform the user by returning the number of employee records.
        if ($numResults > 0) {
            echo "<div style = \"text-align:center\">There are " . $numResults . " employee records in the database.</div>";
        } else {
            // If the id is valid but there are no results for it inform the user.
            if (!$idResults) {
                echo "<div style = \"text-align:center\">That was not a valid id for a result set.</div>";
                // Normal record output.
            } else {
                echo "<div class=\"bolded\">" . $firstName . " " . $lastName . ", " . $title . "</div>";
                echo "<table id=\"firstTable\">\n";
                for ($i = 0; $i < sizeof($personalInfoDB); $i++) {
                    echo "<tr><td>" . $personalInfoTitles[$i] . "</td><td>" . $personalInfoDB[$i] . "</td></tr>\n";
                }
                echo "<tr>";
                echo "<td>Salary History:</td>";
                echo "</tr>\n";
                echo "<tr>";
                echo "</table>\n    ";
            }
            // If the id is valid but there are no results for it inform the user.
            if (!$salaryResult) {
                echo "<div style = \"text-align:center\">That was not a valid id for a result set.</div>";
                // Normal record output.    
            } else {
                echo "<table id=\"secondTable\">\n";
                echo "<tr>";
                echo "<th>Salary</th><th>Start Date</th><th>End Date</th>";
                echo "</tr>";
                // Lopp to show only the first 4 salary results.
                for ($i = 0; $i < 4; $i++) {
                    echo "<tr>";
                    echo "<td>$" . $salary[$i] . "</td><td>" . $startDate[$i] . "</td><td>" . $endDate[$i] . "</td>";
                    echo "</tr>\n";
                }
                echo "</table>";
            }
        }
        echo"</div>";
        ?>
    </body>
</html>

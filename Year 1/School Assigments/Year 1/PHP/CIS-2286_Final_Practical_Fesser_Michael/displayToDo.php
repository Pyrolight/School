<?php

/* Author: Michael Fesser
 * Date: April 24, 2014
 * Purpose: This displays all the records for the database.  It also links the the
 * page that deleted the files.
 * Last Revision: April 24, 2014
 * Dependencies: insertToDo
 */

// Connect to database.
require 'connect.php';

// Run the select query.
$query = "SELECT * FROM items ORDER BY priority DESC";
$result = $con->query($query);
?>

<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <link href="todo.css" rel="stylesheet">
        <title>Display To-Do</title>
    </head>
    <body>
        <div class="mainDiv">
            <h1>To-Do List Organizer</h1>
            <h3>The purpose of this page is to display all the records in the todo database.</h3>
            <table id="secondTable">
                <tr><th>ID</th><th>Title</th><th>Priority</th><th>Details</th><th>Remove</th></tr>
                <?php
                // Colour code the results.
                while ($row = $result->fetch_assoc()) {
                    if ($row['priority'] == 3) {
                        echo "<tr style = \"color: red;\">\n";
                    } else if ($row['priority'] == 2) {
                        echo "<tr style = \"color: orange;\">\n";
                    } else if ($row['priority'] == 1) {
                        echo "<tr style = \"color: green;\">\n";
                    }
                    // Display all the rows of the query. Also pass the id of the record selected to deleteToDo when the delete link is clicked.
                    echo "<td>" . stripslashes($row['id']) . "</td><td>" . stripslashes($row['title']) . "</td><td>" . stripslashes($row['priority']) . "</td><td>" . stripslashes($row['details']) . "</td><td><a href=\"deleteToDo.php?id=" . stripslashes($row['id']) . "\">Delete</a></td>";
                    echo "</tr>\n";
                }
                // Release the result set.
                $result->free();
                // Close the database connection.
                $con->close();
                ?>
            </table>
            <br />
            <!-- Page links -->
            <a href="newToDo.php">Go to return to main page</a>
        </div>
        <!-- Footer -->
        <?php
        require 'footer.php';
        ?>
    </body>
</html>
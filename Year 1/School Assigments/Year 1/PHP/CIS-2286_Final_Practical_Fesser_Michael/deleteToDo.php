<?php

/* Author: Michael Fesser
 * Date: April 24, 2014
 * Purpose: This page will delete a record.
 * Last Revision: April 24, 2014
 * Dependencies: displayToDo
 */

// Connect to the database.
require 'connect.php';

// Get the record id that was passed in.
$id = addslashes($_GET['id']);

// Run the delete query.
$query = "DELETE FROM items WHERE id=$id";
$result = $con->query($query);

//Close the database connection.
$con ->close();

?>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <link href="todo.css" rel="stylesheet">
        <title>Delete To-Do</title>
    </head>
    <body>
        <div class="mainDiv">
            <h1>To-Do List Organizer</h1>
            <h3>The purpose of this page is to delete a record in the todo database.</h3>
            <?php
            // Inform user of success.
            echo "The record has been deleted.";
            ?>
            <!-- Page links -->
            <br /><br />
            <a href="newToDo.php">Go to return to main page</a><br />
            <a href="displayToDo.php">Go to the display records page</a>
        </div>
        <!-- Footer -->
        <?php
        require 'footer.php';
        ?>
    </body>
</html>
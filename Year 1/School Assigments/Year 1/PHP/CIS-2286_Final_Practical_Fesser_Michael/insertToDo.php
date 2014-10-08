<!DOCTYPE html>

<!-- Author: Michael Fesser
     Date: April 24, 2014
     Purpose:  The purpose of this page is to insert values into the database.  It 
     is also used to display the values the user entered back to the user.
     Last Revision: April 24, 2014
     Dependencies: newToDo
-->
<html>
    <head>
        <meta charset="UTF-8">
        <link href="todo.css" rel="stylesheet">
        <title>Insert To Do</title>
    </head>
    <body>
        <div class="mainDiv">
            <h1>To-Do List Organizer</h1>
            <h3>The purpose of this page is to validate the user input and add it to the database.  </h3>
            <?php
            
            // Check to see if the post array is empty, return error if it is, and provide a link back to the main page.
            if (empty($_POST['title'])) {
                echo "You left the title field empty.  Please click the link below to return to the previous page. <br />";
                echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a></div></body></html>";
                exit();
            }
            
            // Required constants.
            define('TITLE_LENGTH', 512);
            define('MESSAGE_LENGTH', 1024);
            $title = trim($_POST['title']);
            $description = trim($_POST['description']);
            $priority = trim($_POST['priority']);

            // Check to see if the title length is too long, return error if it is, and provide a link back to the main page.
            if (strlen($title) > TITLE_LENGTH) {

                echo "Sorry the title is too long by " . (strlen($title) - TITLE_LENGTH) . " characters.   Please click the link below to return to the previous page. <br />";
                echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a></div></body></html>";
                // End script.
                exit();
            }
            
            // Check to see if the description is too long, return error if it is, and provide a link back to the main page.
            if (strlen($description) > MESSAGE_LENGTH) {
                echo "Sorry the description is too long by " . (strlen($description) - MESSAGE_LENGTH) . " characters.   Please click the link below to return to the previous page. <br />";
                echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a></div></body></html>";
                // End script.
                exit();
            }
            
            // Connect to databse
            require 'connect.php';

            // Add slashes to minimize malicious code.
            $titleInsert = addslashes($title);         
            $descriptionInsert = addslashes($description);
            $priorityInsert = addslashes($priority);

            // Create and run the query.
            $query = "INSERT INTO items (title, priority, details) VALUES ('$titleInsert', $priorityInsert, '$descriptionInsert');";
            $con->query($query);
            
            // Close the database connection.
            $con->close();
            
            // Output user entered info to the screen.
            echo "Title: " . $title . "<br />";
            echo "Details: ". $description . "<br />";
            // Modify the colour of the priority based on its importance.
            switch ($priority) {
                case 1:
                    echo "Priority: <span style=\"color:green\">Low</span>";
                    break;
                case 2:
                    echo "Priority: <span style=\"color:orange\">Medium</span>";
                    break;
                case 3:
                    echo "Priority: <span style=\"color:red\">High</span>";
                    break;
            }
            
            // Inform user of successful data insert.
            echo "<br /><br />The information was added successfully.<br />";
            ?>
            
            <br />
            <!-- Page links -->
            <a href="newToDo.php">Go to return to main page</a><br />
            <a href="displayToDo.php">Go to the display records page</a>
        </div>
        <!-- Footer -->
        <?php
        require 'footer.php';
        ?>
    </body>
</html>              

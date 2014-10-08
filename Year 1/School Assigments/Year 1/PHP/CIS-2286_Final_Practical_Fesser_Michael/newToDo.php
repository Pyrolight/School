<!DOCTYPE html>

<!-- Author: Michael Fesser
     Date: April 24, 2014
     Purpose:  The purpose of this page is a basic form.  It will link with other
     pages that will process the information provided.  It is a basic database interface.
     Last Revision: April 24, 2014
     Dependencies: None
-->
<html>
    <head>
        <meta charset="UTF-8">
        <link href="todo.css" rel="stylesheet">
        <title>New To-Do</title>
    </head>
    <body>
        <div class="mainDiv">
            <h1>To-Do List Organizer</h1>
            <h3>The purpose of this page is the input form.</h3>
            <form action ="insertToDo.php" method ="POST">
                <table>
                    <tr>
                        <td>Title:</td><td><input type="text" name="title"/></td>
                    </tr>
                    <tr>
                        <!-- style taken from user470962 on www.stackoverflow.com -->
                        <td>Description: </td><td> <textarea style="width:300px; height:150px;" name ="description" ></textarea></td>
                    </tr>
                    <tr>
                        <td>Priority:</td> <td><select name ="priority">
                                <option value ="1" selected="">Low</option> 
                                <option value ="2" >Medium</option>
                                <option value ="3" >High</option>
                            </select></td>
                    </tr>
                        <td></td><td><input type="submit" name="submit" value="Add to List"/></td>  
                    </tr>  
                </table>
            </form> 
            <br />
            <!-- Page links -->
            <a href="displayToDo.php">Go to the display records page</a>
        </div>
        <!-- Footer -->
        <?php
        require 'footer.php';
        ?>
    </body>
</html> 

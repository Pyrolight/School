<?php
// Required include for the button object.  Include is required... AHAHAHAHAHA
include 'submitButton.php';
?>

<!DOCTYPE html>

<!-- Author: Michael Fesser
     Date: April 3, 2014
     Purpose:  This is a simple test of a book object with the added bonus of a 
               button object.  60/55 here I come.
     Last Revision: April 4, 2014
     Dependencies: None
-->

<html>
    <head>
        <meta charset="UTF-8">
        <title>Add Book</title>
        <link href="template.css" rel="stylesheet">
    </head>
    <body>
        <div class="box">
            <h1 style = "text-align: center">Welcome to Mike's Book Shop</h1>
            
            <form action="process.php" method="POST">
                <label>Title</label>
                <input type ="text" class="inputField row" name="title"/>
                <div class="row" style="font-weight:100;">The title of the book.</div><br />
                <label>Author</label>
                <input type ="text" class="inputField row" name="author"/>
                <div class="row" style="font-weight:100;">The author of the book.</div><br />
                <label>ISBN</label>
                <input type ="text" class="inputField row" name="isbn"/>
                <div class="row" style="font-weight:100;">The ISBN of the book.  This field needs to be numeric and 10 to 13 digits long.</div><br />
                <label>Page Count</label>
                <input type ="text" class="inputField row" name="pageCount"/>
                <div class="row" style="font-weight:100;">The number of pages in the book.  This field needs to be numeric</div><br />
                <label>Cover Type</label>
                <input type ="text" class="inputField row" name="coverType"/>
                <div class="row" style="font-weight:100;">The types of covers are soft and hard.  Please do not enter the word "cover".</div><br />
                <label>User Rating</label>
                <input type ="text" class="inputField row" name="userRating"/> 
                <div class="row" style="font-weight:100;">The ratings should be terrible, poor, average, good or excellent.</div><br />           
                <div id="requiredFields"> All fields are required.</div>
                <?php
                // Create the button object and pass it attributes.  The order must match the order of the constructors input parameters.
                $button = new Button("submit", "", "submit", "submit", "Send");
                // Generate the button.
                $button->makeButton();
                ?>     
            </form>
        </div>
    </body>
</html>

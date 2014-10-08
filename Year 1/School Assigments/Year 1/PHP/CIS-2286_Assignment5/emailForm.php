<!DOCTYPE html>

<!-- Author: Michael Fesser
     Date: Feb 27, 2014
     Purpose:  The purpose of this project is basic email and textarea validation.
               The user enters their email and some text in the textarea box and
               the programs checks to see if it meets all required criteria.
     Last Revision: Feb 28, 2014
     Dependencies: None
-->

<html>
    <head>
        <meta charset="UTF-8">
        <title>Email Form</title>
        <link href="template.css" rel="stylesheet">
    </head>
    <body>
        <div class="box">
            <form action="processEmail.php" method="POST">
                <label>Email</label>
                <input type ="text" class="inputField" name="lastName"/><br />
				<label>Last Name</label>
                <input type ="text" class="inputField" name="firstName"/><br />
				<label>First Name</label>
                <input type ="text" class="inputField" name="email"/><br />
                <label>Message</label>
                <textarea id="message" name="message"></textarea><br />
                <div id="messageText">Please keep the message under 500 characters.</div>
                <input type="submit" name="submit" id="submit" value="Send"/>  
                <?php
                // Set time zone. 
                date_default_timezone_set('Canada/Atlantic');
                // Month, day, year format.
                $date = date("F d, Y");
                echo "<div class = clockFormat>$date</div>"
                ?>
        </div>
    </body>
</html>

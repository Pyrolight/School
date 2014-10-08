<?php

function getMessages() {
    require ('connect.php');
    $query = "SELECT login.`login_name`, `message_title`, `message_contents`, `message_time_stamp`
        FROM `message`,`login` where login.`user_id` = message.`user_id`";
    $result = $con->query($query);

    while ($row = $result->fetch_assoc()) {
        if (count($result) > 0) {

            echo "<table id='messageTable'>";
            echo "<tr><th colspan='2'>" . stripslashes($row['message_title']) . "</th></tr>";
            echo "<tr>";
            echo "<td><table>";
            echo "<tr><td>" . stripslashes($row['login_name']) . "</td></tr>";
            echo "<tr><td>" . stripslashes($row['message_time_stamp']) . "</td></tr>";
            echo "</table></td>";
            echo "<td>" . stripslashes($row['message_contents']) . "</td>\n";
            echo "</tr>";
            echo "</table>";
        }
    }
    // Release the result set.
    $result->free();
    // Close the database connection.
    $con->close();
}

function registration() {
    require ('connect.php');
    $firstName = trim($con->real_escape_string($_POST['firstName']));
    $lastName = trim($con->real_escape_string($_POST['lastName']));
    $username = trim($con->real_escape_string($_POST['username']));
    $email = trim($con->real_escape_string($_POST['email']));
    $password = trim($con->real_escape_string($_POST['password']));
    $hashedPassword = hash("sha256", $password);

    // Create and run the query.
    $query = "INSERT INTO `login`(`login_name`, `login_password`) VALUES ('$username', '$hashedPassword');";
    $con->query($query);
    $query2 = "INSERT INTO `user`(`user_last_name`, `user_first_name`, `user_email`) VALUES ('$lastName', '$firstName', '$email');";
    $con->query($query2);

    // Close the database connection.
    $con->close();
}
?>


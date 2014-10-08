<?php

function getMessages() {
    require ('connect.php');
    $query = "SELECT login.`login_name`, `message_title`, `message_contents`, `message_time_stamp`
        FROM `message`,`login` where login.`user_id` = message.`user_id`";
    $result = $con->query($query);

    $rowCount = $result->num_rows;
    if ($rowCount > 0) {
        while ($row = $result->fetch_assoc()) {
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
    } else {
        echo "<p>Sorry there are no messages at this time.</p>";
    }
    // Release the result set.
    $result->free();
    // Close the database connection.
    $con->close();
}

function registration() {
    require ('connect.php');
    $username = trim($con->real_escape_string($_POST['username']));
    $firstName = trim($con->real_escape_string($_POST['firstName']));
    $lastName = trim($con->real_escape_string($_POST['lastName']));
    $email = trim($con->real_escape_string($_POST['email']));
    $hashedPassword = hash("sha256", trim($con->real_escape_string($_POST['password'])));

    $queryUsername = "SELECT `login_name` FROM `login` WHERE login_name='" . $username . "'";
    $result = $con->query($queryUsername);
    $rowCount = $result->num_rows;

    if ($rowCount == 0) {
        // Create and run the query.
        $queryLogin = "INSERT INTO `login`(`login_name`, `login_password`) VALUES ('$username', '$hashedPassword');";
        $con->query($queryLogin);
        $queryUser = "INSERT INTO `user`(`user_last_name`, `user_first_name`, `user_email`) VALUES ('$lastName', '$firstName', '$email');";
        $con->query($queryUser);
        $_SESSION['accountCreated'] = true;
    } else {
        $_SESSION['firstName'] = $firstName;
        $_SESSION['lastName'] = $lastName;
        $_SESSION['email'] = $email;
        $_SESSION['accountCreated'] = false;
    }
    // Close the database connection.
    $con->close();
}

function login() {
    
}
?>


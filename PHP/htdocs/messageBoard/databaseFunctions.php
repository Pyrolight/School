<?php
/* Author: Michael Fesser
  Date: 10/14/2014
  Purpose: This is the main database access file.  All database access is done via functions.
  It also uses prepared statements for security.
  Last Revision: 10/14/2014
  Dependencies: index.php, login.php, register.php
 */

// Used to deal with so very unpredictable and random session errors.  
if (!isset($_SESSION['sessionStart'])) {
    session_start();
    session_regenerate_id(true);
    $_SESSION['sessionStart'] = true;
}

/**
 * This function queries the database and displays the list of messages.  If are none it informs the user of this fact.
 */
function getMessage() {
    // Connect to the database.
    require ('connect.php');

    // Create the query.
    $stmt = $mysqli->prepare("SELECT login.login_name, message_id, message_title, message_contents, message.user_id, message_time_stamp
        FROM message,login WHERE login.user_id = message.user_id");

    // Execute query.
    $stmt->execute();
    // Used for counting the number of rows.
    $stmt->store_result();
    // Count rows.
    $rowCount = $stmt->num_rows;
    // Secure the result set.
    $stmt->bind_result($loginNameResult, $messageIdResult, $titleResult, $messageResult, $userIdResult, $timeStampResult);

    if ($rowCount > 0) {
        // Get the result array and loop.
        while ($stmt->fetch()) {
            ?>
            <table id="messageTable">
                <tr><th colspan="2"><h4><?php echo $titleResult ?></h4></th></tr>
            <tr>
                <td>
                    <!-- Used as formatting for the user information -->
                    <table>
                        <tr>
                            <td><?php echo $loginNameResult ?></td>
                        </tr>
                        <tr>
                            <td><?php echo $timeStampResult ?></td>
                        </tr>
                    </table>                     
                </td>
                <td><?php echo $messageResult ?></td>
            </tr>
            </table>
            <?php
            // Check if the message belongs to a user and if so allow them to edit and delete.  Confirmation on delete is future functionality.
            if (isset($_SESSION['userId'])) {
                if ($_SESSION['userId'] == $userIdResult) {
                    ?>
                    <div class="text-right">
                        <a href="index.php?action=edit&id=<?php echo $messageIdResult ?>">Edit</a>
                        <a href="index.php?action=delete&id=<?php echo $messageIdResult ?>">Delete</a>
                    </div>
                    <?php
                }
            }
            ?>
            <hr>
            <?php
        }
    } else {
        // No messages message
        echo "<h3 class='text-center'>Sorry there are no messages at this time.</h3>";
    }

    // Close statement.
    $stmt->close();
    // Close connection.
    $mysqli->close();
}

function registration() {
    // Connect to the database.
    require ('connect.php');

    // Create the query.
    $stmt = $mysqli->prepare("SELECT login_name FROM login WHERE login_name=?");
    $stmt->bind_param('s', $username);

    $username = trim($_POST['username']);

    // Execute query.
    $stmt->execute();
    // Used for counting the number of rows.
    $stmt->store_result();
    // Count rows.
    $rowCount = $stmt->num_rows;
    // Close statement.
    $stmt->close();

    if ($rowCount == 0) {
        // Create the query.
        $stmt = $mysqli->prepare("INSERT INTO login(login_name, login_password) VALUES (?,?)");
        // Secure the statement against injection attacks.
        $stmt->bind_param('ss', $username, $hashedPassword);

        // Get user variables and add security to password.
        $username = trim($_POST['username']);
        $hashedPassword = hash("sha256", trim($_POST['password']));

        // Execute query.
        $stmt->execute();
        // Close statement.
        $stmt->close();

        // Create the query.
        $stmt = $mysqli->prepare("INSERT INTO user(user_last_name, user_first_name, user_email) VALUES (?,?,?)");
        // Secure the statement against injection attacks.
        $stmt->bind_param('sss', $firstName, $lastName, $email);

        // Get user variables
        $firstName = trim($_POST['firstName']);
        $lastName = trim($_POST['lastName']);
        $email = trim($_POST['email']);

        // Execute query.
        $stmt->execute();
        // Close statement.
        $stmt->close();

        // Used for the login page and function.  This assumes the user is created.
        $_SESSION['accountCreated'] = true;
        $_SESSION['usernameTaken'] = false;
    } else {
        // Used for the login page and function.  This assumes the user was not created, specifically a username error.
        $_SESSION['accountCreated'] = false;
        $_SESSION['usernameTaken'] = true;
    }
    // Close connection.
    $mysqli->close();
}

function login() {
    // Connect to the database.
    require ('connect.php');

    // Create the query.
    $stmt = $mysqli->prepare("SELECT user_id, login_name FROM login WHERE login_name=? AND login_password=?");
    // Secure the statement against injection attacks.
    $stmt->bind_param('ss', $username, $hashedPassword);

    // Get user variables and add security to password.
    $username = trim($_POST['username']);
    $hashedPassword = hash("sha256", trim($_POST['password']));

    // Execute query.
    $stmt->execute();
    // Used for counting the number of rows.
    $stmt->store_result();
    // Count rows.
    $rowCount = $stmt->num_rows;
    // Secure the result set.
    $stmt->bind_result($userIdResult, $userLoginResult);
    // Get the result array.
    $stmt->fetch();

    // If a user with the correct credentials is found, set their id for use in the system, else return them to the login page.
    if ($rowCount == 1) {
        $_SESSION['userId'] = $userIdResult;
        $_SESSION['username'] = $userLoginResult;
    } else {
        $_SESSION['loginFailed'] = true;
    }
    // Close statement.
    $stmt->close();
    // Close connection.
    $mysqli->close();
}

function deleteMessage() {
    // Connect to the database.
    require ('connect.php');

    // Create the query.
    $stmt = $mysqli->prepare("DELETE FROM message WHERE user_id=? AND message_id=? LIMIT 1");
    // Secure the statement against injection attacks.
    $stmt->bind_param('ii', $userId, $messageId);

    $userId = $_SESSION['userId'];
    $messageId = $_GET['id'];

    // Execute query.
    $stmt->execute();

    // Close statement.
    $stmt->close();
    // Close connection.
    $mysqli->close();
}

function insertMessage() {
    // Connect to the database.
    require 'connect.php';

    // Create the query.
    $stmt = $mysqli->prepare("INSERT INTO message(user_id, message_title, message_contents, message_time_stamp) VALUES (?,?,?,?)");
    // Secure the statement against injection attacks.
    $stmt->bind_param('isss', $userId, $messageTitle, $message, $date);

    $userId = $_SESSION['userId'];
    $messageTitle = trim($_POST['messageTitle']);
    $message = trim($_POST['message']);
    date_default_timezone_set('Canada/Atlantic');
    $date = date("g:i:s A e") . " on " . date("F d, Y");

    // Execute query.
    $stmt->execute();

    // Close statement.
    $stmt->close();
    // Close connection.
    $mysqli->close();

    // Reload the main page.  Kills refresh errors, ie the message appears again.
    header('location:index.php');
    exit();
}

function prepareEditMessage() {
    // Connect to the database.
    require ('connect.php');

    // Create the query.
    $stmt = $mysqli->prepare("SELECT message_title, message_contents FROM message WHERE user_id = ? AND message_id = ?");
    // Secure the statement against injection attacks.
    $stmt->bind_param('ii', $userId, $messageId);

    $userId = $_SESSION['userId'];
    $messageId = $_GET['id'];
    // Get the message id from the message and use it in the database query.
    $_SESSION['messageId'] = $messageId;

    // Execute query.
    $stmt->execute();
    // Secure the result set.
    $stmt->bind_result($titleResult, $contentseResult);
    // Get the result array.
    $stmt->fetch();

    // Used to populate the message form for editing.
    $_SESSION['messageTitle'] = $titleResult;
    $_SESSION['message'] = $contentseResult;

    // Close statement.
    $stmt->close();
    // Close connection.
    $mysqli->close();

    // Used as a control for editing and issues with deleting.
    $_SESSION['editMessage'] = true;
}

function editMessage() {
    unset($_SESSION['editMessage']);
    // Connect to the database.
    require 'connect.php';

    // Create the query.    
    $stmt = $mysqli->prepare("UPDATE message SET message_title=?,message_contents=?,message_time_stamp=? WHERE message_id = ?");
    // Secure the statement against injection attacks.
    $stmt->bind_param('sssi', $messageTitle, $message, $date, $messageId);

    $messageTitle = trim($_POST['messageTitle']);
    $message = trim($_POST['message']);
    date_default_timezone_set('Canada/Atlantic');
    $date = date("g:i:s A e") . " on " . date("F d, Y");
    $messageId = $_SESSION['messageId'];

    // Execute query.
    $stmt->execute();

    // Close statement.
    $stmt->close();
    // Close connection.
    $mysqli->close();

    // Clear the message id and reload the main page.  Kills refresh errors, ie the message appears again.
    unset($_SESSION['messageId']);
    header('location:index.php');
    exit();
}

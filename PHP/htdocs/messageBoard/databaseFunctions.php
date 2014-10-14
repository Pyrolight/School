<?php

function getMessage() {
    require ('connect.php');

    $stmt = $mysqli->prepare("SELECT login.login_name, message_id, message_title, message_contents, message.user_id, message_time_stamp
        FROM message,login WHERE login.user_id = message.user_id");

    $stmt->execute();
    $stmt->store_result();
    $rowCount = $stmt->num_rows;
    $stmt->bind_result($loginNameResult, $messageIdResult, $titleResult, $messageResult, $userIdResult, $timeStampResult);

    if ($rowCount > 0) {
        while ($stmt->fetch()) {
            ?>
            <table id="messageTable">
                <tr><th colspan="2"><h2><?php echo $titleResult ?></h2></th></tr>
            <tr>
                <td>
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
        echo "<h3 class='text-center'>Sorry there are no messages at this time.</h3>";
    }

    $stmt->close();
    $mysqli->close();
}

function registration() {
    require ('connect.php');
    session_start();
    session_regenerate_id(true);

    $stmt = $mysqli->prepare("SELECT login_name FROM login WHERE login_name=?");
    $stmt->bind_param('s', $username);

    $username = trim($_POST['username']);

    $stmt->execute();
    $stmt->store_result();
    $rowCount = $stmt->num_rows;
    $stmt->close();

    if ($rowCount == 0) {
        $stmt = $mysqli->prepare("INSERT INTO login(login_name, login_password) VALUES (?,?)");
        $stmt->bind_param('ss', $username, $hashedPassword);

        $username = trim($_POST['username']);
        $hashedPassword = hash("sha256", trim($_POST['password']));

        $stmt->execute();
        $stmt->close();

        $stmt = $mysqli->prepare("INSERT INTO user(user_last_name, user_first_name, user_email) VALUES (?,?,?)");
        $stmt->bind_param('sss', $firstName, $lastName, $email);

        $firstName = trim($_POST['firstName']);
        $lastName = trim($_POST['lastName']);
        $email = trim($_POST['email']);

        $stmt->execute();
        $stmt->close();
        $_SESSION['accountCreated'] = true;
    } else {
        $_SESSION['accountCreated'] = false;
    }
    $mysqli->close();
}

function login() {
    require ('connect.php');
    session_start();
    session_regenerate_id(true);

    $stmt = $mysqli->prepare("SELECT user_id, login_name FROM login WHERE login_name=? AND login_password=?");
    $stmt->bind_param('ss', $username, $hashedPassword);

    $username = trim($_POST['username']);
    $hashedPassword = hash("sha256", trim($_POST['password']));

    $stmt->execute();
    $stmt->store_result();
    $rowCount = $stmt->num_rows;
    $stmt->bind_result($userIdResult, $userLoginResult);
    $stmt->fetch();

    if ($rowCount == 1) {
        $_SESSION['userId'] = $userIdResult;
        $_SESSION['username'] = $userLoginResult;
    } else {
        echo "Error!";
    }
    $stmt->close();
    $mysqli->close();
}

function deleteMessage() {
    require ('connect.php');
    session_start();
    session_regenerate_id(true);

    $stmt = $mysqli->prepare("DELETE FROM message WHERE user_id=? AND message_id=? LIMIT 1");
    $stmt->bind_param('ii', $userId, $messageId);

    $userId = $_SESSION['userId'];
    $messageId = $_GET['id'];

    $stmt->execute();

    $stmt->close();
    $mysqli->close();
}

function insertMessage() {
    require 'connect.php';
    session_start();
    session_regenerate_id(true);

    $stmt = $mysqli->prepare("INSERT INTO message(user_id, message_title, message_contents, message_time_stamp) VALUES (?,?,?,?)");
    $stmt->bind_param('isss', $userId, $messageTitle, $message, $date);

    $userId = $_SESSION['userId'];
    $messageTitle = trim($_POST['messageTitle']);
    $message = trim($_POST['message']);
    date_default_timezone_set('Canada/Atlantic');
    $date = date("g:i:s A e") . " on " . date("F d, Y");

    $stmt->execute();

    $stmt->close();
    $mysqli->close();

    header('location:index.php');
    exit();
}

function prepareEditMessage() {
    require ('connect.php');
    session_start();
    session_regenerate_id(true);

    $stmt = $mysqli->prepare("SELECT message_title, message_contents FROM message WHERE user_id = ? AND message_id = ?");
    $stmt->bind_param('ii', $userId, $messageId);

    $userId = $_SESSION['userId'];
    $messageId = $_GET['id'];
    $_SESSION['messageId'] = $messageId;

    $stmt->execute();
    $stmt->bind_result($titleResult, $contentseResult);
    $stmt->fetch();

    $_SESSION['messageTitle'] = $titleResult;
    $_SESSION['message'] = $contentseResult;

    $stmt->close();
    $mysqli->close();
    $_SESSION['editMessage'] = true;
}

function editMessage() {
    unset($_SESSION['editMessage']);
    require 'connect.php';
    session_start();
    session_regenerate_id(true);

    $stmt = $mysqli->prepare("UPDATE message SET message_title=?,message_contents=?,message_time_stamp=? WHERE message_id = ?");
    $stmt->bind_param('sssi', $messageTitle, $message, $date, $messageId);

    $messageTitle = trim($_POST['messageTitle']);
    $message = trim($_POST['message']);
    date_default_timezone_set('Canada/Atlantic');
    $date = date("g:i:s A e") . " on " . date("F d, Y");
    $messageId = $_SESSION['messageId'];

    $stmt->execute();

    $stmt->close();
    $mysqli->close();

    unset($_SESSION['messageId']);
    header('location:index.php');
    exit();
}

<!DOCTYPE html>
<!-- Author: Michael Fesser
     Date: Sept 09, 2014
     Purpose: To make us cry! -->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <?php
        session_start();
        if (isset($_GET['action'])) {
            if ($_GET['action'] == 'restart') {

                // kills server-side session
                //session_destroy();
                // kills client-side cookie that stores
                // the session id.
                if (ini_get("session.use_cookies")) {
                    $params = session_get_cookie_params();
                    setcookie(session_name(), '', time() - 42000, $params["path"], $params["domain"], $params["secure"], $params["httponly"]
                    );
                }
            }
            header('location:index.php');
        }

        $randomNumber;
        $guessResult;
        $resultString = "";
        $guessCount;
        if (!isset($_SESSION['random'])) {
            if (empty($_POST)) {
                $_SESSION['random'] = rand(1, 10);
                $_SESSION['guessCount'] = 0;
            }
        }
        if (isset($_SESSION['random'])) {
            $randomNumber = $_SESSION['random'];
            $guessCount = $_SESSION['guessCount'];
        }
        if (isset($_POST['random'])) {
            $guessCount +=1;
            $_SESSION['guessCount'] = $guessCount;
            $guess = $_POST['guess'];
            if (!empty($_POST['guess'])) {
                if ($guess < $randomNumber) {
                    $guessResult = "too low!";
                } else if ($guess > $randomNumber) {
                    $guessResult = "too high!";
                } else if ($guess == $randomNumber) {
                    $guessResult = "correct!  You guessed " . $guessCount . " times!";
                }
                $resultString = "You guessed " . $guess . " which is " . $guessResult;
            } else {
                $resultString = "You need to pick a number";
            }
        }
        ?>
        <h1>Welcome to the number guessing game!</h1>
        <p>Guess a number between 1 and 10</p>
        <form action="index.php" method="POST">
            <input type="text" name="guess" id="guess"/>
            <input type="hidden" name="random" id="random" value="<?php echo $randomNumber ?>"/>
            <input type="submit"/>
        </form>
        <p><?php echo $resultString ?></p>
        <a href='index.php?action=restart'>Game restart</a>
    </body>
</html>

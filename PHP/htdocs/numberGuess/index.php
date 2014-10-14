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
        $randomNumber;
        $guessResult;
        $resultString = "";
        if (empty($_POST)) {
            $randomNumber = rand(1, 10);
        }
        if (isset($_POST['random'])) {
            $randomNumber = $_POST['random'];
            $guess = $_POST['guess'];
            if (!empty($_POST['guess'])) {
                if ($guess < $randomNumber) {
                    $guessResult = "too low!";
                } else if ($guess > $randomNumber) {
                    $guessResult = "too high!";
                } else if ($guess == $randomNumber) {
                    $guessResult = "correct!";
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
    </body>
</html>

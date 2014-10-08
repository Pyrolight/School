
<?php
session_start();
if (isset($_SESSION['finished'])) {
    echo $_SESSION['finished'];
    if ($_SESSION['finished'] == false) {
        $guesses = $_SESSION['guesses'];
        if (isset($_POST['guess']) && $guesses > 0) {
            $guess = $_POST['guess'];
            $wordArray = $_SESSION['wordArray'];
            $correctAnswer = $_SESSION['correctAnswer'];
            for ($i = 0; $i < sizeof($correctAnswer); $i++) {
                if ($guess == $wordArray[$i]) {
                    $correctAnswer [$i] = $guess . " ";
                }
            }

            for ($i = 0; $i < sizeof($correctAnswer); $i++) {
                if ($correctAnswer [$i] == "_ ") {
                    $_SESSION['finished'] = false;
                } else {
                    $_SESSION['finished'] = true;
                    $_SESSION['won'] = true;
                }
                echo $correctAnswer[$i];
            }
            $guesses--;
            if ($guesses == 0) {
                $_SESSION['won'] = false;
                $_SESSION['finished'] = true;
            }
            $_SESSION['correctAnswer'] = $correctAnswer;
        } if ($_SESSION['finished'] == true) {
            echo "you win";
            
        }
    }
}


if (!isset($_SESSION['wordArray'])) {
    $wordArray;
    $word = "alligator";
    for ($i = 0; $i < strlen($word); $i++) {
        $wordArray[$i] = substr($word, $i, 1);
        echo $wordArray [$i] . "\n";
    }
    $guesses = 10;
    for ($i = 0; $i < strlen($word); $i++) {
        $correctAnswer[$i] = "_ ";
        echo $correctAnswer[$i];
    }
    $_SESSION['wordArray'] = $wordArray;
    $_SESSION['guesses'] = $guesses;
    $_SESSION['correctAnswer'] = $correctAnswer;
    $_SESSION['finished'] = false;
}
?>


<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <form id="question" action="index.php" method="post"> 
            <input type="text" name="guess"/>
            <input type="submit" name="submit"/>
        </form>
    </body>
</html>

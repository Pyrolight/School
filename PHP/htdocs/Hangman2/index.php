
<?php
session_start();

if (isset($_SESSION['wordArray'])) {
    if ($_SESSION['gameComplete'] == false) {
        if (isset($_POST['guess'])) {
            $wordArray = $_SESSION['wordArray'];
            $guess = substr($_POST['guess'], 0, 1);
            for ($i = 0; $i < strlen($_SESSION['word']); $i++) {                
                if ($guess == substr($_SESSION['word'], $i, 1)) {
                    $wordArray[$i] = $guess . " ";
                }                             
            }
            for ($i = 0; $i < sizeof($wordArray); $i++){
            echo $wordArray[$i];
            }
            $_SESSION['wordArray'] = $wordArray;
        }
    }
}

if (!isset($_SESSION['wordArray'])) {
    $word = "alligator";
    for ($i = 0; $i < strlen($word); $i++) {
        $wordArray[$i] = "_ ";
        echo $wordArray[$i];
    }
    $_SESSION['wordArray'] = $wordArray;
    $_SESSION['word'] = $word;
    $_SESSION['gameComplete'] = false;
}
?>

<!DOCTYPE html>

<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <form id="guess" action="index.php" method="post" >
            <input type="text" name="guess"/>
            <input type="submit" name="submit"/>
        </form>
    </body>
</html>

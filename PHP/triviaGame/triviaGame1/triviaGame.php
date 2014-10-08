<?php
/*   Author: Michael Fesser
 *   Date: Sept 19, 2014
 *   Purpose: This program is a basic test of session and cookies in the form of a
 *   trivia game.  Cookies will be tested by allowing a change to the text and background
 *   of the page.  Session will be tested as the main functions of the trivia game.
 *   Last Revision: Sept 22, 2014
 *   Dependencies: None
 */

// Used for user response validation.
$noAnswer = "";


// Start the session.
session_start();

// Clear the session.
if (isset($_GET['action'])) {
    if ($_GET['action'] == 'restart') {

        // kills server-side session.
        session_destroy();

        // kills client-side cookie that stores.
        // the session id.
        if (ini_get("session.use_cookies")) {
            $params = session_get_cookie_params();
            setcookie(session_name(), '', time() - 42000, $params["path"], $params["domain"], $params["secure"], $params["httponly"]);
        }
    }
    header('location:triviaGame.php');
    exit();
}

// This sets the cookie with the background and text is changed when an option is chosen.
if (isset($_POST['textColour']) || isset($_POST['backgroundColour'])) {
    setcookie('pageStyleChangeCookie', $_POST['textColour'] . "," . $_POST['backgroundColour'], time() + 60 * 60 * 24 * 365);
    $_SESSION['pageStyleChange'] = true;
    header('location:triviaGame.php');
    exit();
}

// Check to see if there is a session already.
if (isset($_SESSION['triviaArray'])) {
    // Gather the required variables from the session.
    $questionPositionInArray = $_SESSION['questionPositionInArray'];
    $arraySize = $_SESSION['arraySize'];
    $triviaArray = $_SESSION['triviaArray'];
    $numberCorrect = $_SESSION['numberCorrect'];

    // Used to deal with session errors when using the browsers refresh otpion.
    if ($_SESSION['gameCompleted'] == false) {
        // Check to see if the user gave a response to the question.
        if (!empty($_POST['guess'])) {
            $guess = trim($_POST['guess']);
            // Add the users answer to the trivia array.
            $triviaArray[$questionPositionInArray][3] = $guess;
            // Get the correct answer from the trivia array.
            $answerString = $triviaArray[$questionPositionInArray][2];
            // Check the guess vs the answer.
            if (strcmp($guess, $answerString) == 0) {
                $triviaArray[$questionPositionInArray][4] = "correct";
                $numberCorrect++;
            }
            // Goto next question.
            $questionPositionInArray++;
            // Update the session with the changes.
            $_SESSION['questionPositionInArray'] = $questionPositionInArray;
            $_SESSION['triviaArray'] = $triviaArray;
            $_SESSION['numberCorrect'] = $numberCorrect;
            // This is uses as validation when the user doesn't provide a response.  It also checks
            // that an exmpty response was not due to the user changing the page style.    
        } else if (empty($_POST['guess']) && $_SESSION['pageStyleChange'] == false) {
            $noAnswer = "<p>You need to answer the question.</p>";
            // Used to reset the session variable after a page style change.
        } else if ($_SESSION['pageStyleChange'] == true) {
            $_SESSION['pageStyleChange'] = false;
        }
    }
}

// Set up the trivial array on program load.  Should only run once.
if (!isset($_SESSION['triviaArray'])) {
    $numberCorrect = 0;
    $questionPositionInArray = 0;
    $delimiter = "\t";
    $questionNumber = 1;
    // Get the questions and answers from the file.
    $questions = file('QUESTIONS.txt');
    // Count the number of questions in the file.
    $arraySize = count($questions);
    // Build and populate the trivia array from the file.
    for ($i = 0; $i < sizeof($questions); $i++) {
        $triviaArray[$i][0] = $questionNumber;
        // Holds the question and answer for each line in the text file.
        $tempString = $questions[$i];
        // Seperate the questin from the answer into seperate positions in the array.
        $questionAnswer = explode($delimiter, $tempString);
        $triviaArray[$i][1] = $questionAnswer[0];
        $triviaArray[$i][2] = trim($questionAnswer[1]);
        $triviaArray[$i][3] = "";
        $triviaArray[$i][4] = "incorrect";
        $questionNumber++;
    }
    // Add the initial varabiles to the session.
    $_SESSION['arraySize'] = $arraySize;
    $_SESSION['questionPositionInArray'] = $questionPositionInArray;
    $_SESSION['triviaArray'] = $triviaArray;
    $_SESSION['numberCorrect'] = $numberCorrect;
    $_SESSION['pageStyleChange'] = false;
    $_SESSION['gameCompleted'] = false;
}
?>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <link href="triviaGame.css" rel="stylesheet">
        <style type="text/css">
            <?php
            // This is used to set the changes to the background and the text.
            if (isset($_COOKIE['pageStyleChangeCookie'])) {
                // Array used to hold the changes to the page style.
                $styleChange = explode(",", $_COOKIE['pageStyleChangeCookie']);
                echo "body { \n";
                echo "color:" . $styleChange[0] . ";\n";
                echo "background-color:" . $styleChange[1] . ";\n";
                echo "}\n";
            } else {
                // Set the default style.  Seems to be needed to avoid errors in the style change options.
                $styleChange = array("black", "white");
            }
            ?>
        </style>
        <title>Trivia Game</title>
    </head>
    <body>
        <div style="text-align: right;">
            <form id ="colourChange" action="triviaGame.php" method="POST">
                <label class="inline">Text Colour</label><select name="textColour">
                    <!-- Background and text style options.  Will default to the last style change if the cookie is set -->
                    <option value="black" <?php echo ($styleChange[0] == "black" ? "selected" : ""); ?>>Black</option>
                    <option value="darkslategray" <?php echo ($styleChange[0] == "darkslategray" ? "selected" : ""); ?>>Dark Slate Grey</option>
                    <option value="midnightblue" <?php echo ($styleChange[0] == "midnightblue" ? "selected" : ""); ?>>Midnight Blue</option>                                   
                </select>    
                <label class="inline">Background Colour</label><select name="backgroundColour">
                    <!-- Background and text style options.  Will default to the last style change if the cookie is set -->
                    <option value="white" <?php echo ($styleChange[1] == "white" ? "selected" : ""); ?>>White</option>
                    <option value="lightblue" <?php echo ($styleChange[1] == "lightblue" ? "selected" : ""); ?>>Light Blue</option>
                    <option value="orange" <?php echo ($styleChange[1] == "orange" ? "selected" : ""); ?>>Orange Background</option>                                   
                </select>
                <input class="submit" type="submit" value="Update" name="colourSubmit"/>
            </form>
        </div>
        <h1 style="text-align: center">Trivia Game</h1> 
        <div id="box">
            <div id="verticalAlign">
                <?php
                // Make the the question form when there are questions still to be displayed.
                if ($questionPositionInArray < $arraySize) {
                    ?>

                    <form id ="trivia" action="triviaGame.php" method="POST">
                        <!-- Show questions but don't allow modification of it. -->
                        <label>Question:</label><input id="inputFieldQuestion" type="text" name="question" size="80" readonly value="<?php echo $triviaArray[$questionPositionInArray][1]; ?>"/>
                        <div  class="inline">
                            <label>Answer:</label><input id="inputFieldAnswer" type="text" name="guess"/>
                        </div>
                        <input class="submit" type="submit" value="Submit" name="submit"/>
                    </form>  

                    <?php
                    // Show the question count, ie 1 of 8.
                    echo "<p>Question " . ($questionPositionInArray + 1) . " of " . $arraySize . "</p>";
                    // Tell the user if they did not provide and answer.  Page style changes will not affect this.
                    echo $noAnswer;
                }

                // Display the table if the final question was answered.
                if ($questionPositionInArray == $arraySize) {
                    // Used to deal with some errors clicking the browers rfresh button.
                    $_SESSION['gameCompleted'] = true;
                    // Make table heading array.
                    $triviaHeadingsArray = array("Question Number", "Question", "Answer", "Your Answer", "Result");
                    echo "<table>";
                    echo "<tr>";
                    // Build the table headings.
                    foreach ($triviaHeadingsArray as $value) {
                        echo "<th>" . $value . "</th>";
                    }
                    echo "</tr>";
                    // Loop over each row of the populated array.
                    for ($i = 0; $i < sizeof($triviaArray); $i++) {
                        // If the answer was correct make the background green, otherwise make it red.
                        if ($triviaArray[$i][4] == "correct") {
                            echo "<tr style='background-color:lightgreen;'>";
                        } else {
                            echo "<tr style='background-color:lightcoral;'>";
                        }
                        // Populate each column of each row of the table with the matching column in each row of the array.
                        for ($j = 0; $j < sizeof($triviaArray[$i]); $j++) {
                            echo "<td>" . $triviaArray[$i][$j] . "</td>";
                        }
                        echo "</tr>";
                    }
                    echo "</table>";
                    // Calculate the number of correct guesses.
                    $correctGuessPercentage = number_format($numberCorrect / $arraySize * 100, 2);
                    echo "<p>You got " . $correctGuessPercentage . "% correct.  </p>";
                }
                ?>
            </div>
        </div>
        <!-- Link to restart the program. -->
        <p style="text-align: center;"><a href='triviaGame.php?action=restart'>Restart the Game!</a></p>
    </body>
</html>
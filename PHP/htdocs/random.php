<!--
Author: Don Bowers
Purpose: Generate random number in PHP and allow user to guess.

-->
<!DOCTYPE html>
<html>
    <head>
        <title>Random Number</title>
        <script>
        function setFocus()
        {
        document.getElementById("guessbox").focus();
        }
        </script>
    </head>
    <body onload="setFocus()">
        <h2>Guessing Game</h2>
        <?php
        // turn off notices
        ini_set('error_reporting', E_ALL & ~E_NOTICE);

        ///////////////////////////////////////////////////////////////////////////////
        // IF THEY CLICKED SUBMIT
        if (isset($_POST['submit'])) {

            // if they didn't guess anything show error
            if (($_POST['guess']) == "") {
                $error = "<span style='color:red; font-weight:bold;'>You must enter a number to guess</span><br />";
                 echo $error;
            }

            // now I need to compare their guess to the secret number that I stored in the form
            // grab their guess from the form
            $guess = intval($_POST['guess']);
            // grab the random number from the form
            $secret = intval($_POST['secret']);

            // if there was no error above
            if (!$error) {

                // echo out the secret number - this can be commented out
                //echo "Shhhh! secret number is: ".$secret."<br />";
                echo "Your Guess: ".$guess."<br />";
                // if they match - echo out success or failure
                if ($guess == $secret) {
                    $msg = "You got it!";
                } else {
                    $msg = "Sorry that wasn't it - Try again above.";
                }
                // get numtries from form - this keeps track of how many times they submitted it
                $numtries = intval($_POST['numtries']);
                // set up counter
                $numtries += 1;
            }

        ///////////////////////////////////////////////////////////////////////////////
        // THIS IS THEIR FIRST TIME LOADING THE PAGE
        } else {
        // on first load I need to choose a random number and store it in the hidden field in the form
        // this is the first time they loaded the form
            if ($numtries == 0) {
                $randNum = rand(0,10);
                echo "Ok Shhhh! secret number is: ".$randNum."<br />";
                echo "Ok I'm thinking of a number between 1 and 10";
            }
            // on first load set hidden numtries field in form to zero
                $numtries = 0;

        }
        ?>

        <form method="POST" action="random.php">
        What is your guess? <input type="text" name="guess" id="guessbox" value="" /><br />
        <input type="hidden" name="secret" value="<?php if ($randNum) { echo $randNum; } else { echo $secret; } ?>" />
        <input type="hidden" name="numtries" value="<?php echo $numtries; ?>" />

        <?php
            // only allow them to try 5 times
            if ($numtries > 5) {
                echo "<input type='button' name='nothing' onclick='void()' value='sorry, out of guesses'/>";
            } else {
                echo "<input type='submit' name='submit' />";
            }
        ?>
</form>

<?php 
    if (!$error) {

        if (isset($_POST['submit'])) { echo $msg; }
        if (isset($_POST['numtries'])) { echo "You tried ".$numtries." time(s)"; }
    }
?>
</body>
</html>
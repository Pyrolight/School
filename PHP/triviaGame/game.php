<?php
session_start();

// to handle user clicking
// game.php?action=restart
// We need to destroy the session
// and clear the session cookie
if(isset($_GET['action'])){
	if($_GET['action'] == 'restart') {
	
		// kills server-side session
		//session_destroy();
		
		// kills client-side cookie that stores
		// the session id.
		if (ini_get("session.use_cookies")) {
			$params = session_get_cookie_params();
			setcookie(session_name(), '', time() - 42000,
				$params["path"], $params["domain"],
				$params["secure"], $params["httponly"]
			);
		}
	}
	header('location:game.php');

}

if(isset($_POST['guess'])) {
	// compare the guess with the answer
	// get the answer from the Session
	$guess = $_POST['guess'];
	$answer = $_SESSION['answer'];
	$guess = trim($guess);
	$guessCount = $_SESSION['guessCount'];
	
	if($guess == ""){
		echo "<p>Provide a guess.</p>";
	}
	else
	{
		$guessCount++;
		$_SESSION['guessCount'] = $guessCount;
		if($guess > $answer) {
			echo "<p>Too high</p>";
		}
		elseif($guess < $answer) {
			echo "<p>Too low.</p>";
		}
		elseif($guess == $answer) {
			// the game should be over.
			$_SESSION['gameover'] = true;
			
		}
	
	}
}
else 
{
	// could be first time loading the game
	// or the game is in progress and the 
	// user has returned to the game.
	
	if(isset($_SESSION['answer']) == false ) {
		$answer = rand(1,10);
		
		echo $answer;
		
		$_SESSION['answer'] = $answer;
		$_SESSION['guessCount'] = 0;
		$_SESSION['gameover'] = false;
	}

}

if($_SESSION['gameover'] == false ) {
?>
<form action="game.php" method="POST">
	Guess<input type="text" name="guess" /><br />
	<input type="submit" name="submit" value="Guess" />
</form>
<?php
}
else // game is over
{
	$answer = $_SESSION['answer'];
	$guessCount = $_SESSION['guessCount'];
	
	echo "<p>$answer is Correct. It took you $guessCount guesses.</p>";
} ?>
<p><a href='game.php?action=restart'>Restart</a></p>
<?php

	// this page handles both
	// the form submission
	// and the displaying of the form.
	// This is fairly standard in Web programming.
	
	if(isset($_POST['lang']) ) {
		
		$lang = $_POST['lang'];
		
		// set lang cookie for 24 hours
		setcookie('lang',$lang,time() + 60*60*24);
		
	}
	elseif (isset($_COOKIE['lang']) )
	{
		$lang = $_COOKIE['lang'];
	}
	else // form has not been submitted, and no cookie
	{
		$lang = "en";
	}

	/*
	The tricky part is setting the default
	selected item for the drop down list.
	
	Here I am using the ternary operator:
	
	<?php echo ($lang == "en" ? "selected" : "" ); ?>
	
	This is the same as saying 
	if ( $lang == "en")
		echo "Selected";
	else
		echo ""
		
	The trick is we do this inline within each option tag.
	*/
?>

<html>
	<form action="language.php" method="POST">
		<select name='lang'>
			<option value="en" <?php echo ($lang == "en" ? "selected":"");?>>English</option>
			<option value="fr" <?php echo ($lang == "fr" ? "selected":"");?>>French</option>
			<option value="pr" <?php echo ($lang == "pr" ? "selected":"");?>>Pirate</option>
		</select>
		<input type="submit" value="Set Language" />
	</form>
</html>

<p>
	<?php
	if($lang == "en") {
		echo "Hello World";
	}
	else if ($lang == "fr" ) {
		echo "Bonjour Monde";
	}
	else if ($lang == "pr" ) {
		echo "Hullo Planet o' mine. Yarr!";
	}
	?>
</p>

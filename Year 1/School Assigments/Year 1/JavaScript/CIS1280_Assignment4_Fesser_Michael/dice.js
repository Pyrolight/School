/**
 *
 * Author: Michael Fesser
 * Date: Oct 26, 2013
 * Purpose: Create a function to emulate a dice roll.
 * Last Revision: Oct 28, 2013
 * Dependencies: dice.html
 */
 
 /**
  * Function to emulate the dice roll using the math.random function.
  */
function rollDice(){
	var diceNumber;
	diceNumber = Math.floor((Math.random()*6)+1);
	
	/* Style each roll result. */
	if (diceNumber == 1) {
		document.getElementById('dice').innerHTML = "<span id = 'dice1'>" + diceNumber + "</span>";
		} else if (diceNumber == 2) {
			document.getElementById('dice').innerHTML = "<span id = 'dice2'>" + diceNumber + "</span>";
		} else if (diceNumber == 3) {
			document.getElementById('dice').innerHTML = "<span id = 'dice3'>" + diceNumber + "</span>";
		} else if (diceNumber == 4) {
			document.getElementById('dice').innerHTML = "<span id = 'dice4'>" + diceNumber + "</span>";
		} else if (diceNumber == 5) {
			document.getElementById('dice').innerHTML = "<span id = 'dice5'>" + diceNumber + "</span>";
		} else if (diceNumber == 6) {
			document.getElementById('dice').innerHTML = "<span id = 'dice6'>" + diceNumber + "</span>";
	}
}
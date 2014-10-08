/**
 *
 * Author: Michael Fesser
 * Date: Oct 25, 2013
 * Purpose: To create a simple app that calculated the tip and total cost from the values
 * for the price of a meal and the percentage tip they wish to give.
 * Last Revision: Oct 28, 2013
 * Dependencies: myTipCalculator.html
 */
 
/**
 * Function to get the cost of the meal and tip and to calculate the result.
 */
function formInput() {
	var bill = document.getElementById('bill').value;
	var tipPercentage = document.getElementById('tipPercentage').value;
	bill = parseFloat(bill);
	tipPercentage = parseFloat(tipPercentage);
	var tip = (bill) * (tipPercentage /100);
	var totalBill = bill + bill * (tipPercentage / 100);
	var resultInfo = "<br /><span style='font-style:italic; font-weight:bold; text-decoration:underline;'>Your Tip Info</span><br /><br />" 
	+ "Total Bill Amount: $" + bill.toFixed(2) + "<br />Tip Percentage: " + tipPercentage.toFixed(2) + "%" 
	+ "<br />Total Tip: $" + tip.toFixed(2) + "<br /><span style='font-weight:bold;'>Total Bill: $" + totalBill.toFixed(2) + "</span>";
	
	document.getElementById('results').innerHTML = resultInfo;  // Send the result to the results Div.
	
	clock();  // Call the clock function.
}

/**
 * Simple clock function to get the local time based on the 24 hour clock.
 */
function clock(){
	var rightNow = new Date();
	var hours = rightNow.getHours();
	var minutes = rightNow.getMinutes();

	if (minutes < 10) { 
		minutes = "0" + minutes; 
	}
	
	document.getElementById('clock').innerHTML="<span style='font-weight:bold;'>The current time is " +hours + ":" + minutes + "</span>";
}
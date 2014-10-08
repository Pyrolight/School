// Author: Don Bowers
// Date: Nov 22, 2013
// Requires: whatif.html
// Purpose: Used to calculate remaining marks required to pass CIS1280
function checkGrades() {
//set category weights 

		var assignmentWeight = .30;
        var challengeWeight = .35;
        var theoryWeight = .10;
        var portfolioWeight = .25;
        //gather vars from form and parse so we can do math
        var a1 = document.getElementById("assignment1").value;
        var a2 = document.getElementById("assignment2").value;
        var a3 = document.getElementById("assignment3").value;
        var a4 = document.getElementById("assignment4").value;
        // get the total of each assignment divide by 4 and then get percentage
        var aTotal = ((parseFloat(a1) + parseFloat(a2) + parseFloat(a3) +parseFloat(a4)) / 4);
        // calculate assignment category final using category weighting
        var aFinal = aTotal * assignmentWeight;
        // gather challenge values	
		var chal1 = document.getElementById("challenge1").value;
        var chal2 = document.getElementById("challenge2").value;	
        var chalTotal = ((parseFloat(chal1) + parseFloat(chal2)) / 2);
        //calculate challenge category final
        var chalFinal = chalTotal * challengeWeight;
        //gather theory test grade
        var test = document.getElementById("theoryTest").value;
        // calculate theoryTest final
        var testFinal = parseFloat(test) * theoryWeight;
        //same for portfolio
        var portfolio = document.getElementById("portfolio").value; 
		var portFinal = parseFloat(portfolio) * portfolioWeight;	
        // add up the category totals and set into final grade box
        var finalGrade = aTotal+ aFinal + chalFinal + testFinal + portFinal;
        document.getElementById("finalGrade").innerHTML = finalGrade.toFixed(2) + "%";	
       if (finalGrade < 60) {
		document.getElementById("finalGrade").style.color = "red";
		} else {
		document.getElementById("finalGrade").style.color = "green";
		}
}
// figure out how many points they need to get to 60 (which is a pass in CIS)  still broken.
	/**	var remPoints = 60 - finalGrade;
        if (remPoints > 0)
        {
        document.getElementById("remPoints")innerHTML = "Remaining points needed to pass " + remPoints.toFixed(2) + ".";
        } else {
		document.getElementById("remPoints")innerHTML = "Relax... You have already passed. Kidding of course, keep working hard!";**/
        }

 //end checkGrades function

//function to reset form
function resetForm() {
window.load() = "whatif.html";
}



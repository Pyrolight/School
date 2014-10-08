/* Author: Michael Fesser
 Date: 12/17/2013
 Purpose: This is the main JavaScript page.  It does the form validation and all the calculations on the JavaScript page.
 Last Revision: 12/17/2013
 Dependencies: about.html, javascript.html
 */

window.onload = clock;

var timer = setInterval(function() {                                            // This makes the clock update every second.
    clock();
}, 1000);

function clock() {                                                              // Basic clock function.
    var time = new Date();
    document.getElementById('clock').innerHTML = time;
}

/* This is the validation for the firstName element on the form in the contact section
 * on about.html.  If there is an error it alerts the user and they cannot proceed until
 * it is rectified.
 */
function validateFirstName() {
    firstName = document.getElementById('firstName').value;
    if (firstName.length > 0) {
        document.getElementById('firstName').style.borderColor = 'green';
        document.getElementById('firstNameError').style.visibility = "hidden";  // Hide error element if field is vaildated.
    } else {
        document.getElementById('firstName').style.borderColor = 'red';         // Show error element if field fails validation.
        document.getElementById('firstNameError').style.visibility = "visible";
        document.getElementById('firstNameError').innerHTML = "Please enter your first name.";
    }
}

/* This is the validation for the lastName element on the form in the contact section
 * on about.html.  If there is an error it alerts the user and they cannot proceed until
 * it is rectified.
 */
function validateLastName() {
    lastName = document.getElementById('lastName').value;
    if (lastName.length > 0) {
        lastName = document.getElementById('lastName').style.borderColor = 'green';
        document.getElementById('lastNameError').style.visibility = "hidden";   // Hide error element if field is vaildated.
    } else {
        lastName = document.getElementById('lastName').style.borderColor = 'red';
        document.getElementById('lastNameError').style.visibility = "visible";  // Show error element field fails validation.
        document.getElementById('lastNameError').innerHTML = "Please enter your last name.";
    }
}

/* This is the validation for the email element on the form in the contact section
 * on about.html.  If there is an error it alerts the user.  It does two checks.
 * 
 * The first check is against a regular expression to see if the email format follows
 * general conventions.  If it does not it only alerts the user to this fact.
 * 
 * The second check makes sure the field is not emprty.  If it is the user is user cannot 
 * proceed until it is rectified.
 */
function validateEmail() { /* validation regular expression from http://mrbool.com/validation-in-javascript-emails-letters-and-empty-input-textbox/25472 */
    email = document.getElementById('email').value;
    var emailValidate = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;  // Regular expression check.
    if (email.length > 0) {                                                     // Empty field check
        if (email.match(emailValidate)) {
            document.getElementById('email').style.borderColor = 'green';        // Hide error element if field is vaildated.
            document.getElementById('emailError').style.visibility = "hidden";
        } else {
            document.getElementById('email').style.borderColor = 'red';         // Show error element field fails validation.
            document.getElementById('emailError').style.visibility = "visible";
            document.getElementById('emailError').innerHTML = "Your email format is either incorrect or non-standard.";
        }
    } else {
        document.getElementById('email').style.borderColor = 'red';             // Show error element field fails validation.
        document.getElementById('emailError').style.visibility = "visible";
        document.getElementById('emailError').innerHTML = "Please enter your email.";
    }
}

/*
 * This function acts as a counter for the text field.  The countdown changes color as 
 * the number of characters left decreases.
 */
function counter() {
    textForm = document.getElementById('textForm').value;
    var counter = textForm.length;
    var charLeft = 500;
    if (counter <= 500) {
        charLeft = charLeft - counter;                                          // Count down by 1.
        if (charLeft >= 250) {                                                  // This whole if structure is what changes the charLeft color.
            document.getElementById('counter').innerHTML = charLeft + " characters left.";
        } else if (charLeft < 250 && charLeft >= 100) {
            document.getElementById('counter').innerHTML = "<span style = 'color:goldenrod'>" + charLeft + "</span>" + " characters left.";
        } else if (charLeft < 100 && charLeft >= 1) {
            document.getElementById('counter').innerHTML = "<span style = 'color:red'>" + charLeft + "</span>" + " characters left.";
        } else if (counter === 500) {
            document.getElementById('counter').innerHTML = "<span style = 'color:red'>" + "No more characters." + "</span>";  // Warn when out of characters.
        }
    }
    if (counter === 0) {                                                        // This alrets the user if they try to submit the form with nothing entered.
        document.getElementById('counter').innerHTML = "Please enter a comment.";
    }
}

/*
 * Submit button to call functions for more validation.
 */
function validateAll() {
    validateFirstName();
    validateLastName();
    validateEmail();
    counter();
}

/*
 * This function makes user the user cannot enter both a point value and percentage mark.  
 * It will clear one or the other field depending on which was picked first.  This is 
 * used on the first form.
 */
function validatePoints() {
    var pointValueMark = parseFloat(document.getElementById('pointValueMark').value);
    var percentageMark = parseFloat(document.getElementById('percentageMark').value) / 100;
    var yourPointMark = parseFloat(document.getElementById('yourPointMark').value);
    var yourPercentageMark = parseFloat(document.getElementById('yourPercentageMark').value);

    /*
     * This clears the "point value marks" from either form.
     */
    if (pointValueMark >= 0 && percentageMark >= 0) {
        document.getElementById('pointValueMark').value = "";
    } else if (yourPointMark >= 0 && yourPercentageMark >= 0) {
        document.getElementById('yourPointMark').value = "";
    }
}

/*
 * This function makes user the user cannot enter both a point value and percentage mark.  
 * It will clear one or the other field depending on which was picked first.  This is 
 * used on the secpnd form.
 */
function validatePercent() {
    var pointValueMark = parseFloat(document.getElementById('pointValueMark').value);
    var percentageMark = parseFloat(document.getElementById('percentageMark').value) / 100;
    var yourPointMark = parseFloat(document.getElementById('yourPointMark').value);
    var yourPercentageMark = parseFloat(document.getElementById('yourPercentageMark').value);

    /*
     * This clears the "percentage value" from either form.
     */
    if (pointValueMark >= 0 && percentageMark >= 0) {
        document.getElementById('percentageMark').value = "";
    } else if (yourPointMark >= 0 && yourPercentageMark >= 0) {
        document.getElementById('yourPercentageMark').value = "";
    }
}

/*
 * This function does four things.  It finds the value for the section, the value of a 
 * project in a section, the value of each mark in a section, and the value for each 
 * mark out of the overall total.
 */
function calculateSectionWeight() {
    var projectMarkTotal = parseFloat(document.getElementById('projectMarkTotal').value);
    var pointValueMark = parseFloat(document.getElementById('pointValueMark').value);
    var percentageMark = parseFloat(document.getElementById('percentageMark').value) / 100;
    var sectionBeforeChange = parseFloat(document.getElementById('sectionBeforeChange').value);
    var sectionAfterChange = parseFloat(document.getElementById('sectionAfterChange').value);
    var totalBeforeChange = parseFloat(document.getElementById('totalBeforeChange').value);
    var totalAfterChange = parseFloat(document.getElementById('totalAfterChange').value);
    var sectionPercentPerMark;
    var totalPercentPerMark;
    var projectValueSection;
    var sectionValue;
    var converstionToValueMark = projectMarkTotal * percentageMark;             // Convert the percentage field to a point mark value for the ease of the math.

    /*
     * This checks which field to use, pointValueMark or percentageMark and then does the calculation
     * to determine the value of each mark per section and each mark agaist the course total.
     */
    if (isNaN(percentageMark)) {                                                // Use pointValueMark.
        sectionPercentPerMark = (sectionAfterChange - sectionBeforeChange) / pointValueMark;
        totalPercentPerMark = (totalAfterChange - totalBeforeChange) / pointValueMark;
    } else if (isNaN(pointValueMark)) {                                         // Use converstionToValueMark (percentage).
        sectionPercentPerMark = (sectionAfterChange - sectionBeforeChange) / converstionToValueMark;
        totalPercentPerMark = (totalAfterChange - totalBeforeChange) / converstionToValueMark;
    }

    projectValueSection = projectMarkTotal * sectionPercentPerMark;             // Calculate the value of the project in the section.
    sectionValue = (totalAfterChange - totalBeforeChange) / (sectionAfterChange - sectionBeforeChange) * 100;  // Calculate the value of the section.

    document.getElementById('sectionPercentPerMark').value = sectionPercentPerMark.toFixed(2) + "%";
    document.getElementById('totalPercentPerMark').value = totalPercentPerMark.toFixed(2) + "%";
    document.getElementById('projectValueSection').value = projectValueSection.toFixed(2) + "%";
    document.getElementById('sectionValue').value = sectionValue.toFixed(2) + "%";
}

/*
 * This function calculates the total mark in a section (of a course).
 */
function calculateSectionTotal() {
    var currentProjectMark = parseFloat(document.getElementById('currentProjectMark').value);
    var yourPointMark = parseFloat(document.getElementById('yourPointMark').value);
    var yourPercentageMark = parseFloat(document.getElementById('yourPercentageMark').value) / 100;
    var sectionTotal = parseFloat(document.getElementById('sectionTotal').value);

    /*
     * Used to hold values without a database.
     */
    var currentMark = parseFloat(document.getElementById('currentMark').value);
    var totalProjectMark = parseFloat(document.getElementById('totalProjectMark').value);
    var totalYourMark = parseFloat(document.getElementById('totalYourMark').value);
    var totalPercentage = parseFloat(document.getElementById('totalPercentage').value);

    totalProjectMark += currentProjectMark;
    totalYourMark += yourPointMark;
    totalPercentage += currentProjectMark * yourPercentageMark;

    /*
     * This checks which field to use, yourPercentageMark or yourPointMark and then does the calculation
     * to determine the value of each mark per section and each mark against the course total.
     */
    if (isNaN(yourPercentageMark)) {                                            // Use yourPointMark.     
        currentMark = totalYourMark / totalProjectMark;
    } else if (isNaN(yourPointMark)) {                                          // Use yourPointMark.
        currentMark = totalPercentage / totalProjectMark;
    }

    sectionTotal = currentMark * 100;

    document.getElementById('currentProjectMark').value = "";
    document.getElementById('yourPointMark').value = "";
    document.getElementById('yourPercentageMark').value = "";
    document.getElementById('sectionTotal').value = sectionTotal.toFixed(2) + "%";

    /*
     * Store variables for repeated use.
     */
    document.getElementById('currentMark').value = currentMark;
    document.getElementById('totalProjectMark').value = totalProjectMark;
    document.getElementById('totalYourMark').value = totalYourMark;
    document.getElementById('totalPercentage').value = totalPercentage;
}

/*
 * This function calculates your total mark by adding up the marks for the sections calculated
 * in the calculateSectionTotal function.
 */
function calculateFinalTotal() {
    var totalWeight = parseFloat(document.getElementById('totalWeight').value) / 100;
    var lastSectionTotal = parseFloat(document.getElementById('sectionTotal').value);
    var finalMark = parseFloat(document.getElementById('finalMark').value);

    lastSectionTotal *= totalWeight;
    finalMark += lastSectionTotal;

    document.getElementById('totalWeight').value = "";
    document.getElementById('sectionTotal').value = 0;
    document.getElementById('currentMark').value = 0;
    document.getElementById('totalProjectMark').value = 0;
    document.getElementById('totalYourMark').value = 0;
    document.getElementById('totalPercentage').value = 0;
    document.getElementById('finalMark').value = finalMark.toFixed(2) + "%";
    document.getElementById('lastSectionTotal').value = lastSectionTotal.toFixed(2) + "%";
}


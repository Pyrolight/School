
/* Author: Michael Fesser
 * Date: Jan 26, 2014
 * Purpose: Some basic JavaScript validation.  
 * Last Revision: Jan 27th, 2014
 * Dependencies: taxReturn.php
 */

window.onload = load;                                                           // Run when page loads.         

/* 
 * This function is used to display "required" on all fields that are required.
 */
function load(){
 document.getElementById('titleSelectorError').innerHTML = "<span id='errorText'>Required</span>";
 document.getElementById('firstNameError').innerHTML = "<span id='errorText'>Required</span>";
 document.getElementById('lastNameError').innerHTML = "<span id='errorText'>Required</span>";
 document.getElementById('addressError').innerHTML = "<span id='errorText'>Required</span>";
 document.getElementById('postalCodeError').innerHTML = "<span id='errorText'>Required</span>";
 document.getElementById('incomeError').innerHTML = "<span id='errorText'>Required</span>";
}

/* 
 * The following functions validate the title, first name, last name, address, postal code and income of the user.
 */

function validateTitle() {
    title = document.getElementById('titleSelector').value;
    if (title !== 'a') {                                                        
        document.getElementById('titleSelector').style.borderColor = 'green';
        document.getElementById('titleSelectorError').style.visibility = "hidden";  // Hide error element if field is validated.
    } else {
        document.getElementById('titleSelector').style.borderColor = 'red';         // Show error element if field fails validation.
        document.getElementById('titleSelectorError').style.visibility = "visible";
        document.getElementById('titleSelectorError').innerHTML = "<span id='errorText'>Please enter your title</span>";
    }
}

function validateFirstName() {
    firstName = document.getElementById('firstName').value;
    if (firstName.length > 0) {
        document.getElementById('firstName').style.borderColor = 'green';
        document.getElementById('firstNameError').style.visibility = "hidden";  // Hide error element if field is validated.
    } else {
        document.getElementById('firstName').style.borderColor = 'red';         // Show error element if field fails validation.
        document.getElementById('firstNameError').style.visibility = "visible";
        document.getElementById('firstNameError').innerHTML = "<span id='errorText'>Please enter your first name.</span>";
    }
}

function validateLastName() {
    lastName = document.getElementById('lastName').value;
    if (lastName.length > 0) {
        document.getElementById('lastName').style.borderColor = 'green';
        document.getElementById('lastNameError').style.visibility = "hidden";  // Hide error element if field is validated.
    } else {
        document.getElementById('lastName').style.borderColor = 'red';         // Show error element if field fails validation.
        document.getElementById('lastNameError').style.visibility = "visible";
        document.getElementById('lastNameError').innerHTML = "<span id='errorText'>Please enter your last name.</span>";
    }
}

function validateAddress() {
    address = document.getElementById('address').value;
    if (address.length > 0) {
        document.getElementById('address').style.borderColor = 'green';
        document.getElementById('addressError').style.visibility = "hidden";  // Hide error element if field is validated.
    } else {
        document.getElementById('address').style.borderColor = 'red';         // Show error element if field fails validation.
        document.getElementById('addressError').style.visibility = "visible";
        document.getElementById('addressError').innerHTML = "<span id='errorText'>Please enter your address.</span>";
    }
}

function validatePostalCode() {
    postalCode = document.getElementById('postalCode').value;
    if (postalCode.length > 0) {
        document.getElementById('postalCode').style.borderColor = 'green';
        document.getElementById('postalCodeError').style.visibility = "hidden"; // Hide error element if field is validated.
    } else {
        document.getElementById('postalCode').style.borderColor = 'red';        // Show error element if field fails validation.
        document.getElementById('postalCodeError').style.visibility = "visible";
        document.getElementById('postalCodeError').innerHTML = "<span id='errorText'>Please enter your postal code.</span>";
    }
}

function validateIncome() {
    income = document.getElementById('income').value;
    if (isNaN(income)) {                                                        // Check to see if income is actually a number.
        document.getElementById('income').style.borderColor = 'red';
        document.getElementById('incomeError').style.visibility = "visible";
        document.getElementById('incomeError').innerHTML = "<span id='errorText'>Those are not numbers.</span>";
    }
    else if (income.length > 0) {
        document.getElementById('income').style.borderColor = 'green';
        document.getElementById('incomeError').style.visibility = "hidden";     // Hide error element if field is validated.
    } else {
        document.getElementById('income').style.borderColor = 'red';            // Show error element if field fails validation.
        document.getElementById('incomeError').style.visibility = "visible";
        document.getElementById('incomeError').innerHTML = "<span id='errorText'>Please enter your income.</span>";
    }
}

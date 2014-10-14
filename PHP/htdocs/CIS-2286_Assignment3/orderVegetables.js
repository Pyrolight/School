/* Author: Michael Fesser
 * Date: Jan 26, 2014
 * Purpose: This page validates more of the input fields.  It also does a running 
 * calculation for the order which should be identical to the processVeggies.php page.
 * 
 * Note: There are some slight rounding issues but that can't be fixed.
 *   
 * Last Revision: Feb 3, 2014
 * Dependencies: orderVegetables.php
 */

window.onload = load;                                                           // Run when page loads. 

var potatoesCost = 5.00;
var carrotsCost = 2.75;
var brusselsSproutsCost = 3.00;
var cauliflowerCost = 3.75;
var deliverFeeWaived = 50.00;
var deliveryCost = 5.00;
var taxRate = .15;


/* 
 * This function is used to display "required" on all fields that are required.
 * It also sets default values for the output fields.
 */
function load() {
    document.getElementById('firstNameError').innerHTML = "<span class='errorText'>Required</span>";
    document.getElementById('lastNameError').innerHTML = "<span class='errorText'>Required</span>";
    document.getElementById('phoneNumberError').innerHTML = "<span class='errorText'>Required</span>";
    document.getElementById('emailError').innerHTML = "<span class='errorText'>Required</span>";
    document.getElementById('currentTotal').innerHTML = "$0.00";
    document.getElementById('taxRate').innerHTML = taxRate * 100;
    document.getElementById('orderTax').innerHTML = "$0.00";
    document.getElementById('deliveryFeeBase').innerHTML = "$" + deliveryCost.toFixed(2);
    document.getElementById('deliveryFee').innerHTML = "$" + deliveryCost.toFixed(2);
    document.getElementById('waivedFee').innerHTML = "$" + deliverFeeWaived.toFixed(2);
    document.getElementById('finalTotal').innerHTML = "$0.00";
}

/* 
 * The following functions validate the title, first name, last name, phone number and e-mail of the user. 
 * They also validate the potatoes, carrots, Brussels sprouts and cauliflower fields to numbers.
 * The bulk of this is a copy paste from the last assignment and the email validation is from the 
 * portfolio project.  
 */

function validateFirstName() {
    var firstName = document.getElementById('firstName').value;
    if (firstName.length > 0) {
        document.getElementById('firstName').style.borderColor = 'green';
        document.getElementById('firstNameError').style.visibility = "hidden";  // Hide error element if field is validated.
    } else {
        document.getElementById('firstName').style.borderColor = 'red';         // Show error element if field fails validation.
        document.getElementById('firstNameError').style.visibility = "visible";
        document.getElementById('firstNameError').innerHTML = "<span class='errorText'>Please enter your first name.</span>";
    }
}

function validateLastName() {
    var lastName = document.getElementById('lastName').value;
    if (lastName.length > 0) {
        document.getElementById('lastName').style.borderColor = 'green';
        document.getElementById('lastNameError').style.visibility = "hidden";  // Hide error element if field is validated.
    } else {
        document.getElementById('lastName').style.borderColor = 'red';         // Show error element if field fails validation.
        document.getElementById('lastNameError').style.visibility = "visible";
        document.getElementById('lastNameError').innerHTML = "<span class='errorText'>Please enter your last name.</span>";
    }
}

function validatePhoneNumber() {
    var phoneNumber = document.getElementById('phoneNumber').value;
    if (phoneNumber.length === 10) {
        document.getElementById('phoneNumber').style.borderColor = 'green';
        document.getElementById('phoneNumberError').style.visibility = "hidden";  // Hide error element if field is validated.
    } else if (isNaN(phoneNumber)) {
        document.getElementById('phoneNumber').style.borderColor = 'red';         // Show error element if field fails validation.
        document.getElementById('phoneNumberError').style.visibility = "visible";
        document.getElementById('phoneNumberError').innerHTML = "<span class='errorText'>Please enter numbers for your phone number.</span>";
    } else if (phoneNumber.length !== 10) {
        document.getElementById('phoneNumber').style.borderColor = 'red';         // Show error element if field fails validation.
        document.getElementById('phoneNumberError').style.visibility = "visible";
        document.getElementById('phoneNumberError').innerHTML = "<span class='errorText'>Please enter 10 digits for your phone number.</span>";
    }
}

function validateEmail() { /* validation regular expression from http://mrbool.com/validation-in-javascript-emails-letters-and-empty-input-textbox/25472 */
    var email = document.getElementById('email').value;
    var emailValidate = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;  // Regular expression check.
    if (email.length > 0) {                                                     // Empty field check
        if (email.match(emailValidate)) {
            document.getElementById('email').style.borderColor = 'green';        // Hide error element if field is vaildated.
            document.getElementById('emailError').style.visibility = "hidden";
        } else {
            document.getElementById('email').style.borderColor = 'red';         // Show error element field fails validation.
            document.getElementById('emailError').style.visibility = "visible";
            document.getElementById('emailError').innerHTML = "<span class='errorText'>Your email format is either incorrect or non-standard.</span>";
        }
    } else {
        document.getElementById('email').style.borderColor = 'red';             // Show error element field fails validation.
        document.getElementById('emailError').style.visibility = "visible";
        document.getElementById('emailError').innerHTML = "<span class='errorText'>Please enter your email.</span>";
    }
}

function validatePotatoes() {
    var potatoes = document.getElementById('potatoes').value;
    if (isNaN(potatoes)) {
        document.getElementById('potatoes').style.borderColor = 'red';         // Show error element if field fails validation.
        document.getElementById('potatoesError').style.visibility = "visible";
        document.getElementById('potatoesError').innerHTML = "<span class='errorText'>Please enter a number for the quantity of potatoes you would like.</span>";
    } else {
        document.getElementById('potatoesError').style.visibility = "hidden";  // Hide error element if field is validated.
        document.getElementById('potatoes').style.borderColor = 'grey';
    }
    total();
}

function validateCarrots() {
    var carrots = document.getElementById('carrots').value;
    if (isNaN(carrots)) {
        document.getElementById('carrots').style.borderColor = 'red';         // Show error element if field fails validation.
        document.getElementById('carrotsError').style.visibility = "visible";
        document.getElementById('carrotsError').innerHTML = "<span class='errorText'>Please enter a number for the quantity of carrots you would like.</span>";
    } else {
        document.getElementById('carrotsError').style.visibility = "hidden";  // Hide error element if field is validated.
        document.getElementById('carrots').style.borderColor = 'grey';
    }
    total();
}

function validateBrusselsSprouts() {
    var brusselsSprouts = document.getElementById('brusselsSprouts').value;
    if (isNaN(brusselsSprouts)) {
        document.getElementById('brusselsSprouts').style.borderColor = 'red';         // Show error element if field fails validation.
        document.getElementById('brusselsSproutsError').style.visibility = "visible";
        document.getElementById('brusselsSproutsError').innerHTML = "<span class='errorText'>Please enter a number for the quantity of Brussels sprouts you would like.</span>";
    } else {
        document.getElementById('brusselsSproutsError').style.visibility = "hidden";  // Hide error element if field is validated.
        document.getElementById('brusselsSprouts').style.borderColor = 'grey';
    }
    total();
}

function validateCauliflower() {
    var cauliflower = document.getElementById('cauliflower').value;
    if (isNaN(cauliflower)) {
        document.getElementById('cauliflower').style.borderColor = 'red';         // Show error element if field fails validation.
        document.getElementById('cauliflowerError').style.visibility = "visible";
        document.getElementById('cauliflowerError').innerHTML = "<span class='errorText'>Please enter a number for the quantity of cauliflower you would like.</span>";
    } else {
        document.getElementById('cauliflowerError').style.visibility = "hidden";  // Hide error element if field is validated.
        document.getElementById('cauliflower').style.borderColor = 'grey';
    }
    total();
}

/*
 * This is the function that creates the running total for the user to see.  
 */
function total() {
    var potatoes = document.getElementById('potatoes').value;
    var carrots = document.getElementById('carrots').value;
    var brusselsSprouts = document.getElementById('brusselsSprouts').value;
    var cauliflower = document.getElementById('cauliflower').value;

    /* There just set the input values to 0 is empty so that the running totals works */
    if (potatoes.length === 0 || isNaN(potatoes)) {
        potatoes = 0;
    }
    if (carrots.length === 0 || isNaN(carrots)) {
        carrots = 0;
    }
    if (brusselsSprouts.length === 0 || isNaN(brusselsSprouts)) {
        brusselsSprouts = 0;
    }
    if (cauliflower.length === 0 || isNaN(cauliflower)) {
        cauliflower = 0;
    }

    var currentTotal;
    var orderTax;
    var finalTotal;

    currentTotal = potatoes * potatoesCost + carrots * carrotsCost + brusselsSprouts * brusselsSproutsCost + cauliflower * cauliflowerCost;
    document.getElementById('currentTotal').innerHTML = "$" + currentTotal.toFixed(2);
    orderTax = currentTotal * taxRate;
    document.getElementById('orderTax').innerHTML = "$" + orderTax.toFixed(2);

    /* Display the price if nothing has been entered, also with and without a delivery fee */
    if (currentTotal === 0) {
        finalTotal = 0;
        document.getElementById('finalTotal').innerHTML = "$" + finalTotal.toFixed(2);
    } else if (currentTotal >= deliverFeeWaived) {
        finalTotal = currentTotal + orderTax;
        var noDeliveryCost = 0;
        document.getElementById('deliveryFee').innerHTML = "$" + noDeliveryCost.toFixed(2);
        document.getElementById('finalTotal').innerHTML = "$" + finalTotal.toFixed(2);
    } else {
        finalTotal = currentTotal + orderTax + deliveryCost;
        document.getElementById('deliveryFee').innerHTML = "$" + deliveryCost.toFixed(2);
        document.getElementById('finalTotal').innerHTML = "$" + finalTotal.toFixed(2);
    }
}

/*
 * This function is used to return the user to the previous page without the loss
 * of any data they imputed to the form, should they end up on the processVegies.php 
 * page without hitting submit or if they hit submit without filling in all the 
 * required fields.  Called form the processVegies.php page.
 */
function error() {
    setTimeout(function() {history.go(-1);}, 5000);  // http://www.codelifter.com/main/tips/tip_015.shtml
}

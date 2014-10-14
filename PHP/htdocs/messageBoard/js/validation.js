/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


function validateRegister() {
    validation = 0;
    username = document.getElementById('username').value;
    firstName = document.getElementById('firstName').value;
    lastName = document.getElementById('lastName').value;
    password = document.getElementById('password').value;
    password2 = document.getElementById('password2').value;
    email = document.getElementById('email').value;
    email2 = document.getElementById('email2').value;
    // Regular expression check.
    var emailValidate = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

    if (username.length > 0) {
        document.getElementById('usernameError').innerHTML = '&nbsp';
        document.getElementById('username').style.borderColor = 'grey';
        document.getElementById('username').value = username;
        validation++;
    } else {
        document.getElementById('username').style.borderColor = 'red';
        document.getElementById('usernameError').innerHTML = "Please enter your username.";
    }

    if (firstName.length > 0) {
        document.getElementById('firstNameError').innerHTML = '&nbsp';
        document.getElementById('firstName').style.borderColor = 'grey';
        document.getElementById('firstName').value = firstName;
        validation++;
    } else {
        document.getElementById('firstName').style.borderColor = 'red';
        document.getElementById('firstNameError').innerHTML = "Please enter your first name.";
    }

    if (lastName.length > 0) {
        document.getElementById('lastNameError').innerHTML = '&nbsp';
        document.getElementById('lastName').style.borderColor = 'grey';
        document.getElementById('lastName').value = lastName;
        validation++;
    } else {
        document.getElementById('lastName').style.borderColor = 'red';
        document.getElementById('lastNameError').innerHTML = "Please enter your last name.";
    }

    if (email.length > 0) {
        if (!email.match(emailValidate)) {
            document.getElementById('email').style.borderColor = 'red';
            document.getElementById('emailError').innerHTML = "Your email format is either incorrect or non-standard.";
        } else {
            document.getElementById('emailError').innerHTML = '&nbsp';
            document.getElementById('email').style.borderColor = 'grey';
            validation++;
        }

        if (email !== email2) {
            document.getElementById('email2').style.borderColor = 'red';
            document.getElementById('emailError2').innerHTML = "You email does not match.";
        } else {
            document.getElementById('emailError2').innerHTML = '&nbsp';
            document.getElementById('email2').style.borderColor = 'grey';
            validation++;
        }
    } else {
        document.getElementById('email').style.borderColor = 'red';
        document.getElementById('emailError').innerHTML = "Please enter your email.";
    }

    if (password.length > 0) {
        if (password.length < 8) {
            document.getElementById('password').style.borderColor = 'red';
            document.getElementById('passwordError').innerHTML = "You password is too short.";
        } else {
            document.getElementById('passwordError').innerHTML = '&nbsp';
            document.getElementById('password').style.borderColor = 'grey';
            validation++;
        }

        if (password !== password2) {
            document.getElementById('password2').style.borderColor = 'red';
            document.getElementById('passwordError2').innerHTML = "You password does not match.";
        } else {
            document.getElementById('passwordError2').innerHTML = '&nbsp';
            document.getElementById('password2').style.borderColor = 'grey';
            validation++;
        }

        // Empty field check
    } else {
        document.getElementById('password').style.borderColor = 'red';
        document.getElementById('passwordError').innerHTML = "Please enter a password.";
    }

    if (validation === 7) {
        return (true);
    } else {
        return (false);
    }
}

function validateLogin() {
    validation = 0;
    username = document.getElementById('username').value;
    password = document.getElementById('password').value;

    if (username.length > 0) {
        document.getElementById('usernameError').innerHTML = '&nbsp';
        document.getElementById('username').style.borderColor = 'grey';
        validation++;
    } else {
        document.getElementById('username').style.borderColor = 'red';
        document.getElementById('usernameError').innerHTML = "Please enter your username.";
    }

    if (password.length > 0) {
        document.getElementById('passwordError').innerHTML = '&nbsp';
        document.getElementById('password').style.borderColor = 'grey';
        validation++;
        // Empty field check
    } else {
        document.getElementById('password').style.borderColor = 'red';
        document.getElementById('passwordError').innerHTML = "Please enter a password.";
    }

    if (validation === 2) {
        return (true);
    } else {
        return (false);
    }
}

function validateMessage() {
    validation = 0;
    messageTitle = document.getElementById('messageTitle').value;
    message = document.getElementById('message').value;

    if (messageTitle.length >= 5 && messageTitle.length <= 100) {
        document.getElementById('messageTitleError').innerHTML = '&nbsp';
        document.getElementById('messageTitle').style.borderColor = 'grey';
        validation++;
    } else {
        document.getElementById('messageTitle').style.borderColor = 'red';
        document.getElementById('messageTitleError').innerHTML = "The title must be between 5 and 100 characters long.";
    }

//    if (message.length >= 10 && message.length <= 500) {
//        document.getElementById('messageError').style.visibility = "hidden";
//        validation++;
//        // Empty field check
//    } else {       
//        document.getElementById('messageError').style.visibility = "visable";
//        document.getElementById('messageError').innerHTML = "The message must be between 10 and 500 characters long.";
//    }

    if (validation === 1) {
        return (true);
    } else {
        return (false);
    }
}


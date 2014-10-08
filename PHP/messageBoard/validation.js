/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


function validateRegister() {
    validation = 0;
    firstName = document.getElementById('firstName').value;
    lastName = document.getElementById('lastName').value;
    username = document.getElementById('username').value;
    password = document.getElementById('password').value;
    password2 = document.getElementById('password2').value;
    email = document.getElementById('email').value;
    email2 = document.getElementById('email2').value;
    // Regular expression check.
    var emailValidate = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

    if (firstName.length > 0) {
        document.getElementById('firstNameError').style.visibility = "hidden";  
        document.getElementById('firstName').style.borderColor = 'grey';
        document.getElementById('firstName').value = firstName;
        validation++;
    } else {
        document.getElementById('firstName').style.borderColor = 'red';         
        document.getElementById('firstNameError').style.visibility = "visible";
        document.getElementById('firstNameError').innerHTML = "Please enter your first name.";
    }

    if (lastName.length > 0) {
        document.getElementById('lastNameError').style.visibility = "hidden";   
        document.getElementById('lastName').style.borderColor = 'grey';
        document.getElementById('firstName').value = lastName;
        validation++;
    } else {
        document.getElementById('lastName').style.borderColor = 'red';
        document.getElementById('lastNameError').style.visibility = "visible";  
        document.getElementById('lastNameError').innerHTML = "Please enter your last name.";
    }

    if (username.length > 0) {
        document.getElementById('usernameError').style.visibility = "hidden";   
        document.getElementById('username').style.borderColor = 'grey';
        document.getElementById('firstName').value = username;
        validation++;
    } else {
        document.getElementById('username').style.borderColor = 'red';
        document.getElementById('usernameError').style.visibility = "visible";  
        document.getElementById('usernameError').innerHTML = "Please enter your username.";
    }

    if (email.length > 0) {                                                     
        if (!email.match(emailValidate)) {
            document.getElementById('email').style.borderColor = 'red';         
            document.getElementById('emailError').style.visibility = "visible";
            document.getElementById('emailError').innerHTML = "Your email format is either incorrect or non-standard.";
        } else {
            document.getElementById('emailError').style.visibility = "hidden";   
            document.getElementById('email').style.borderColor = 'grey';
            validation++;
        }

        if (email !== email2) {
            document.getElementById('email2').style.borderColor = 'red';         
            document.getElementById('emailError2').style.visibility = "visible";
            document.getElementById('emailError2').innerHTML = "You email does not match.";
        } else {
            document.getElementById('emailError2').style.visibility = "hidden";  
            document.getElementById('email2').style.borderColor = 'grey';
            validation++;
        }
    } else {
        document.getElementById('email').style.borderColor = 'red';            
        document.getElementById('emailError').style.visibility = "visible";
        document.getElementById('emailError').innerHTML = "Please enter your email.";
    }

    if (password.length > 0) {
        if (password.length < 8) {
            document.getElementById('password').style.borderColor = 'red';         
            document.getElementById('passwordError').style.visibility = "visible";
            document.getElementById('passwordError').innerHTML = "You password is too short.";
        } else {
            document.getElementById('passwordError').style.visibility = "hidden";   
            document.getElementById('password').style.borderColor = 'grey';
            validation++;
        }

        if (password !== password2) {
            document.getElementById('password2').style.borderColor = 'red';         
            document.getElementById('passwordError2').style.visibility = "visible";
            document.getElementById('passwordError2').innerHTML = "You password does not match.";
        } else {
            document.getElementById('passwordError2').style.visibility = "hidden";           
            document.getElementById('password2').style.borderColor = 'grey';
            validation++;
        }

        // Empty field check
    } else {
        document.getElementById('password').style.borderColor = 'red';             
        document.getElementById('passwordError').style.visibility = "visible";
        document.getElementById('passwordError').innerHTML = "Please enter a password.";
    }

    if (validation === 7) {
        return (true);
    } else {
        return (false);
    }
}

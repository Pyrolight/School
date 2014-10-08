<div>
    <form id="registrationForm" action="index.php" method ="POST" onsubmit="return validateRegister(this);">
        <label>First Name: </label><input type="text" id="firstName" name="firstName" /><div id="firstNameError"></div>
        <label>Last Name: </label><input type="text"  id="lastName" name="lastName" /><div id="lastNameError"></div>
        <label>Username: </label><input type="text" id="username" name="username" /><div id="usernameError"></div>
        <label>Email: </label><input type="text" id = "email" name="email" /><div id="emailError"></div>
        <label>Confirm Email: </label><input type="text" id="email2" name="email2" /><div id="emailError2"></div>
        <label>Password: </label><input type="password" id="password" name="password" /><div id="passwordError"></div>
        <label>Confirm Password: </label><input type="password" id="password2" name="password2" /><div id="passwordError2"></div>
        <input type="submit" name="submit" value ="submit" />
    </form>
</div>






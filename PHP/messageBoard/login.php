<div>
    <form id="loginForm" action="index.php" method ="POST" onsubmit="return validateLogin(this);">        
        <label>Username: </label><input type="text" id="username" name="username" /><div id="usernameError"></div>     
        <label>Password: </label><input type="password" id="password" name="password" /><div id="passwordError"></div>
        <input type="submit" name="submit" value ="submit" />
    </form>
</div>
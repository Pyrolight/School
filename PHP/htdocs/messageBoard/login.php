<?php
/* Author: Michael Fesser
  Date: 10/14/2014
  Purpose: This is the login page, it is in a modal style.
  Last Revision: 10/14/2014
  Dependencies: index.php, register.php
 */

// Run the login script.
if (isset($_POST['sendLogin'])) {
    include ('databaseFunctions.php');
    login();
    header('location:index.php');
    exit();
}
?>
<!-- Kevin Liew @ http://www.queness.com for the boxes and dialogue div.-->
<div id="boxes">
    <div id="dialog" class="window">
        <div class="row">
            <div class="form-group col-lg-4">
                <form id="loginForm" action="login.php" method ="POST" onsubmit="return validateLogin(this);">   
                    <?php
                    // Show successful account creation.
                    if (isset($_SESSION['accountCreated'])) {
                        if ($_SESSION['accountCreated'] == true) {
                            ?>
                            <div class="index-error-fix" style="color:green; font-size:18px;">Account created Successfully</div>
                            <?php
                        }
                    } else {
                        ?>
                        <div class="index-error-fix">&nbsp;</div>
                        <?php
                    }
                    ?>    
                    <p style="font-size:14px; font-weight: bold">LOGIN</p>
                    <label>Username: </label><input type="text" id="usernameLogin" class="modal-input" name="username"/>
                    <div id="usernameErrorLogin" class="index-error-fix input-error">&nbsp;</div>     
                    <label>Password: </label><input type="password" id="passwordLogin" class="modal-input" name="password" />
                    <?php
                    // Show failed login.
                    if (isset($_SESSION['loginFailed'])) {
                        ?>
                        <div id="passwordErrorLogin" class="index-error-fix input-error">Log in unsuccessful!</div><br/>                      
                        <?php
                        unset($_SESSION['loginFailed']);
                    } else {
                        ?>
                        <div id="passwordErrorLogin" class="index-error-fix input-error">&nbsp;</div><br/>
                        <?php
                    }
                    ?>
                    <input type="hidden" name="sendLogin"/>
                    <div style="width:300px; text-align: left;">
                        <input type="submit" name="submitLogin" value ="Submit" class="btn btn-default"/>
                        <input type="button" value="Cancel" class="btn btn-default cancel"/> 
                    </div>
                </form>
            </div>
        </div>
    </div>
    <!-- Kevin Liew @ http://www.queness.com Used to hide the main page -->
    <div id="mask"></div>
</div>



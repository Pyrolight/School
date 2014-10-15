<!-- Author: Michael Fesser
  Date: 10/14/2014
  Purpose: Menu bar.
  Last Revision: 10/14/2014
  Dependencies: index.php, register.php
 -->

<div id="menuBarLeft">
    <a href='index.php'>Home</a>
</div>

<div id="menuBarRight">
    <?php
    // Show when the user is logged in.
    if (isset($_SESSION["userId"])) {
        ?>
        <?php
        echo "Welcome " . $_SESSION["username"] . " you are logged in.&nbsp;&nbsp;";
        ?>
        <a href='index.php?action=logout'>Logout</a>
        <?php
        // Show if the user is logged out.
    } else if (!isset($_SESSION["userId"])) {
        ?>
         <a href="#dialog" name="modal">Login</a>
         or
         <a href='register.php?action=register'>Register</a>
        <?php
    }
    ?>
</div>

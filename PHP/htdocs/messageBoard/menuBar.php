<div id="menuBarLeft">
    <a href='index.php'>Home</a>
</div>

<div id="menuBarRight">
    <?php
    if (isset($_SESSION["userId"])) {
        ?>
        <?php
        echo "Welcome " . $_SESSION["username"] . " you are logged in.&nbsp;&nbsp;";
        ?>
        <a href='index.php?action=logout'>Logout</a>
        <?php
    } else if (!isset($_SESSION["userId"])) {
        ?>
         <a href="#dialog" name="modal">Login</a>
         or
         <a href='register.php?action=register'>Register</a>
        <?php
    }
    ?>
</div>

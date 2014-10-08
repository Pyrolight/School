<div id="menuBar">
    <?php
    if (isset($_SESSION["login"])) {
        ?>
        <a href='index.php?action=logout'>Logout</a>
        <?php
    } else if (!isset($_SESSION["login"])) {
        ?>
         <a href='index.php?action=login'>Login</a>
         or
         <a href='register.php?action=register'>Register</a>
        <?php
    }
    ?>
</div>

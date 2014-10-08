<div id="menuBar">
    <?php
    if (isset($_SESSION['login'])) {
        echo "<form action='index.php' method='POST'> \n";
        echo "<input type='hidden' name='logout' /> \n";
        echo "<input type='submit' value='logout' /> \n";
        echo "</form> \n";
    } else if (!isset($_SESSION['login'])) {
        echo "<form action='login.php' method='POST'> \n";
        echo "<input type='hidden' name='login' /> \n";
        echo "<input type='submit' value='login' /> \n";
        echo "</form> \n";
        echo "<form action='register.php' method='POST'> \n";
        echo "<input type='hidden' name='register' /> \n";
        echo "<input type='submit' value='register' /> \n";
        echo "</form> \n";
    }
    ?>
</div>

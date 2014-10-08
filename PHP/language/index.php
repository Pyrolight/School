

<?php
if (isset($_POST['logout'])) {
    setcookie('language', $_POST['language'], time() - 60 * 60 * 24 * 31);
    header('Location: index.php');
}
if (isset($_POST['language'])) {
    setcookie('language', $_POST['language'], time() + 60 * 60 * 24 * 31);
}
if (!isset($_POST['language'])) {
    if (!isset($_COOKIE['language'])) {
        ?>
        <!DOCTYPE html>
        <html>
            <head>
                <meta charset = "UTF-8">
                <title></title>
            </head>
            <body> <h1>Choose your language!</h1>
                <form action = "index.php" method = "POST">
                    <select id = "language" name = "language">
                        <option value = "0">English</option>
                        <option value = "1">French</option>
                        <option value = "2">Pirate</option>
                    </select>
                    <input type = "submit" id = "submit"/>
                </form>
            </body>
        </html>
        <?php
    }
}
?>
<?php
if (isset($_COOKIE['language'])) {
    $language = $_COOKIE['language'];
    if ($language == 0) {
        echo "Jolly good day chap.";
    } else if ($language == 1) {
        echo "insert French here.";
    } else if ($language == 2) {
        echo "Arrggg Matey, be a fine day.";
    }
    ?>

    <!DOCTYPE html>
    <html>
        <head>
            <meta charset = "UTF-8">
            <title></title>
        </head>
        <form action = "index.php" method = "POST">
            <input type="hidden" name="logout"/>
            <input type = "submit" id = "logout" value="logout"/>
        </form>
    </body>
    </html>
    <?php
}
?>



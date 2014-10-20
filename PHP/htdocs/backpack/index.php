<?php
session_start();
if (!isset($_SESSION['started'])) {
    $_SESSION['backpack'] = array();
    $_SESSION['started'] = true;
}

$headlamp = array("Headlamp", 0.5);
$goggles = array("Goggles", 0.2);
$sleepingBag = array("Sleeping Bag", 3);
$rations = array("Rations", 6);
$medkit = array("Medkit", 2);
$backpackWeight = 0;

if (isset($_GET['action'])) {
    if ($_GET['action'] == "removeAll") {
        $_SESSION['backpack'] = array();
    } else if ($_GET['action'] == "remove") {
        foreach ($_SESSION['backpack'] as $key => $value) {
            if ($_GET['id'] == $key) {
                unset($_SESSION['backpack'][$key]);
            }
        }
    }
}


if (isset($_POST['item'])) {

    $items = $_POST['item'];
    for ($i = 0; $i < sizeof($items); $i++) {
        switch ($items[$i]) {
            case "headlamp":
                array_push($_SESSION['backpack'], $headlamp);
                break;
            case "goggles":
                array_push($_SESSION['backpack'], $goggles);
                break;
            case "sleepingBag":
                array_push($_SESSION['backpack'], $sleepingBag);
                break;
            case "rations":
                array_push($_SESSION['backpack'], $rations);
                break;
            case "medkit":
                array_push($_SESSION['backpack'], $medkit);
                break;
        }
    }
}
?>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <div>
            <h3>Backpack</h3>
            <p>Your backpack contains:</p>
            <ul>
                <?php
                if (isset($_SESSION['backpack'])) {
                    if (!empty($_SESSION['backpack'])) {

                        foreach ($_SESSION['backpack'] as $key => $value) {
                            ?><li><?php
                                echo ($value[0]);
                                ?>
                                <a href="index.php?action=remove&id=<?php echo $key ?>">Remove</a>
                            </li>
                            <?php
                            $backpackWeight += $value[1];
                        }
                    }
                }
                ?>
            </ul>
            <p>The total weight of your back is: <?php echo $backpackWeight ?> pounds</p>
            <?php
            if (isset($_SESSION['backpack'])) {
                if (!empty($_SESSION['backpack'])) {
                    ?>

                    <a href="index.php?action=removeAll">Remove all items</a>
                    <?php
                }
            }
            ?>
        </div>
        <form name="backpack" action="index.php" method="POST">
            <p>Select items</p>
            <input type="checkbox" name="item[]" value="headlamp">Headlamp, 0.2 pounds<br/>
            <input type="checkbox" name="item[]" value="goggles">Goggles, 0.3 pounds<br/>
            <input type="checkbox" name="item[]" value="sleepingBag">Sleeping Bag, 3 pounds<br>
            <input type="checkbox" name="item[]" value="rations">Rations, 6 pounds<br/>
            <input type="checkbox" name="item[]" value="medkit">Medkit, 2 pounds<br/>
            <input type="submit" name="submit" value="submit"/>
        </form>
    </body>
</html>

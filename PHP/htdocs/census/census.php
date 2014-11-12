<?php

// connect to the server
$mysqli = new mysqli('localhost', 'root', '', 'db2288');

// display an error if connection fails and allow the user to return to the main page.
if ($mysqli->connect_errno) {
    echo "There was an issue connecting to the database Error is " . $mysqli->connect_errno . "</br>";
    echo "<a href='census-search.html'>Go back to home page</a></div></body></html>";
    exit();
}


if (isset($_GET['query'])) {
    $stmt = $mysqli->prepare("SELECT `name` , `population` FROM population WHERE `name` LIKE ?");
    $stmt->bind_param('s', $search);
    $search = $_GET['query'] . "%";
    // Execute query.
    $stmt->execute();
    // Used for counting the number of rows.
    $stmt->store_result();
    // Count rows.
    $rowCount = $stmt->num_rows;
    // Secure the result set.
    $stmt->bind_result($name, $population);

    if ($rowCount > 0) {
        while ($stmt->fetch()) {
            echo $name . " " . $population . "<br />";
        }
        // Close statement.
        $stmt->close();
        // Close connection.
        $mysqli->close();   
    }
} else {
    if (isset($_POST['XMLFeedSubmit'])) {
        $order = $_POST['order'];
        $stmt = $mysqli->prepare("SELECT `name` , `population` FROM population WHERE `name` LIKE ? ORDER BY `name` " . $order . " LIMIT ?");
        $stmt->bind_param('si', $search, $numResults);

        $search = $_POST['search'] . "%";
        if ($_POST['numResults'] > 0) {
            $numResults = $_POST['numResults'];
        } else {
            $numResults = 1000000000;
        }
    } else {
        $order = "ASC";
        $stmt = $mysqli->prepare("SELECT `name` , `population` FROM population WHERE `name` LIKE ? ORDER BY `name` " . $order . " LIMIT ?");
        $stmt->bind_param('si', $search, $numResults);
        $search = "%";
        $numResults = 1000000000;
    }

    // Execute query.
    $stmt->execute();
    // Used for counting the number of rows.
    $stmt->store_result();
    // Count rows.
    $rowCount = $stmt->num_rows;
    // Secure the result set.
    $stmt->bind_result($name, $population);

    if ($rowCount > 0) {
        // DreamWerx from www.stackOverflow for this initial element
        $censusXML = new SimpleXMLElement("<?xml version='1.0' encoding='UTF-8'?><census></census>");
        // Get the result array and loop.
        while ($stmt->fetch()) {
            $location = $censusXML->addChild('location');
            $location->addChild('name', utf8_encode($name));
            $location->addChild('population', $population);
        }
        // Close statement.
        $stmt->close();
        // Close connection.
        $mysqli->close();
    }

    header('Content-type:text/xml;charset=utf8');
    echo $censusXML->asXML();
}
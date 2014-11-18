<?php

/*   Author: Michael Fesser
 *   Date: Nov 11, 2014
 *   Purpose: This files accesses the database to retrieve the data and display the XML to the user.  If the user goes to this page
 *   directly the results will be the entire database.
 *   Last Revision: Nov 14, 2014
 *   Dependencies: None.
 */

// connect to the server
$mysqli = new mysqli('localhost', 'root', '', 'db2288');
// Sets both the input to the database and output from the database to utf8.  This allows for French characters to be used in the search.
// Rohit Kumar Choudhary from www.stackoverflow.com
$mysqli->set_charset("utf8");

// display an error if connection fails and allow the user to return to the main page.
if ($mysqli->connect_errno) {
    echo "There was an issue connecting to the database Error is " . $mysqli->connect_errno . "</br>";
    echo "<a href='census-search.html'>Go back to home page</a></div></body></html>";
    exit();
}

// This is the AJAX query.  It returns the cities that start with the character(s) the user entered in the search box.
if (isset($_GET['query'])) {
    $stmt = $mysqli->prepare("SELECT `name` , `population` FROM population WHERE `name` LIKE ?");
    // Bind parameters.
    $stmt->bind_param('s', $search);
    $search = utf8_encode($_GET['query']) . "%";
    // Execute query.
    $stmt->execute();
    // Used for counting the number of rows.
    $stmt->store_result();
    // Count rows.
    $rowCount = $stmt->num_rows;
    // Secure the result set.
    $stmt->bind_result($name, $population);

    // Displays the city and its population.
    if ($rowCount > 0) {
        while ($stmt->fetch()) {
            echo $name . " " . $population . "<br />";
        }
    }
    // Close statement.
    $stmt->close();
    // Close connection.
    $mysqli->close();
} else {
    // This is used when the user clicks the submit button.
    if (isset($_POST['XMLFeedSubmit'])) {
        // Prepared statements do not work with ascending and descending so it cannot be bound to the statement.  
        $order = $_POST['order'];
        $stmt = $mysqli->prepare("SELECT `name` , `population` FROM population WHERE `name` LIKE ? ORDER BY `name` " . $order . " LIMIT ?");
        // Bind parameters.
        $stmt->bind_param('si', $search, $numResults);
        $search = $_POST['search'] . "%";
        // Use the user imputed value for the limit if they entered one, else use the default.
        if ($_POST['numResults'] > 0) {
            $numResults = $_POST['numResults'];
        } else {
            $numResults = 1000000000;
        }
    } else {
        // Prepared statements do not work with ascending and descending so it cannot be bound to the statement.  Default option.
        $order = "ASC";
        $stmt = $mysqli->prepare("SELECT `name` , `population` FROM population WHERE `name` LIKE ? ORDER BY `name` " . $order . " LIMIT ?");
        // Bind parameters.
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
            // Add a child to census.
            $location = $censusXML->addChild('location');
            // Add a child to the location.
            $location->addChild('name', $name);
            // Add a child to the location.
            $location->addChild('population', $population);
        }
    }
    // Close statement.
    $stmt->close();
    // Close connection.
    $mysqli->close();

    // Set the page to display the XML content.
    header('Content-type:text/xml;charset=utf8');
    // Display the XML content.
    echo $censusXML->asXML();
}
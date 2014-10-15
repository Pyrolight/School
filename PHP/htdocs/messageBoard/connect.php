<?php

/* Author: Michael Fesser
 * Date: April 24, 2014
 * Purpose: This is the default connection to the database.  Used as a require to save code
 * replication.
 * Last Revision: April 24, 2014
 * Dependencies: 
 */

// connect to the server
$mysqli = new mysqli('localhost', 'mfesser', 'mfesser1234', 'message_board');

// display an error if connection fails and allow the user to return to the main page.
if ($mysqli->connect_errno) {
    echo "There was an issue connecting to the database Error is " . $mysqli->connect_errno ."</br>";
    echo "<a href='index.php'>Go back to home page</a></div></body></html>";
    exit();
}

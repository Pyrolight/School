<?php

/* Author: Michael Fesser
 * Date: April 24, 2014
 * Purpose: This is the default connection to the database.  Used as a require to save code
 * replication.
 * Last Revision: April 24, 2014
 * Dependencies: 
 */

// connect to the server
$con = new mysqli('localhost', 'mfesser', 'Mfesser1234', 'message_board');

// display an error if conneciton fails and allow the user to return to the main page.
if ($con->connect_errno) {
    echo "There was an issue connecting to the database Error is " . $con->connect_errno ."</br>";
    echo "Please click the link below to return to the previous page. <br />";
    echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a></div></body></html>";
    exit();
}
?>
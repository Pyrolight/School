<?php
/*   Author: Michael Fesser
 *   Date: April 3, 2014
 *   Purpose: This is the page the processes the input fields in the addBook.php file.
 *   It also is used to validate and display the book object.
 *   Last Revision: April 4, 2014
 *   Dependencies: addBook.php
 */

// Include for the book object.
include 'book.class.php';

// Used for the books properties.
$title;
$author;
$isbn;
$pageCount;
$coverType;
$userRating;
// Used to compare the userRatings
$userRatingArray = Array("terrible", "poor", "average", "good", "excelent");
$coverTypeArray = Array("hard", "soft");
?>

<!DOCTYPE html>

<!-- Author: Michael Fesser
     Date: 
     Purpose:  
     Last Revision: 
     Dependencies: 
-->

<html>
    <head>
        <meta charset="UTF-8">
        <title>Process</title>
        <link href="template.css" rel="stylesheet">
    </head>
    <body>
        <div id="box2">
            <div id="vetricalAlign">
                <?php
                /* check to see if the email field is empty. Repeated below. */
                if (empty($_POST['title'])) {
                    // Taken from Amber on Stack Overflow.  Returns the user to the previous page.
                    echo "You left the field for the title of the book empty.  Please click the link below to return to the previous page. <br />";
                    echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a></div></div></body></html>";
                    // End script.
                    exit();
                } else {
                    // Trim off any leading or trailing white space.
                    $title = trim($_POST['title']);
                }
                if (empty($_POST['author'])) {
                    echo "You left the field for the author empty.   Please click the link below to return to the previous page. <br />";
                    echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a></div></div></body></html>";
                    // End script.
                    exit();
                } else {
                    $author = trim($_POST['author']);
                }
                if (empty($_POST['isbn'])) {
                    echo "You left the field for the ISBN empty.  Please click the link below to return to the previous page. <br />";
                    echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a></div></div></body></html>";
                    exit();
                }
                if (empty($_POST['pageCount'])) {
                    echo "You left the field for the page count empty.  Please click the link below to return to the previous page. <br />";
                    echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a></div></div></body></html>";
                    // End script.
                    exit();
                }
                if (empty($_POST['coverType'])) {
                    echo "You left the field for the type of cover of the book empty.  Please click the link below to return to the previous page. <br />";
                    echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a></div></div></body></html>";
                    // End script.
                    exit();
                }
                if (empty($_POST['userRating'])) {
                    echo "You left the field for the userRating empty.  Please click the link below to return to the previous page. <br />";
                    echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a></div></div></body></html>";
                    // End script.
                    exit();
                } else {
                    $userRating = trim($_POST['userRating']);
                }
                // Check to see if the field is numeric.
                if (!is_numeric($_POST['pageCount'])) {
                    echo "The page count must be a number.  Please click the link below to return to the previous page. <br />";
                    echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a></div></div></body></html>";
                    exit();
                } else {
                    $pageCount = trim($_POST['pageCount']);
                }
                // Check to see if the field is numeric.
                if (is_numeric($_POST['isbn'])) {
                    // Check to see if the isbn is the correct length.
                    if (strlen($_POST['isbn']) < 10 || strlen($_POST['isbn']) > 13) {
                        echo "The ISBN needs to be 10 to 13 digits long.  Please click the link below to return to the previous page. <br />";
                        echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a></div></div></body></html>";
                        // End script.
                        exit();
                    } else {
                        $isbn = ($_POST['isbn']);
                    }
                } else {
                    echo "The ISBN needs to be digits only.  Please click the link below to return to the previous page. <br />";
                    echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a></div></div></body></html>";
                    // End script.
                    exit();
                }
                // Check the cover type to see if it matches.
                if (!in_array(strtolower($_POST['coverType']), $coverTypeArray)) {
                    echo "The cover types can be only soft or hard.  Please click the link below to return to the previous page. <br />";
                    echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a></div></div></body></html>";
                    // End script.
                    exit();
                } else {
                    $coverType = ($_POST['coverType']);
                }
                // Compare the user rating to the required input.
                if (!in_array(strtolower($_POST['userRating']), $userRatingArray)) {
                    echo "The user rating needs to follow the stated guidelines.  Please click the link below to return to the previous page. <br />";
                    echo "<a href=\"javascript:history.go(-1)\">Go back to previous page</a></div></div></body></html>";
                    // End script.
                    exit();
                } else {
                    $userRating = ($_POST['userRating']);
                }
                ?>
            </div>
            <div class = "displayBook">
                <?php
                // Create the book object.
                $book = new Book();
                // Set the details of a book.  The order must match the order of the functions input parameters.
                $book->setBook($title, $author, $isbn, $pageCount, $coverType, $userRating);
                // Display the book.
                $book->printDetails();
                ?>
            </div>
        </div>
    </body>
</html>

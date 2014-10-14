<?php

/**
 * @author Michael Fesser
 * @since 5/4/2014
 * 
 * This class is used to create a book object.
 */
class Book {

    // These fields are used to hold the book objects properties.  They are set to private for data hiding.
    private $title;
    private $author;
    private $isbn;
    private $pageCount;
    private $coverType;
    private $userRating;

    /**
     * This is the default constructor that simply outputs a default message.  It 
     * is called when the object is created.
     */
    public function __construct() {
        echo "<p id=\"bookCreated\">Book Created </span></p>\n";
    }

    /**
     * This function takes the values of the populated variables from the process.php page 
     * and sets the the matching fields in this class.  The order the variables are passed
     * to this setter from the process.php class much match the order the variables appear
     * in this functions input parameters otherwise an error will be generated.
     * 
     * @param type $title
     * @param type $author
     * @param type $isbn
     * @param type $pageCount
     * @param type $coverType
     * @param type $userRating
     */
    public function setBook($title, $author, $isbn, $pageCount, $coverType, $userRating) {
        // These set the local fields to the values passed in.
        $this->title = $title;
        $this->author = $author;
        $this->isbn = $isbn;
        $this->pageCount = $pageCount;
        $this->coverType = $coverType;
        $this->userRating = $userRating;
    }

    /**
     * This "magic" getter is used only if a value needs to be returned to process.php.  
     * It only accepts a variable name that matches a local field and then the
     * value is returned.  
     * 
     * ie $title can be passed in and $title is returned.  If $bob is passed in 
     * an error will occur. 
     *   
     * @param type $variable
     * @return type 
     */
    public function __get($variable) {
        return $this->$variable;
    }

    /**
     * This function is used to generate the book output in the form of a table.
     * It uses the values of the local fields as the output for the the second column in 
     * the table.  Standard echo statements are used to generate the table.
     */
    public function printDetails() {
        echo "<table>\n";
        echo "<tr>";
        echo "<td>Title:</td><td>" . $this->title . "<td>";
        echo "</tr>\n";
        echo "<tr>";
        echo "<td>Author:</td><td>" . $this->author . "<td>";
        echo "</tr>\n";
        echo "<tr>";
        echo "<td>ISBN:</td><td>" . $this->isbn . "<td>";
        echo "</tr>\n";
        echo "<tr>";
        echo "<td>Page Count:</td><td>" . $this->pageCount . "<td>";
        echo "</tr>\n";
        echo "<tr>";
        echo "<td>Cover Type:</td><td>" . $this->coverType . "<td>";
        echo "</tr>\n";
        echo "<tr>";
        echo "<td>User Rating:</td><td>" . $this->userRating . "<td>";
        echo "</tr>\n";
        echo "</table>\n    ";
    }
}
?>

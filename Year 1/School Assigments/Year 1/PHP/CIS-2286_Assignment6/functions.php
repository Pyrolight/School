<!-- Author: Michael Fesser
     Date: Mar 14, 2014
     Purpose: This file holds all the functions that creates and manipulates the
     html for the resume.php page.  It also allows for a basic search and shows
     the last two page access times.
     Last Revision: Mar 16, 2014
     Dependencies: resume.php
-->

<?php

/**
 * This function calls the header.php page.
 */
function header_top() {
    include 'header.php';
}

/**
 * This function calls the footer.php page.
 */
function footer() {
    include 'footer.php';
}

/**
 * This function displays and styles paragraphs.
 * 
 * @param type $value
 * @param type $style
 */
function para($value, $style = "") {
    echo "<p style = '$style'>$value</p>\n";
}

/**
 * This function displays and styles the headings.
 * 
 * @param type $value
 * @param type $style
 */
function heading1($value, $style = "") {
    echo "&nbsp;<h1 style = '$style'>$value</h1>\n";
}

/**
 * This function displays and styles data as an unordered list.
 * 
 * @param type $value
 * @param type $style
 */
function ulist($value, $style = "") {
    echo "<ul style = '$style'>\n";
    foreach ($value as $list) {
        echo "<li>$list</li>\n";
    }
    echo "</ul>\n";
}

/**
 * This function displays the copyright for the webpage.
 */
function stamp() {
    $copyright = "<p style = 'text-align: center'>Michael Fesser &copy " . date('Y') . "</p>\n";
    return $copyright;
}

/**
 * This is the first custom function.  It is used to display and format data in a 
 * table format.  
 * 
 * @param type $value
 */
function table($value) {
    echo "<table>\n";
    foreach ($value as $listing) {
        echo "<tr><td>" . $listing . "</td></tr>\n";
    }
    echo "</table>\n";
}

/**
 * This function creates an array of all skills.
 * 
 * @param type $skillsArray
 * @param type $otherTechSkillsArray
 * @return type $allSkillsArray;
 */
function getSkillsArray($skillsArray, $otherTechSkillsArray) {
    $allSkillsArray = array_merge($skillsArray, $otherTechSkillsArray);
    return $allSkillsArray;
}

/**
 * This is the second custom function.  It is a basic search function that checks
 * the two skills arrays and tells the user if the skill is listed on the resume.
 * 
 * @param type $skillArray
 * @param type $otherTechSkillsArray
 */
function skillsSearch($allSkillsArray) {
    // Taken from ariefbayu on www.http://stackoverflow.com.  I HATE the syntax of PHP at times.
    $allSkillsArray = array_map('strtolower', $allSkillsArray);
    // '#search' taken from Musa on www.http://stackoverflow.com.  Used as a anchor call.
    echo "<form action='#search' method='post'> \n";
    echo "Search a skill: <input type='search' name='search' id='search'/><input type ='submit' name='submit'/> \n";
    echo "</form> \n";
    // Check to see if anything has been submitted.
    if (isset($_POST['submit'])) {
        // Check to see if the search is empty.
        if (!empty($_POST['search'])) {
            $search = strtolower($_POST['search']);
            // Boolean used to determine if skill exists.
            $haveSkill = false;

            // Compare a string to the array.  More agravating PHP syntax.
            if (in_array($search, $allSkillsArray)) {
                $haveSkill = true;
            }

            if ($haveSkill) {
                echo "<p style='font-weight: bold;'>Yes, I have that skill.</p> \n";
            } else {
                echo "<p style='font-weight: bold;'>No, I don't have that skill.</p> \n";
            }

            // Write to a file to save the searches.
            $fp = fopen("skills.txt", 'a+');
            flock($fp, LOCK_EX);
            fwrite($fp, $search . ",");
            flock($fp, LOCK_UN);
            fclose($fp);
        }
    }
}

/**
 * This is another function intended to extend the skills search to display all the
 * searches.  This could have been part of the Ultra challenge of greatness but it 
 * essentially would do the exact same thing as far as passing by reference as the next function.
 * 
 */
function getSkills() {
    // Same as above as far as sourcing.
    echo "<form action='#submit' method='post'> ";
    echo "<br />Show the search terms, this could be massive! <input type ='submit' name='submit' id='submit' value='Show me'/> ";
    echo "</form> ";
    // Check to see if user clicked "show me".
    if (isset($_POST['submit'])) {
        // Open the file and spit out the string.
        $fp = fopen("skills.txt", 'r');
        $skills = fgets($fp);
        // Convert the string to an array.  
        $skillsArray = explode(",", $skills);
        fclose($fp);
        // Count the various occurances of each search term.  Forgot the syntax so from www.http://stackoverflow.com.
        $skillsResults = array_count_values($skillsArray);
        if (!empty($skillsResults)) {
            foreach ($skillsResults as $key => $value) {
                echo $key . " was searched " . $value . " times. <br /> ";
            }
        }
    }
}

/**
 * This is the first part of the Ultra challenge of greatness.  It is used to store
 * the last time the page was accessed in a file.  
 * 
 * @return type $date;
 */
function getTheDate() {
    $fp = fopen("time.txt", 'r');
    $date = fgets($fp);
    fclose($fp);
    // set default date in the resume.php file.
    return $date;
}

/**
 * This is the main Ultra challenge of greatness function.  Is this really that useful?
 * I really have no idea, but it does do what it is intended to do and I don't see
 * a really useful function with the limited scope of the project.
 * 
 * This function essentially takes the passed in by reference variable $date and appends
 * on the current time the page was accessed then that variable is echoed in the 
 * main page.
 * 
 * @param string $date
 * @param type $dateCSS
 */
function lastViewedAt(&$date, $dateCSS) {
    date_default_timezone_set('America/Halifax');
    $date .= "<p style = '$dateCSS'>You accessed this page at " . date("g:i:sA e") . " on " . date("F d, Y") . "</p>\n";

    // Used to overwrite the existing file with the current date to be used as the previous date the next time the program is run/reloaded.
    $fp = fopen("time.txt", 'w');
    flock($fp, LOCK_EX);
    $oldDate = "<p style = '$dateCSS'>This page was previously accessed at " . date("g:i:sA e") . " on " . date("F d, Y") . "</p>";
    fwrite($fp, $oldDate);
    flock($fp, LOCK_UN);
    fclose($fp);
}

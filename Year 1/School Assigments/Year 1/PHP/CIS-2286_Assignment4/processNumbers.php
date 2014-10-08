<!-- Author: Michael Fesser
     Date: Feb 12, 2014
     Purpose: A small PHP program to create an array from a text file.  The program 
              will then find all the valid numbers of the array within a specific 
              range, the number of elements in the new filtered array, 
              also the max, min, and average of the array.  Borrowed Don Bowers 
              formatting, can't possibly be wrong now :P
     Last Revision: Feb 12, 2014
     Dependencies: none
-->
<?php
$scores = file('../../scores.txt');                                             // Get the values form the scores.txt file two directories back up the tree.
for ($i = 0; $i < sizeof($scores); $i++) {                                      
    if ($scores[$i] >= 0 && $scores[$i] <= 100) {   
    $scoresFiltered[$i] = floatval($scores[$i]);                                // Populate the new array with only values from 0 to 100 inclusive and as floats.
    }
}
echo"Valid number count: " . count($scoresFiltered) . "<br />";                 // Count the array.  array_count does not like floats.  
echo"Maximum number: " . max($scoresFiltered) . "<br />";                       // Find the maximum value of the array.
echo"Minimum number: " . min($scoresFiltered) . "<br />";                       // Find the minimum value of the array.
$arrayAverage = array_sum($scoresFiltered)/count($scoresFiltered);              // Calculate the average of the array.
echo"Average: ". number_format($arrayAverage,2);                                // Display average to two decimal places.
?>

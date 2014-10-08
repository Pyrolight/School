<!DOCTYPE html>

<!-- Author: Michael Fesser
     Date: Feb 2, 2014
     Purpose: This page is used to view the order places since the last time they
              were deleted.  The format that is output is still pretty raw, but readable.
     Last Revision: Feb 3, 2014
     Dependencies: orders.txt, processVeggies.php
-->

<?php
date_default_timezone_set('Canada/Atlantic');
$DOCUMENT_ROOT = $_SERVER['DOCUMENT_ROOT'];                                     // Get the root of the server the file is run on.
?>

<html>
    <head>
        <meta charset="UTF-8">
        <title>Order Vegetables</title>    
        <link href="orderVegetables.css" rel="stylesheet">
    </head>
    <body>
	
        <div id ="titleImage"><span id = "title">Mike's Vegetable Market</span></div>  <!-- Title banner with background. -->    
        <table>
            <tr>
                <td class="formatMenu tableElements">
                    <?php include("menuBar.php"); ?>  <!--http://www.boutell.com/newfaq/creating/include.html--> 
                </td>
                <td class="tableElements">                
                    <fieldset>
                        <div class=formattingOrders>
                            <?php
                            if (file_exists("$DOCUMENT_ROOT/../OrderForms/orders.txt")) {  // Check to see if file exists.
                                $fp = fopen("$DOCUMENT_ROOT/../OrderForms/orders.txt", "r");  // Open file.
                                flock($fp, LOCK_EX);                            // Lock the file so that no one else can write to it. 
                                while (!feof($fp)) {                            // While not at the end of the file read each line.
                                    $line = fgets($fp, 999);                    
                                    echo $line . "<br />";                      // Display the lines.
                                    
                                }
                                flock($fp, LOCK_UN);                            // Unlock the file.
                                fclose($fp);                                    // Close file.  Is this actually necessary?
                            } else {                                            // If no file exists tell the user.
                                echo "No such file exists!";
                            }
                            echo "<div class = clockFormat>The file was last accessed at " . date("g:iA e") . " on " . date("F d, Y") . "<br /><br /></div>"; // Date.
                            echo "<div class = clockFormat><a href=resetOrders.php><span id = deleteLink>Click here to reset orders</span></div></a>"
                            ?> 
                        </div>                     
                    </fieldset>   
                </td>
            </tr>
    </body>
</html>









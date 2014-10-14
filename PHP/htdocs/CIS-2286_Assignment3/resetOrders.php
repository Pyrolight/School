<!DOCTYPE html>

<!-- Author: Michael Fesser
     Date: Feb 2, 2014
     Purpose: 
     Last Revision: Feb 3, 2014
     Dependencies: orders.txt, veiwOrders.php
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
                        <div class="formattingReset">                                  
                            <?php
                            $fp = fopen("$DOCUMENT_ROOT/../OrderForms/orders.txt", 'w');  // Open and clear the file.
                            fclose($fp);                                        // Close file.  Locking and unlocking it seemed redundant.
                            echo "<div class=formattingReset><div class = clockFormat>This order file was deleted at " . date("g:iA e") . " on " . date("F d, Y") . "</div></div>";
                            ?>
                        </div>
                    </fieldset>   
                </td>
            </tr>
    </body>
</html>

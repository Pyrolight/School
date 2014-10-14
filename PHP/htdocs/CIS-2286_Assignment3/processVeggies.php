<!DOCTYPE html>

<!-- Author: Michael Fesser
     Date: Jan 31, 2014
     Purpose: This page accepts all the user input, does all the calculations and 
              displays the order to the user.  It also writes the order to a file.
     Last Revision: Feb 3, 2014
     Dependencies: orderVegetables.php
-->

<?php
date_default_timezone_set('Canada/Atlantic');                                   // Set time zone. 
$date = date("g:iA e F d, Y");
$DOCUMENT_ROOT = $_SERVER['DOCUMENT_ROOT'];                                     // Get the root of the server the file is run on.
define('POTATOES_COST', 5.00);                                                  // Constants since the values don't change.
define('CARROTS_COST', 2.75);
define('BRUSSELS_SPROUTS_COST', 3.00);
define('CAULIFLOWER_COST', 3.75);
define('DELIVERY_FEE_WAIVED', 50.00);
define('DELIVERY_FEE', 5.00);
define('TAX_RATE', .15);
$potatoes;
$carrots;
$brusselsSprouts;
$cauliflower;

/* These conditions make sure that there are no null values when the order is processed */
if (empty($_POST['potatoes'])) {
    $potatoes = 0;
} else {
    $potatoes = $_POST['potatoes'];
}

if (empty($_POST['carrots'])) {
    $carrots = 0;
} else {
    $carrots = $_POST['carrots'];
}

if (empty($_POST['brusselsSprouts'])) {
    $brusselsSprouts = 0;
} else {
    $brusselsSprouts = $_POST['brusselsSprouts'];
}

if (empty($_POST['cauliflower'])) {
    $cauliflower = 0;
} else {
    $cauliflower = $_POST['cauliflower'];
}


$potatoesTotal = $potatoes * POTATOES_COST;
$carrotsTotal = $carrots * CARROTS_COST;
$brusselsSproutsTotal = $brusselsSprouts * BRUSSELS_SPROUTS_COST;
$cauliflowerTotal = $cauliflower * CAULIFLOWER_COST;
$orderWithTax;
$currentTotal = $potatoes * POTATOES_COST + $carrots * CARROTS_COST + $brusselsSprouts * BRUSSELS_SPROUTS_COST + $cauliflower * CAULIFLOWER_COST;
$orderTax = $currentTotal * TAX_RATE;
$deliveryCost;

/* Check if there will be a delivery fee */
if ($currentTotal > DELIVERY_FEE_WAIVED) {
    $deliveryCost = 0.00;
    $finalTotal = $currentTotal + $orderTax;
} else {
    $deliveryCost = DELIVERY_FEE;
    $finalTotal = $currentTotal + $orderTax + DELIVERY_FEE;
}
?>

<html>
    <head>
        <meta charset="UTF-8">
        <title>Order Vegetables</title>    
        <link href="orderVegetables.css" rel="stylesheet">
    </head>
    <body>
        <div id ="titleImage"><span id = "title">Mike's Vegetable Market</span></div>  <!-- Title banner with background. -->    
        <?php
        if (!isset($_POST['submit'])) {                                         // Validation now with form saving.  Stop making me add more stuff Donnie.
            echo "<span class = errorphp><p>*waves hand*  This is not the page you are looking for.  Wait 5 seconds to be taken back to the order page.</p></span></div></body></html>";
            echo "<script>error()</script>";                                    // NicK C yahoo answers. Call the script to go back in the javascript history.        
            echo "<div class = clockFormat>This error occured at: " . date("g:iA e") . " on " . date("F d, Y") . "<br /><br /></div>"; // Date.      
            exit;
        } else if ($_POST['firstName'] == '' || $_POST['lastName'] == '' || $_POST['phoneNumber'] == '' || strlen($_POST['phoneNumber']) != 10 || $_POST['email'] == '') { // Some more very basic validation.
            echo "<span class = errorphp><p>Sorry but you must have left a required field empty or made an error in a field.  You will be taken back to the order page in 5 seconds.</p></span></body></html>";
            echo "<script>error()</script>";                                    // NicK C yahoo answers. Call the script to go back in the javascript history.
            echo "<div class = clockFormat>This error occured at: " . date("g:iA e") . " on " . date("F d, Y") . "<br /><br /></div>"; // Date.  
            exit;                                                             
        } else if ($_POST['potatoes'] == '' && $_POST['carrots'] == '' && $_POST['brusselsSprouts'] == '' && $_POST['cauliflower'] == '') { // Some more very basic validation.
            echo "<span class = errorphp><p>You must have hit submit before ordering anything.  You will be taken back to the order page in 5 seconds.</p></span></body></html>";
            echo "<script>error()</script>";                                    // NicK C yahoo answers. Call the script to go back in the javascript history.
            echo "<div class = clockFormat>This error occured at: " . date("g:iA e") . " on " . date("F d, Y") . "<br /><br /></div>"; // Date.  
            exit;
        }
        ?>
        <table>
            <tr>
                <td class="formatMenu tableElements">
                    <?php include("menuBar.php"); ?>  <!--http://www.boutell.com/newfaq/creating/include.html-->
                </td >
                <td class="tableElements">                
                    <fieldset>
                        <?php
                        /* Page has a fit if these four variables are set anywhere else. */
                        $firstName = $_POST['firstName'];
                        $lastName = $_POST['lastName'];
                        $phoneNumber = $_POST['phoneNumber'];
                        $email = $_POST['email'];
                        
                        /* This next section is all output with formatting.  This and the CSS were time vampires. */
                        echo "<div class=formattingFirstElement>First Name: <span class=outputNameVariableFormatting>" . $firstName . "</span></div>";
                        echo "<div class=formatting>Last Name: <span class=outputNameVariableFormatting>" . $lastName . "</span></div>";
                        echo "<div class=formatting>Phone Number: <span class=outputNameVariableFormatting>" . $phoneNumber . "</span></div>";
                        echo "<div class=formattingLastElement>E-mail Address: <span class=outputNameVariableFormatting>" . $email . "</span></div>";
                        ?>
                    </fieldset>
                    <fieldset>
                        <?php
                        echo "<div class=formattingFirstElement>Your order:</div>";
                        echo "<div class=formatting>" . $potatoes . " bag(s) of potatoes.  The total cost:<span class=outputVariableFormatting> $" . number_format($potatoesTotal, 2) . "</span></div>";
                        echo "<div class=formatting>" . $carrots . " bag(s) of carrots.  The total cost:<span class=outputVariableFormatting> $" . number_format($carrotsTotal, 2) . "</span></div>";
                        echo "<div class=formatting>" . $brusselsSprouts . " bag(s) of Brussels sprouts.  The total cost:<span class=outputVariableFormatting> $" . number_format($brusselsSproutsTotal, 2) . "</span></div>";
                        echo "<div class=formatting>" . $cauliflower . " cauliflower.  The total cost:<span class=outputVariableFormatting>$" . number_format($cauliflowerTotal, 2) . "</span><br /><br /></div>";
                        echo "<div class=formatting>There is a $" . number_format(DELIVERY_FEE, 2) . " delivery fee for orders under $" . number_format(DELIVERY_FEE_WAIVED, 2) . ".<br /><br /></div>";
                        echo "<div class=formatting>The cost of the order before tax:<span class=outputVariableFormatting>$" . number_format($currentTotal, 2) . "</span></div>";
                        echo "<div class=formatting>The current tax rate: <span class=outputVariableFormatting>" . (TAX_RATE * 100) . "%</span></div>";
                        echo "<div class=formatting>The tax on the order: <span class=outputVariableFormatting>$" . number_format($orderTax, 2) . "</span></div>";
                        echo "<div class=formatting>The delivery fee:  <span class=outputVariableFormatting>$" . number_format($deliveryCost, 2) . "</span></div>";
                        echo "<div class=formatting>The total cost of the order:<span class=outputVariableFormatting>$" . number_format($finalTotal, 2) . "</span><br /><br /></div>";
                        echo "<div class=formattingSpecial><div class = clockFormat>This order was processed at: " . date("g:iA e") . " on " . date("F d, Y") . "</div></div>"; // Date.
                        
                        $fp = fopen("$DOCUMENT_ROOT/../OrderForms/orders.txt", 'a+'); // Create an order forms directory in xamp.  Creates and opens a orders.txt file.  
                        flock($fp, LOCK_EX);               		                     // Lock the file so that no one else can write to it.                    
                        if (!$fp) {                                             // Check to see if an order exists to be written.
                            echo "<div class=formatting>Your order could not be processed at this time.  Please try again later.</div></body></html>";
                            exit;
                        }
                        $orderString = $firstName . "\t" . $lastName . "\t" . $phoneNumber . "\t" . $email . "\t" . $potatoes . " bag(s) of potatoes\t" . $carrots . " bag(s) of carrots\t" . $brusselsSprouts . " bag(s) of Brussels sprouts\t" . $cauliflower . " cauliflower\t$" . $finalTotal . "\tat " . $date . "\r\n";  // \r\n seemed to be needed for the line break to work.  Also I wonder if you read to the end of this line Donnie.  I have no idea why you would but I would feel like a special snowflake if you did.
                        fwrite($fp, $orderString . "\n");                       // Write to the file.
                        flock($fp, LOCK_UN);                                    // Unlock the file.
                        fclose($fp);                                            // Close the file.
                        echo "<div class=formattingLastElement><span class = clockFormat><p>This order was written at: " . date("g:iA e") . " on " . date("F d, Y") . "</p></span></div>"
                        ?>
                    </fieldset>     
                </td>
            </tr>
    </body>
</html>
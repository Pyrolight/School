<!DOCTYPE html>

<!-- Author: Michael Fesser
     Date: Jan 26, 2014
     Purpose: This is the PhP page that takes the input from the user and does calculations
              then displays the results to the screen.
     Last Revision: Jan 27, 2014
     Dependencies: taxRetun.
-->

<html>
    <head>
        <meta charset="UTF-8">
        <title>processTaxReturn</title>    
        <link href="taxReturn.css" rel="stylesheet">
    <div id ="titleImage"><span id = "title">2013 PEI Tax Return Form (For residents of PEI only)</span></div>
</head>
<body>
<body>
    <div class="formatting">
        <?php
        if ($_POST['titleSelector'] == 'a' || $_POST['firstName'] == '' || $_POST['lastName'] == '' || $_POST['address'] == '' || $_POST['postalCode'] == '' || $_POST['income'] == '') { // Some very basic validation.  Validation on both sides!
            echo "Sorry but you must have left a required field empty!";
            $page = "taxReturn.php";                                            // Yoinked from http://www.pixel2life.com/publish/tutorials/729/reloading_a_page_using_php/
            $sec = "4";                                                         // Wait 4 seconds.  PhP is glorious.
            header("Refresh: $sec; url=$page");                                 // Returns the user to taxReturn.php.
        } else {                                                                // Runs the rest of the script.
            switch ($_POST['titleSelector']) {                                  // Switch for title selection.
                case 'b':
                    $title = "Mr.";
                    break;
                case 'c':
                    $title = "Mrs.";
                    break;
                case 'd':
                    $title = "Ms.";
                    break;
                case 'e':
                    $title = "Dr.";
                    break;
                case 'f':
                    $title = "Capt.";
                default:
                    $title = "";
                    break;
            }
            $lastName = $_POST['lastName'];
            $firstName = $_POST['firstName'];
            $address = $_POST['address'];
            $postalCode = $_POST['postalCode'];
            $income = $_POST['income'];
            define('TAX_PERCENTAGE', .30);                                      // Constant since value does not change.
            $taxDecuted;
            $netIncome;
            define('BASIC_EXEMPTION', 14995);                                   // Constant since value does not change.
            define('STUDENT_EXEMPTION', 21000);                                 // Constant since value does not change.
            $exemption = 0;                                                     // Used to display exemption, useful for the user.
            if (isset($_POST['student'])) {                                     // If student check box is set use this formula.
                $taxDecuted = ($income - STUDENT_EXEMPTION) * TAX_PERCENTAGE;
                if ($taxDecuted < 0) {
                    $taxDecuted = 0;
                }
                $exemption = STUDENT_EXEMPTION;
                $netIncome = $income - $taxDecuted;
            } else {                                                            // If student check box is not set use this formula.
                $taxDecuted = ($income - BASIC_EXEMPTION) * TAX_PERCENTAGE;
                if ($taxDecuted < 0) {
                    $taxDecuted = 0;
                }
                $exemption = BASIC_EXEMPTION;
                $netIncome = $income - $taxDecuted;
            }
            date_default_timezone_set('Canada/Atlantic');                       // Set time zone.
            echo "<p>This form was processed at: " . date("g:iA e") . " on " . date("F d, Y") . "</p>"; // Date.

            /* Displays the results of the calculations. */
            echo "<p>Title: " . $title . "<br />First Name: " . $firstName . "<br />Last Name: " . $lastName . "<br />Address: " . $address . "<br />Postal Code: " . $postalCode . "</p>";
            echo "<p>Your income is: " . $income . "</p>";
            echo "<p>The current tax rate is: " . (TAX_PERCENTAGE * 100) . "%</p>";
            echo "<p>Your base tax exemption is: $" . number_format($exemption, 2) . "</p>";
            echo "<p>Tax deducted: $" . number_format($taxDecuted, 2) . "</p>";
            echo "<p>Net Income: $" . number_format($netIncome, 2) . "</p>";
        }
        ?>
    </div>
</body>
</html>

<?php
/*   Author: Michael Fesser
 *   Date: Nov 3, 2014
 *   Purpose: This program tests XML in PHP.  It displays a very basic weather report.  
 *   It shows the date, an image representing the weather conditions, the high and low,
 *   the description of the weather and the average.
 *   Last Revision: Nov 3, 2014
 *   Dependencies: None
 */

// If file exists get it
if (file_exists('XML/forecast.xml')) {
    $forecast = simplexml_load_file('XML/forecast.xml');
    $weeklyHigh = 0; 
    $weeklyLow = 0;
    // Used for the average
    $counter;
} else {
    exit('XML/forecast.xml is missing.');
}
?>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Forecast</title>
    </head>
    <body>
        <!-- Get the values from the XML file for the location and display them -->
        <h1>Forecast for <?php echo $forecast->location->city ?>, <?php echo $forecast->location[0]->province ?>, <?php echo $forecast->location[0]->country ?></h1>
        <h2><span style="font-style:italic">Degrees in </span><?php echo $forecast->location[0]->degrees ?></h2>
        <h2>Five Day Forecast</h2>
        <table style="border: 1px solid black;">
            <tr>
                <!-- Get and display each day's properties from the XML file -->
                <?php foreach ($forecast->daily->day as $days) { 
                    // Set the higs, lows, and counter
                    $weeklyHigh += $days->high;
                    $weeklyLow += $days->low;
                    $counter = count($days);
                    ?>
                    <!-- Some CSS styes, the width is set smaller then the image width to force element to the width of the image -->
                    <td style="border: 1px solid black;padding:4px;width:100px">
                        <?php echo $days->date; ?>
                        <br />                             
                        <?php
                        // PHP.net because it is fun to make stuff potentially harder
                        switch ((string) $days->condition) { // Get attributes as element indices
                            case 'lightning':
                                echo "<img src='img/lightning.jpg' alt=''/>";
                                break;
                            case 'overcast':
                                echo "<img src='img/overcast.jpg' alt=''/>";
                                break;
                            case 'rain':
                                echo "<img src='img/rain.jpg' alt=''/>";
                                break;
                            case 'snow':
                                echo "<img src='img/snow.jpg' alt=''/>";
                                break;
                            case 'sun-cloud':
                                echo "<img src='img/sun-cloud.jpg' alt=''/>";
                                break;
                            case 'sun':
                                echo "<img src='img/sun.jpg' alt=''/>";
                                break;
                        }
                        ?><br />
                        <!-- Display the high and low -->
                        High: <?php echo $days->high; ?>&#176;<br />
                        Low: <?php echo $days->low; ?>&#176;<br />
                    </td> 
                <?php } ?>
            </tr>
            <tr>
                <!-- Get and display the descriptions for each day -->
                <?php foreach ($forecast->daily->day as $days) { ?>                   
                    <td style="border: 1px solid black;padding:4px;vertical-align:top">
                        <?php echo $days->description; ?>
                    </td>
                <?php } ?>
            </tr>
        </table>
        <!-- Display the average high and low -->
        <h3>Weekly High : <?php echo $weeklyHigh/$counter ?>&#176;</h3>
        <h3>Weekly Low: <?php echo $weeklyLow/$counter ?>&#176;</h3>
    </body>
</html>

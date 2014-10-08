<?php
// Input type.
$inputType = "text";
// Input box formatting.
$inputClass = "form-control";
// Used if fields should be active.
$fieldActive = "";
// Used if fields should be diabled.
$fieldDiabled = "disabled";
// Number of input fields per row.
$div3Format = "form-group col-lg-4";
$div4Format = "form-group col-lg-3";

$firstDivLabel = array("Project Value", "Your Mark Point Value", "Your Mark Point Value");
$firstDivString = array("This is the total value of the project.",
    "This is your mark for the project in the form of x/total.  Do not use this field and Percent Value Mark at the same time.",
    "This is your mark for the project in the form of a percentage.  Do not use this field and Point Value Mark at the same time.");
$firstDivID = array("projectMarkTotal", "pointValueMark", "percentageMark");
$firstDivValue = array("", "", "");
$firstDivJS = array("", " onblur=\"validatePoints()\"", " onblur=\"validatePercent()\"");

$secondDivLabel = array("Section Percent before Change", "Section Percent after Change", "Total Percent before Change", "Total Percent after Change");
$secondDivString = array("This is your mark for the section before you updated your marks.",
    "This is your mark for the section after you updated your marks.", "This is your mark for the whole course before you updated your marks",
    "This is your mark for the whole course after you updated your marks");
$secondDivID = array("sectionBeforeChange", "sectionAfterChange", "totalBeforeChange", "totalAfterChange");
$secondDivValue = array("", "", "", "");
$secondDivJS = array("", "", "", "");

$thirdDivLabel = array("Section Percentage per Mark", "Total Percentage per Mark", "Project Value in Section", "Section Weighting");
$thirdDivString = array("This is the percentage value for each mark in the section.", "This is the percentage value for each mark for the whole course.",
    "This is the percentage value for each project in the section.", "This is the value of the section.");
$thirdDivID = array("sectionPercentPerMark", "totalPercentPerMark", "projectValueSection", "sectionValue");
$thirdDivValue = array("0", "0", "0", "0");
$thirdDivJS = array("", "", "", "");

$fourthDivLabel = array("Section Weighting", "Project Value", "Your Mark Point Value", "Your Mark Percentage Value");
$fourthDivString = array("This is the value of the section.", "This is the total value of the project.",
    "This is your mark for the project in the form of x/total.  Do not use this field and Percent Value Mark at the same time.",
    "This is your mark for the project in the form of a percentage.  Do not use this field and Point Value Mark at the same time.");
$fourthDivID = array("totalWeight", "currentProjectMark", "yourPointMark", "yourPercentageMark");
$fourthDivValue = array("", "", "", "");
$fourthDivJS = array("", "", " onblur=\"validatePoints()\"", " onblur=\"validatePercent()\"");

$fifthDivLabel = array("Section Total", "Last Section Mark", "Final Mark");
$fifthDivString = array("This is your current mark in the section.", "This is your current mark in the section.", "This is the current total for all sections");
$fifthDivID = array("sectionTotal", "lastSectionTotal", "finalMark");
$fifthDivValue = array("0", "0", "0");
$fifthDivJS = array("", "", "");

include 'inputField.php';
?>

<!DOCTYPE html>
<html lang="en">
    <head>

        <!-- Author: Michael Fesser
             Date: 12/17/2013
             Purpose: This page is intended for all my attempts at Javascript
             Last Revision: 3/24/2014
             Dependencies: index.php
        -->       

        <title>Javascript</title>

        <?php
        include './header.php';
        ?>

    </head>
    <body>

        <?php
        include './menu.php';
        ?>

        <div class="container topOffSet">
            <div class="row">
                <div class="box">
                    <div class="col-lg-12 text-center">                      
                        <hr>
                        <h2 class="intro-text text-center">Javascript Examples</h2>
                        <hr> 
                    </div>
                    <p>Here are a few very basic JavaScript examples I created, both of which are forms.</p>
                    <p>The first form is designed to allow a student to find what a section of our programming course is worth by comparing the change in the overall grade. The second uses the section value calculated in the first form and then allows a student to do two main things.</p>

                    <ul>
                        <li>First it allows the student to calculate the value of any given project in a section of the course as well as their current mark for that section.</li>  
                        <li>Second it allows the student to calculate their overall mark. The idea is to allow the student the ability to see what they would need to get a certain overall mark based on their current mark.</li>
                    </ul>   
                    <p>Click the label above each field for a brief description of the field's function. Click the label again to close the description.</p>
                </div>
            </div>
            <div class="row">
                <div class="box">
                    <!-- This form is used for to calculate four things.  It finds the value for the section, the value of a project in a section, the value of each mark in a section, and the value for each mark out of the overall total. -->
                    <!-- Each label in both forms have a toggle function -->
                    <form role="form" id="test" class="toggleDefinition">

                        <?php
                        inputDiv($div3Format, $firstDivLabel, $inputType, $inputClass, $firstDivID, $firstDivValue, $firstDivJS, $fieldActive);
                        inputDiv($div4Format, $secondDivLabel, $inputType, $inputClass, $secondDivID, $secondDivValue, $secondDivJS, $fieldActive);
                        inputDiv($div4Format, $thirdDivLabel, $inputType, $inputClass, $thirdDivID, $thirdDivValue, $thirdDivJS, $fieldDiabled);
                        ?> 

                        <div class="row">
                            <div class="form-group col-lg-3">
                                <div><br />
                                    <button type="button" id="submit1" class="btn btn-default" onclick="calculateSectionWeight();">Submit Form</button>
                                    <button type="button" id="reset1" class="btn btn-default" onclick="reset()">Reset</button>
                                </div>                                   
                            </div>
                        </div>
                    </form>
                </div>
                <div class="box">
                    <!-- This form is used to calculate the total mark for the section and the total mark for the course -->
                    <form role="form" class="toggleDefinition">

                        <?php
                        inputDiv($div4Format, $fourthDivLabel, $inputType, $inputClass, $fourthDivID, $fourthDivValue, $fourthDivJS, $fieldActive);
                        inputDiv($div4Format, $fifthDivLabel, $inputType, $inputClass, $fifthDivID, $fifthDivValue, $fifthDivJS, $fieldDiabled);
                        ?>

                        <br />
                        <div class="row">
                            <div class="form-group col-lg-12">
                                <div>
                                    <button type="button" id="submit2" class="btn btn-default" onclick="calculateSectionTotal();">Submit Mark</button>
                                    <button type="button" id="submit3" class="btn btn-default" onclick="calculateFinalTotal();">Submit Section</button>
                                    <button type="button" id="reset2" class="btn btn-default" onclick="reset();">Reset</button>                           

                                    <!-- Used to hold variables -->
                                    <input type="text" id="currentMark" value="0"/>
                                    <input type="text" id="totalProjectMark" value="0"/>
                                    <input type="text" id="totalYourMark" value="0"/>
                                    <input type="text" id="totalPercentage" value="0"/>
                                </div> 
                            </div>
                        </div>
                        <ul>
                            <li>Click Submit Mark to calculate section.</li>
                            <li>Click Submit Section to calculate your final mark by adding sections.</li>
                        </ul>                       
                    </form>
                </div>
            </div>

            <?php
            include 'backToTop.php';
            ?>

        </div><!-- /.container -->

        <?php
        include 'footer.php';
        ?>

    </body>
</html>
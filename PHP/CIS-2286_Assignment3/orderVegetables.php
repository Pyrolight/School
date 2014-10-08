<!DOCTYPE html>

<!-- Author: Michael Fesser
     Date: Jan 31, 2014
     Purpose:  This project build on the income tax project but a produce seller
               web site is created.  This project tests form, validation, 
               opening, closing, writing to, viewing and deleting a file.  The main 
               objective coding was quick about 3 or so hours, the formatting, 
               and constant CSS tweaks was not.  The project overall took a whole
               lot of hours.
     Last Revision: Feb 3, 2014
     Dependencies: None
-->

<html>
    <head>
        <meta charset="UTF-8">
        <title>Order Vegetables</title>    
        <link href="orderVegetables.css" rel="stylesheet">
        <script src="orderVegetables.js"></script>   
    </head>
    <body>       
        <div id ="titleImage"><span id = "title">Mike's Vegetable Market</span></div>  <!-- Title banner with background. -->    
        <!-- The pages are built around two tables for the menu and the main form. -->
        <table>
            <tr>
                <td class="formatMenu tableElements">
                    <?php include("menuBar.php"); ?>  <!--http://www.boutell.com/newfaq/creating/include.html-->
                </td>
                <td class ="tableElements">                       
                    <!-- Basic form uses the post method to send data to the server to be processed.  Has some basic error checking via JavaScript and more error checking via PhP -->
                    <form action="processVeggies.php" method="post">
                        <fieldset>       
                            <div class="formattingFirstElement">
                                <label>Enter your first name:</label>
                                <input type="text" id="firstName" name ="firstName" onblur="validateFirstName();"/><span id ="firstNameError"></span><br /> 
                            </div>
                            <div class="formatting">
                                <label>Enter your last name:</label>            
                                <input type="text" id="lastName" name="lastName" onblur="validateLastName();"/><span id ="lastNameError"></span><br /> 
                            </div>   
                            <div class="formatting">
                                <label>Enter your phone number:</label>
                                <input type="text" id="phoneNumber" name = "phoneNumber" onblur="validatePhoneNumber();"/><span id ="phoneNumberError"></span><br />
                            </div>
                            <div class="formattingLastElement">
                                <label>Enter your e-mail:</label>
                                <input type="text" id="email" name = "email" onblur="validateEmail();"/><span id ="emailError"></span>
                            </div>         
                        </fieldset>
                        <fieldset> 
                            <!-- Used two labels to allow for formatting the prices where I wanted them. -->
                            <div class="formattingFirstElement">Produce:</div>
                            <div class="formatting">
                                <label>5 lb Potatoes,</label>
                                <label class="labelFormat">$5.00</label>
                                <input type="text" id="potatoes" name ="potatoes" onblur="validatePotatoes();"/><span id ="potatoesError"></span><br />
                            </div>
                            <div class="formatting">
                                <label>3 lb Carrots,</label> 
                                <label class="labelFormat">$2.75</label>
                                <input type="text" id="carrots" name="carrots" onblur="validateCarrots();"/><span id ="carrotsError"></span><br /> 
                            </div>   
                            <div class="formatting">
                                <label>1 lb Brussels Sprouts,</label>
                                <label class="labelFormat">$3.00</label>
                                <input type="text" id="brusselsSprouts" name = "brusselsSprouts" onblur="validateBrusselsSprouts();"/><span id ="brusselsSproutsError"></span><br />
                            </div>
                            <div class="formatting">
                                <label>1 Cauliflower,</label>
                                <label class="labelFormat">$3.75</label>
                                <input type="text" id="cauliflower" name = "cauliflower" onblur="validateCauliflower();"/><span id ="cauliflowerError"></span><br /><br />
                            </div>
                            <!-- This output is mimicked in the processVeggies.php page.  It makes the pages flow better, -->
                            <div class="formatting">There is a <span id = "deliveryFeeBase"></span> delivery fee for orders under <span id = "waivedFee"></span>.<br /><br /></div>
                            <div class="formatting">The cost of the order before tax: <span class = "outputVariableFormatting"><span id = "currentTotal"></span></span></div>
                            <div class="formatting">The current tax rate: <span class = "outputVariableFormatting"><span id = "taxRate"></span>%</span></div>
                            <div class="formatting">The tax on the order: <span class = "outputVariableFormatting"><span id = "orderTax"></span></span></div>
                            <div class="formatting">The delivery fee: <span class = "outputVariableFormatting"><span id = "deliveryFee"></span></span></div>
                            <div class="formatting">The total cost of the order: <span class = "outputVariableFormatting"><span id = "finalTotal"></span></span></div>               
                            <div class="submitFormatting">
                                <input type ="submit" id = "submit" name="submit" value="Submit Form"/>
                            </div>
                            <div class="formattingLastElement clockFormat">
                                <?php
                                date_default_timezone_set('Canada/Atlantic');   // Set time zone.
                                echo "<span class = clockFormat><p>The date is " . date("F d, Y") . "</p></span>"; // Date.
                                ?>
                            </div>                
                        </fieldset>
                    </form>                
                </td>
            </tr>
        </table>
    </body>
</html>

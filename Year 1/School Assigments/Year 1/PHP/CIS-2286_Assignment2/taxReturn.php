<!DOCTYPE html>

<!-- Author: Michael Fesser
     Date: Jan 26, 2014
     Purpose: This is a basic tax form to get practice at linking HTML and PhP.
     Last Revision: Jan 27, 2014
     Dependencies: None
-->

<html>
    <head>
        <meta charset="UTF-8">
        <title>taxReturn</title>    
        <link href="taxReturn.css" rel="stylesheet">
        <script src="taxReturn.js"></script>
    <div id ="titleImage"><span id = "title">2013 PEI Tax Return Form (For residents of PEI only)</span></div>  <!-- Title banner with background. -->
</head>
<body>
    <div>  

        <!-- Basic form uses the post method to send data to the server to be processed.  Has some basic error checking via JavaScript and PhP -->
        <form action="processTaxReturn.php" method="post">
            <div class="formatting"> 
                <label>Please select a title:</label> <select id ="titleSelector" name = "titleSelector" onchange="validateTitle();">
                    <option value="a">Select Your Title</option>
                    <option value="b">Mr.</option>
                    <option value="c">Mrs.</option>
                    <option value="d">Ms.</option>
                    <option value="e">Dr.</option>
                    <option value="f">Capt.</option>
                </select><span id ="titleSelectorError"></span><br /> 
            </div> 
            <div class="formatting">
                <label>Enter your first name:</label>
                <input type="text" id="firstName" name ="firstName" onblur="validateFirstName();"/><span id ="firstNameError"></span><br /> 
            </div>
            <div class="formatting">
                <label>Please enter your last name:</label>            
                <input type="text" id="lastName" name="lastName" onblur="validateLastName();"/><span id ="lastNameError"></span><br /> 
            </div>   
            <div class="formatting">
                <label>Enter your address:</label>
                <input type="text" id="address" name = "address" onblur="validateAddress();"/><span id ="addressError"></span><br />
            </div>
            <div class="formatting">
                <label>Enter your postal code:</label>
                <input type="text" id="postalCode" name = "postalCode" onblur="validatePostalCode();"/><span id ="postalCodeError"></span><br />
            </div>
            <div class="formatting">
                <label>Enter your income:</label>
                <input type="text" id= "income" name = "income" onblur="validateIncome();"/><span id ="incomeError"></span><br />
            </div>
            <div class="formatting">
                <label>Are you a student?  Check the box if yes. </label>
                <input type="checkbox" id="student" name ="student"/><br />
            </div>
            <div class="formatting">
                <input type="submit" id="formatThisElement"/>
            </div>    
        </form>              
    </div>      
</body>
</html>

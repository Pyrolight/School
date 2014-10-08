<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
        <link href="template.css" rel="stylesheet">
    </head>
    <body>
        <div class="mainDiv">  
        <form action ="completed.php" method ="POST">
            <table>
                <tr>
                    <td>Customer Code</td><td><input type="text" name="code" /></td>
                </tr>
                <tr>
                    <td>First Name</td><td><input type="text" name="fName" /></td>
                </tr>
                <tr>
                    <td> Last Name</td><td><input type="text" name="lName"/></td>
                </tr>
                <tr>
                    <td> Street Address</td><td><input type="text" name="street"/></td>
                </tr>
                <tr>
                    <td>City</td><td><input type="text" name="city"/></td>
                </tr>
                <tr>
                    <td>State</td><td><input type="text" name="state"/></td>
                </tr>
                <tr>
                    <td>Zip Code</td><td><input type="text" name="zip"/></td>
                </tr>
                <tr>
                    <td>Balance</td><td><input type="text" name="balance"/></td>
                </tr>
                <tr>
                    <td></td><td><input type="submit" name="newCustomer" value="Add Customer"/></td>  
                </tr>
            </table>
        </form>   
        </div>
    </body>
</html>




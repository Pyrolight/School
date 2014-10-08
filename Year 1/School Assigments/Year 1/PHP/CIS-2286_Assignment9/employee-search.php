<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title>Employee Search</title>
        <link href="template.css" rel="stylesheet">
    </head>
    <body>
        <div class="mainDiv">
            <form action="employee-search-results.php" method="GET">
            <h1>Employee Search</h1>
            <table>
                <tr>
                    <td>First Name:</td><td><input type="text" name ="firstName"/></td>
                </tr>
                <tr>
                    <td>Last Name:</td><td><input type="text" name ="lastName"/></td>
                </tr>
                <tr>
                    <td>Order By:</td>
                    <td><select name="orderBy">
                            <option value ="emp_no">Employee Number</option>
                            <option value ="first_name">First Name</option>
                            <option value ="last_name" selected>Last Name</option>
                            <option value ="birth_date">Birth Date</option>
                            <option value ="hire_date">Hire Date</option>                
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>View:</td>
                    <td><select name="view">
                            <option value ="25" selected="">25 Records</option>
                            <option value ="50">50 Records</option>
                            <option value ="100">100 Records</option>
                            <option value ="250">250 Records</option>
                            <option value ="1000">1000 Records</option>                
                        </select>
                    </td> 
                </tr>
                <tr>
                    <td>Sort Direction:</td>
                    <td><select name="sortDirection">
                            <option value ="ASC" selected="">Ascending</option>
                            <option value ="DESC">Descending</option>              
                        </select>
                    </td> 
                </tr>
            </table>
            <input type ="submit" name="submit" value="Search"/>
            </form>
        </div>
    </body>
</html>

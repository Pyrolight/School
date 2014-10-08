<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <link href="template.css" rel="stylesheet">
        <title></title>
    </head>
    <body>
        <div class="mainDiv">
            <form action ="search_1.php" method ="GET">
                <table>
                    <tr>
                        <td>First Name:  </td><td><input type="text" name="fName"/></td>
                    </tr>
                    <tr>
                        <td>Last Name: </td><td> <input type="text" name="lName"/></td>
                    </tr>
                    <tr>
                        <td>Sort the table by: <td><select name ="sortBy">
                                <option value ="cust_fname">First Name</option>
                                <option value ="cust_lname" selected="">Last Name</option>
                            </select></td>
                    </tr>
                    <tr>
                        <td>Sort the table by: <td><select name ="sort">
                                <option value ="asc" >Ascending</option>
                                <option value ="desc" selected="">Descending</option>
                            </select></td>
                    </tr>         
                    <tr>
                        <td>Enter the number of results: </td><td><select name ="numRecords">
                                <option value ="10" >10</option>
                                <option value ="25" selected="">25</option>
                                <option value ="50">50</option>
                                <option value ="200">200</option>
                                <option value ="1000">1000</option>
                                <option value ="9999999">All Records</option>
                            </select></td>
                    </tr><tr>
                        <td>Enter the number of results per page: </td><td><select name ="pagation">
                                <option value ="25" selected="">25</option>
                                <option value ="50">50</option>
                                <option value ="100">100</option>
                            </select></td>
                    </tr>  
                    <tr>
                        <td></td><td><input type="submit" name="submit" value="Search"/></td>  
                    </tr>  
                </table>
            </form> 
        </div>
    </body>
</html>

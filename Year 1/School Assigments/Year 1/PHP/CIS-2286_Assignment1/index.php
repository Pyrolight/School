<!DOCTYPE html>
<html>
    <!-- Author: Michael Fesser
             Date: Jan 12, 2014
             Purpose: To add a PHP date and our resume.
             Last Revision: Jan 12, 2014
             Dependencies: None
    -->
    <head>
        <meta charset="utf-8" />
        <title></title>
        <link rel="stylesheet" href="newcss.css" type="text/css"/>
        <script src="*.js"></script>
        <noscript>
        "You don't have Javascript turned on! In order for this page to function properly you must turn on Javascript."
        </noscript>
    </head>
    <body>
        <!-- Resume built around tables and unordered lists. Modified based off the one on my website -->
        <div class="box">
            <hr>
            <h2 class="center">Resume</h2>
            <hr>
            <div>
                <h3>Education</h3>
                <table>
                    <tr>
                        <td> Computer Information Systems, 2013 – Current</td>
                    </tr>
                    <tr>
                        <td>Holland College, Charlottetown, PE</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>PC Support Specialist, 2007-2010 (specific courses completed – no diploma)</td>
                    </tr>
                    <tr>
                        <td>Academy of Learning, Saskatoon, SK; Dartmouth, NS</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr><td>Network & Internet Support Specialist Diploma with Honors, 2003</td></tr>
                    <tr> <td>CDI College of Business and Technology, Saskatoon, SK</td></tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr> <td>High school Diploma, 1995</td></tr>
                    <tr><td> Holy Cross High school, Saskatoon, SK</td></tr>
                </table><br />

                <h3>Skills & Abilities</h3>

                Programming and scripting languages
                <ul>
                    <li> Java, JavaScript, php, SQL, C#, HTML, CSS </li>
                </ul><br />   

                Database integration and technical skills 
                <ul>
                    <li>MySQL, Apache Server, Linux Server, A+ certification, Networking and Security Essentials, MS Office</li>
                </ul><br />

                <h3>Interpersonal skills</h3>
                <ul>
                    <li>Through years working in the service industry, gained very strong customer service skills</li>
                    <li>Through strong time management skills, maintained a 90% course average while working 13-15 hours a week </li>
                    <li>Have been given a leadership role in the produce department as well as increased responsibilities to help take some of the pressure off of management</li>
                </ul><br />

                <h3>Experience</h3>
                <table>
                    <tr>
                        <td>Colleague Produce Department</td>
                    </tr>
                    <tr>
                        <td>Atlantic Superstore, Charlottetown, PE</td>
                    </tr>
                    <tr>
                        <td>September 2011 – Current</td>
                    </tr>
                </table>                     
                <ul>  
                    <li>Supervisory duties, paperwork</li>
                </ul><br />

                <table>
                    <tr>
                        <td>Service Clerk, Produce Department</td>
                    </tr>
                    <tr>
                        <td>The Real Canadian Superstore, Saskatoon, SK</td>
                    </tr>
                    <tr>
                        <td>May 1999 – Jan 2006</tr>
                </table>
                <ul>
                    <li>Supervisory duties, ordering stock and paperwork</li>
                </ul>
            </div>
        </div><!-- /.container -->
        <br />
        <div class="clock"> <!-- Date function in php! -->
            <?php date_default_timezone_set('EST');
            echo "Served at ";
            echo date("g:iA e");
            echo " on ";    
            echo date("F d, Y");
            ?>
        </div>
    </body>
</html>

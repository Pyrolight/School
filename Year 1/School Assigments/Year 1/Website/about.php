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

$feedbackLabel = array("First Name", "Last Name", "Email");
$feedbackID = array("firstName", "lastName", "email");
$feedbackValue = array("", "", "");
$feedbackJS = array("  onblur=\"validateFirstName();\"", "  onblur=\"validateLastName();\"", " onblur=\"validateEmail();\"");

include 'inputField.php';
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <!-- Author: Michael Fesser
             Date: 12/17/2013
             Purpose: This page has my personal information, resume and contact form.
             Last Revision: 3/24/2014
             Dependencies: index.php
        -->

        <title>About</title>

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
                    <div class="col-lg-12">
                        <hr>
                        <h2 class="intro-text text-center">It's all about <strong>Me</strong></h2>
                        <hr>
                    </div>
                    <div class="col-md-6">
                        <img class="img-responsive img-border-left" src="img/me.jpg" alt="img/me.jpg">
                    </div>
                    <div class="col-md-6">
                        <p>First off the title is a joke, that is my sense of humour.  Enough with the jokes I will tell you a little about myself.</p>
                        <p>I was born on Nov 5, 1977 is Saskatoon, SK. I spent most of my life there until I moved to Bedford, NS in 2008. I spend a few years in Bedford before the situation (no not the guy from Jersey Shore) caused me to relocate to Stratford, PE and I have lived here since 2010.</p>
                        <p>I am currently a student in the Computer Information Systems (fancy way of saying programming) course at Holland College. I am currently in my first year and I am debating whether I want to head straight to work after I finish the course or take two years of University and go for my Bachelor’s Degree in Computer Science. I also work at the Atlantic Superstore in the produce department.</p>
                        <p>I am more or less a homebody and my interests include on-line gaming and programming. Don't let that fool you though, I am not one of those basement dwelling nerds... though I do live in a basement and as I programmer I am kind of a nerd... well please don't hold the fact I am a basement dwelling nerd against me.</p>

                    </div>
                    <div class="clearfix"></div>
                </div>
            </div>
        </div><!-- /.container -->

        <!-- Resume built around tables and unordered lists. -->
        <div class="container" id="resume">
            <div class="row">
                <div class="box">
                    <div class="col-lg-12">
                        <hr>
                        <h2 class="intro-text text-center">Resume</h2>
                        <hr>
                    </div>
                    <div class="col-md-12 h5alt">
                        <h5>Education</h5>
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

                        <h5>Skills & Abilities</h5>

                        Programming and scripting languages
                        <ul>
                            <li> Java, JavaScript, php, SQL, C#, HTML, CSS </li>
                        </ul><br />   

                        Database integration and technical skills 
                        <ul>
                            <li>MySQL, Apache Server, Linux Server, A+ certification, Networking and Security Essentials, MS Office</li>
                        </ul><br />

                        <h5>Interpersonal skills</h5>
                        <ul>
                            <li>Through years working in the service industry, gained very strong customer service skills</li>
                            <li>Through strong time management skills, maintained a 90% course average while working 13-15 hours a week </li>
                            <li>Have been given a leadership role in the produce department as well as increased responsibilities to help take some of the pressure off of management</li>
                        </ul><br />

                        <h5>Experience</h5>
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
                    <div class="clearfix"></div>
                </div>
            </div>
        </div><!-- /.container -->

        <div class="container">
            <div class="row">
                <div class="box">
                    <div class="col-lg-12">
                        <hr>
                        <h2 class="intro-text text-center">Contact Me</h2>
                        <hr>
                        <p>If you need to get in touch with me you can at <a href="mailto:questions@michaelfesser.ca">questions@michaelfesser.ca</a>.  If you have any questions or comments and would like to leave a message for me, please fill out the form and leave your name and e-mail I will get in touch with you.</p>

                        <!-- Contact form -->
                        <form role="form" id="contact" action="feedback.php" method="POST">
                            <?php
                            inputDiv($div3Format, $feedbackLabel, $inputType, $inputClass, $feedbackID, $feedbackValue, $feedbackJS, $fieldActive);
                            ?>
                            <div class="row">
                                <!-- Error validation -->
                                <div id = "firstNameError" class="form-group col-lg-4" style="visibility:hidden">""</div>
                                <div id = "lastNameError" class="form-group col-lg-4" style="visibility:hidden">""</div>
                                <div id = "emailError" class="form-group col-lg-4" style="visibility:hidden">""</div>
                                <div class="clearfix"></div>
                                <div class="form-group col-lg-12">
                                    <label>Message</label>
                                    <textarea id = "textForm" name="message" class="form-control" rows="6" onkeyup="counter();"></textarea>
                                </div>
                                <div id ="counter" class="form-group col-lg-12">500 characters left.</div>
                                <div class="form-group col-lg-12">
                                    <input type="submit" name="submit" id="submit" class="btn btn-default" value="submit"/>                                                               
                                </div>
                            </div>
                        </form>
                    </div>
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

<!-- Author: Michael Fesser
     Date: Mar 14, 2014
     Purpose: This file displays all the functions as a single page.  It also holds
     all the variables that comprise the resume.
     Last Revision: Mar 16, 2014
     Dependencies: none.
-->

<?php
// Include to all all function calls to run.
include 'functions.php';
header_top();

// All the data that makes up the resume.
$title = "Resume";
$titleCSS = "font-weight:heavy; text-align: center;";
$educationTitle = "Education";
$educationTitleCSS = "font-weight:heavy; font-size: 22px;";
$educationArray = array("Computer Information Systems, 2013 – Current", "Holland College, Charlottetown, PE", "&nbsp;",
    "PC Support Specialist, 2007-2010 (specific courses completed – no diploma)", "Academy of Learning, Saskatoon, SK; Dartmouth, NS", "&nbsp;",
    "Network & Internet Support Specialist Diploma with Honors, 2003", "CDI College of Business and Technology, Saskatoon, SK", "&nbsp;",
    "High school Diploma, 1995", "Holy Cross High school, Saskatoon, SK", "&nbsp;");
$educationArrayStyle = "";
$skillsTitle = "Skills & Abilities";
$skills = "Programming and scripting languages";
$skillsArray = array("Java", "JavaScript", "PHP", "SQL", "C#", "HTML", "CSS");
$otherTechSkills = "Database integration and technical skills";
$otherTechSkillsArray = array("MySQL", "Apache Server", "Linux Server", "A+ certification", "Networking and Security Essentials", "MS Office");
$interpersonalTitle = "Interpersonal Skills";
$interpersonal = "Through years working in the service industry, gained very strong customer service skills. <br />
    Through strong time management skills, maintained a 90% course average while working 10-15 hours a week. <br />
    Have been given a leadership role in the produce department as well as increased responsibilities to help take some of the pressure off of management.";
$interpersonalCSS = "margin-left : 25px;";
$experienceTitle = "Experience";
$jobArrayCurrent = array("Colleague Produce Department", "Atlantic Superstore, Charlottetown, PE", "September 2011 – Current");
$jobDutiesCurrent = array("Supervisory duties", "Paperwork");
$jobArrayLast = array("Service Clerk, Produce Department", "The Real Canadian Superstore, Saskatoon, SK", "May 1999 – Jan 2006");
$jobDutiesLast = array("Supervisory duties", "Ordering stock", "Paperwork");
// Call the date from a file.
$date = getTheDate();
$dateCSS = "text-align: center;";
// Condense the two skills arrays for easier use.
$allSkillsArray = getSkillsArray($skillsArray, $otherTechSkillsArray);

// These calls build the resume as an html page.
heading1($title, $titleCSS);
heading1($educationTitle, $educationTitleCSS);
table($educationArray, $educationArrayStyle);
heading1($skillsTitle, $educationTitleCSS);
para($skills);
ulist($skillsArray);
para($otherTechSkills);
ulist($otherTechSkillsArray);
heading1($interpersonalTitle, $educationTitleCSS);
para($interpersonal, $interpersonalCSS);
heading1($experienceTitle, $educationTitleCSS);
table($jobArrayCurrent);
ulist($jobDutiesCurrent);
table($jobArrayLast);
ulist($jobDutiesLast);
skillsSearch($allSkillsArray);
getSkills();
// Used for the pass by reference. Calls the function and passes in the stored date.
lastViewedAt($date, $dateCSS);
// Used for the pass by reference.  Displays the modified date.
echo $date;
footer();
?>
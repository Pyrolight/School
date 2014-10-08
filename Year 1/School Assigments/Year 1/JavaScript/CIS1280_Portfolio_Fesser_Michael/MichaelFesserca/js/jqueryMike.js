/* Author: Michael Fesser
 Date: 12/17/2013
 Purpose: This is the JQuery page.  It's purpose is to move specific instances of JQuery out of the HTML pages.
 Last Revision: 12/17/2013
 Dependencies: index.html, about.html javascript.html
 */

/* The carousel on index.html */
$('.carousel').carousel({
    interval: 5000
});

/* The toggle for all the labels on javascript.html to show their definitions */
$('.toggleDefinition label').click(function() {                                 // Modified version of a function written by Don Bowers. 
    $(this).next('p').slideToggle('fast');
});

/* Reset forms */
function reset() {
    $('#form').trigger("reset");                                                // This function was written by IlyaDoroshin .
}
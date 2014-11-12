using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentLibrary;
using UndergraduateStudentLibrary;
using GraduateStudentLibrary;

/*
Solution name: Student Form
Author: Michael Fesser
Version: #1.0
Description: This is a basic program to test libraries and parent and child classes.  Two student objects are created and then are displayed to the main form
on a button click.  
Dependencies: None.
Change History: None.
*/

namespace StudentForm
{
    /*
    Class Name: Presentation
    Author: Michael Fesser
    Version: #1.0
    Description: This is the main class that display the output for the created student objects.  The objects are instanciated in this class as well as displayed
    in the form.
    Dependencies: None.
    Change History: None.
    */
    public partial class Presentation : Form
    {
        // Initialize the objects
        private GraduateStudent gradStudent;
        private UndergraduateStudent undergraduate;
        // Initialize the list to holdt he student objects
        List<Student> students;
        // Counter used to cycle over the List
        private int counter = 0;

        public Presentation()
        {
            InitializeComponent();
            // Instantiate the grad student
            gradStudent = new GraduateStudent("123", "Fesser", "Mike", "251 Keppoch Rd.", "9023671911", "C.I.S. Degree", "Holland College", "Charlottetown, P.E., Canada");
            // Instantiate the undergrad student with a bit of humour.
            undergraduate = new UndergraduateStudent("111", "Horror", "Rocky", "Oakley Court", "9991234567", "Junior", "Furter", "Frank", "Oakly Court", "9991234567");
            // Instantiate the List
            students = new List<Student>();
            // Add students to the List
            students.Add(gradStudent);
            students.Add(undergraduate);
        }

        /*
        Method name: displayStudentButton_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This method displays the student objects.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        private void displayStudentButton_Click(object sender, EventArgs e)
        {
            studentLabel.Text = this.students[counter].ToString();
            counter++;
            // Reset the counter when the end of the List is reached.
            if (counter >= this.students.Count)
            {
                counter = 0;
            }

        }
    }
}

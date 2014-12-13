using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Program Name: MDI Text Editor
    Author: Michael Fesser
    Version: #1.0
    Description: This progam is designed to test the conepts of a MDI form.  Child forms can be opened within
    the main form that can be used to exit text files.  Both the main form and sub form have appropriate
    controls to that form.
    Dependencies: None.
    Change History: None.
    */
namespace MDITextEditor
{
    /*
    Class Name: MDITextEditorFrom
    Author: Michael Fesser
    Version: #1.0
    Description: This is the main MDI form class.   This class holds the new form, open form, close application 
    and datepicker functionality.  Sub form objects are instantiated from this class.
    Dependencies: None.
    Change History: None.
    */
    public partial class MDITextEditorForm : Form
    {
        // Declare the child form object
        private textEditorFrom childForm;
        // Used to number new child forms
        private int childFormNumber = 0;

        public MDITextEditorForm()
        {
            InitializeComponent();
        }

        /*
       Method name: addItemsButton_Click
       Version: #1.0
       Author: Michael Fesser
       Description: This loads the date and time into the status strip, from vivekese www.codeproject.com.
       Outputs: None.
       Returns: None.
       Change History: None.
       */
        private void MDITextEditorForm_Load(object sender, EventArgs e)
        {
            this.dateTimeTSSL.Text = System.DateTime.Now.ToString();
        }

        /*
       Method name: newTSMI_Click
       Version: #1.0
       Author: Michael Fesser
       Description: This method creates a new child form and passes the date if the datepicker is already
       active.
       Outputs: None.
       Returns: None.
       Change History: None.
       */
        private void newTSMI_Click(object sender, EventArgs e)
        {
            // Try to make a new file
            try
            {
                // Instantiate new child form
                childForm = new textEditorFrom();
                // Make the MDI form the parent of the child form.
                childForm.MdiParent = this;
                // Increment the number of the child form in the title
                childForm.Text = "Window " + childFormNumber++;
                // Show the child form
                childForm.Show();
                // If the datepicker is active pass that value to any new child forms.
                if (datepickerTSMI.Enabled == true)
                {
                    childForm.date = dateTimePicker.Value.ToString();
                }
                // Enable the datepicker menu option
                datepickerTSMI.Enabled = true;
            }
            catch (Exception io)
            {
                MessageBox.Show("The file could not be created.");
            }
        }

        /*
        Method name: openTSMI_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This method creates a new child form, passes the date if the datepicker is already
        active and opens a file in the new child form.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        private void openTSMI_Click(object sender, EventArgs e)
        {
            // Try to open a file
            try
            {
                // Instantiate and new object
                OpenFileDialog openFileDialog = new OpenFileDialog();
                // Goto default user path
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                // Set file types to text
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    // Set the filename to the path
                    string filename = openFileDialog.FileName;
                    // Instantiate new child form and pass the file in a constructor from John Wu www.github.com
                    childForm = new textEditorFrom(filename);
                    // Make the MDI form the parent of the child form.
                    childForm.MdiParent = this;
                    // Increment the number of the child form in the title
                    childForm = new textEditorFrom(filename);
                    // Show the child form
                    childForm.Show();
                    // If the datepicker is active pass that value to any new child forms.
                    if (datepickerTSMI.Enabled == true)
                    {
                        childForm.date = dateTimePicker.Value.ToString();
                    }
                    // Enable the datepicker menu option
                    datepickerTSMI.Enabled = true;
                }
            }
            catch (Exception io)
            {
                MessageBox.Show("The file could not be opened.");
            }
        }

        /*
       Method name: datepickerToolStripMenuItem_Click
       Version: #1.0
       Author: Michael Fesser
       Description: This activates the datepicker and sends the date to the child form.
       Outputs: None.
       Returns: None.
       Change History: None.
       */
        private void datepickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateTimePicker.Show();
            childForm.date = dateTimePicker.Value.ToString();
        }

        /*
        Method name: dateTimePicker1_ValueChanged
        Version: #1.0
        Author: Michael Fesser
        Description: This sends the date to the child form when the date is changed.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            childForm.date = dateTimePicker.Value.ToString();
        }

        /*
        Method name: closeTSB_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This closes the application.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        private void closeTSB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

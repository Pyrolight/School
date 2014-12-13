using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MDITextEditor
{
    /*
    Class Name: textEditorFrom
    Author: Michael Fesser
    Version: #1.0
    Description: This is the child form class.  Text editor objects use this class to allow editing.  
    This class is used to save both new and opened text files.  If the user uses the datapicker object
    the date will be appended to the outputed file on save.
    Dependencies: None.
    Change History: None.
    */
    public partial class textEditorFrom : Form
    {
        // Declare a new streamWriter object.
        private StreamWriter fileOut;
        // Used to hold the datepicker value
        public string date { get; set; }
        public string filename = "null";

        /*
        Constructor name: textEditorFrom
        Version: #1.0
        Author: Michael Fesser
        Description: Default constructor used when a new file is created.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        public textEditorFrom()
        {
            InitializeComponent();
            //This loads the date and time into the status strip, from vivekese www.codeproject.com.
            this.dateTimeTSSL.Text = System.DateTime.Now.ToString();
        }

        /*
       Constructor name: textEditorFrom
       Version: #1.0
       Author: Michael Fesser
       Description: This is the overloaded constructor that is used when a file is opened.  Thanks to 
       Thomas www.stackoverflow for the idea of no file vs existing file.
       Outputs: None.
       Returns: None.
       Change History: None.
       */
        public textEditorFrom(string filename)
        {
            InitializeComponent();
            // Set the filename
            this.filename = filename;
            // Get the text from the file
            string filestring = File.ReadAllText(filename);

            // Try put the text into the textbox for editing
            try
            {
                textEditorTB.Text = filestring;
            }
            catch (Exception io)
            {
                MessageBox.Show("There was an error loading the file");
            }
        }

        /*
       Method name: saveTSMI_Click
       Version: #1.0
       Author: Michael Fesser
       Description: This method save the text to a file.  It will use save or save as depending if the file
       already exists.
       Outputs: None.
       Returns: None.
       Change History: None.
       */
        private void saveTSMI_Click(object sender, EventArgs e)
        {
            // Validate an empty texbox
            if (textEditorTB.Text.Length == 0)
            {
                MessageBox.Show("You need to enter some text before saving");
            }
            else
            {

                // Determine whether to use save or save as aka new vs open
                if (filename == "null")
                {
                    // Instantiate a new object
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    // Get the default path
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    // Set to text files
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        // Set the filename from the path
                        filename = saveFileDialog.FileName;
                        // Try to write to the file
                        try
                        {
                            // Instantiate object
                            fileOut = new StreamWriter(filename, false);
                        }
                        catch (System.IO.IOException io)
                        {
                            MessageBox.Show(io.Message, "Error accessing the file");
                        }
                        // Append the date to the end of the file
                        string text = textEditorTB.Text + "\r\n\r\nDate written: " + date;
                        // Write the text to the file
                        fileOut.WriteLine(text);
                        // Close the file
                        fileOut.Close();
                        MessageBox.Show("Information written to file");
                    }
                }
                // if file exists aka opened
                else
                {
                    // Try to write to file
                    try
                    {
                        // Instantiate object
                        fileOut = new StreamWriter(filename, false);
                    }
                    catch (System.IO.IOException io)
                    {
                        MessageBox.Show(io.Message, "Error accessing the file");
                    }
                    // Append the date to the end of the file
                    string text = textEditorTB.Text + "\r\n\r\nDate written: " + date;
                    // Write the text to the file
                    fileOut.WriteLine(text);
                    // Close the file
                    fileOut.Close();
                    MessageBox.Show("Information written to file");
                }
            }
        }

        /*
        Method name: saveAsTSMI_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This method saves the text to a new or existing file and lets the user choose the name
        of the file.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        private void saveAsTSMI_Click(object sender, EventArgs e)
        {
            // Validate an empty texbox
            if (textEditorTB.Text.Length == 0)
            {
                MessageBox.Show("You need to enter some text before saving");
            }
            else
            {
                // Instantiate a new object
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                // Get the default path
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                // Set to text files
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    // Set the filename from the path
                    filename = saveFileDialog.FileName;
                    // Try to write to the file
                    try
                    {
                        // Instantiate object
                        fileOut = new StreamWriter(filename, false);
                    }
                    catch (System.IO.IOException io)
                    {
                        MessageBox.Show(io.Message, "Error accessing the file");
                    }
                    // Append the date to the end of the file
                    string text = textEditorTB.Text + "\r\n\r\nDate written: " + date;
                    // Write the text to the file
                    fileOut.WriteLine(text);
                    // Close the file
                    fileOut.Close();
                    MessageBox.Show("Information written to file");
                }
            }
        }

        /*
        Method name: closeTSB_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This closes the form.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        private void closeTSB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

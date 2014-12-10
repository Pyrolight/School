/*
 * Project:			Ch11HandsOn
 * Programmer:	    Bradley/Millspaugh
 * Date:			June 2009
 * Description:     Maintain a list of courses and allow user to save
 *                  the list for the next program run.
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ch11HandsOn
{
    public partial class CoursesForm : Form
    {
        private bool isDirtyBoolean;

        public CoursesForm()
        {
            InitializeComponent();
        }


        private void CoursesForm_Load(object sender, EventArgs e)
        {
            // Load the combo box.
            DialogResult responseDialogResult;

            try
            {
                StreamReader classesStreamReader = new StreamReader("Classes.txt");
                while (classesStreamReader.Peek() != -1)
                {
                    classesComboBox.Items.Add(classesStreamReader.ReadLine());
                }
                classesStreamReader.Close();
            }
            catch
            {
                responseDialogResult = MessageBox.Show("Create a new file?",
                    "File not Found", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.No)
                {
                    // Exit the project.
                    exitToolStripMenuItem_Click(e, new System.EventArgs());
                }
            }
        }

        private void addACourseToolStripMenuItem_Click(object sender,
            EventArgs e)
        {
            // Add a course, use a loop to test for duplicate.
            int indexInteger = 0;
            bool itemFoundBoolean = false;

            if (classesComboBox.Text != String.Empty)
            {
                while (indexInteger < classesComboBox.Items.Count &&
                        !itemFoundBoolean)
                {
                    if (classesComboBox.Items[indexInteger++].ToString().ToUpper() ==
                           classesComboBox.Text.ToUpper())
                    {
                        MessageBox.Show("Duplicate class name.", "Class Not Added",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        itemFoundBoolean = true;
                    }
                }
            }
            if (!itemFoundBoolean)
            {
                // Add to the list.
                classesComboBox.Items.Add(classesComboBox.Text);
                isDirtyBoolean = true;
                classesComboBox.Text = String.Empty;
            }
        }

        private void removeACourseToolStripMenuItem_Click(object sender,
            EventArgs e)
        {
            // Remove the selected course.

            if (classesComboBox.SelectedIndex != -1)
            {
                classesComboBox.Items.RemoveAt(classesComboBox.SelectedIndex);
                isDirtyBoolean = true;
            }
            else
            {
                MessageBox.Show("Select a course to remove.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void displayCourseCountToolStripMenuItem_Click(object sender,
            EventArgs e)
        {
            // Display the number of courses.

            MessageBox.Show("Course Count: " + classesComboBox.Items.Count
                .ToString(), "Look Sharp Fitness Center Courses");
        }

        private void clearTheCourseListToolStripMenuItem_Click(object sender,
            EventArgs e)
        {
            // Verify and then remove the course.

            DialogResult confirmDialogResult = MessageBox.Show(
                "Remove all items", "Clear Courses List", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmDialogResult == DialogResult.Yes)
            {
                classesComboBox.Items.Clear();
                isDirtyBoolean = true;
            }
        }

        private void saveCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save the list box contents to a file.
            StreamWriter classesStreamWriter = new StreamWriter("Classes.txt");
            int indexInteger, maximumInteger;

            maximumInteger = classesComboBox.Items.Count;
            for (indexInteger = 0; indexInteger < maximumInteger; indexInteger++)
            {
                classesStreamWriter.WriteLine(classesComboBox.Items[indexInteger]);
            }
            classesStreamWriter.Close();
            isDirtyBoolean = false;
        }

        private void CoursesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ask user to save the file.
            DialogResult responseDialogResult;

            if (isDirtyBoolean)
            {
                responseDialogResult = MessageBox.Show(
                    "Class list has changed. Save the list?", "Class List Changed",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.Yes)
                {
                    saveCoursesToolStripMenuItem_Click(sender, 
                        new System.EventArgs());
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // End the program.

            this.Close();
        }
    }
}
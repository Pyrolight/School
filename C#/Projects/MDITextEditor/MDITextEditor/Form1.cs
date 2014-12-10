using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDITextEditor
{
    public partial class Form1 : Form
    {
        private Form2 childForm;
        private int childFormNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm = new Form2();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                // John Wu www.github.com for the idea to pass the file in a constructor
                childForm = new Form2(filename);
                childForm.MdiParent = this;
                childForm.Text = filename;
                childForm.Show();                           
            }
        }
        private void datepickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Show();
            childForm.date = dateTimePicker1.Value.ToString();
        }
         
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           childForm.date = dateTimePicker1.Value.ToString();
        }
    }
}

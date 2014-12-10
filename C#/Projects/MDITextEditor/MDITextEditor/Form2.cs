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
    public partial class Form2 : Form
    {
        private StreamWriter fileOut;
        public string date { get; set; }
        // Thomas www.stackoverflow for the idea of no file vs existing file.
        public string filename = "null";

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string filename)
        {
            InitializeComponent();
            this.filename = filename;
            string filestring = File.ReadAllText(filename);
            try
            {
                textBox1.Text = filestring;
            }
            catch (Exception io)
            {
                MessageBox.Show("There was an error loading the file");
            }        
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (filename == "null")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    filename = saveFileDialog.FileName;
                    try
                    {
                        fileOut = new StreamWriter(filename, false);
                    }
                    catch (System.IO.IOException io)
                    {
                        MessageBox.Show(io.Message, "Error accessing the file");
                    }
                    string text = textBox1.Text + "\r\n\r\nDate written: " + date;
                    fileOut.WriteLine(text);
                    MessageBox.Show("Information written to file");
                    fileOut.Close();
                }
            }
            else
            {
                try
                {
                    fileOut = new StreamWriter(filename, false);
                }
                catch (System.IO.IOException io)
                {
                    MessageBox.Show(io.Message, "Error accessing the file");
                }
                string text = textBox1.Text + "\r\n\r\nDate written: " + date;
                fileOut.WriteLine(text);
                MessageBox.Show("Information written to file");
                fileOut.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    filename = saveFileDialog.FileName;
                    try
                    {
                        fileOut = new StreamWriter(filename, true);
                    }
                    catch (System.IO.IOException io)
                    {
                        MessageBox.Show(io.Message, "Error accessing the file");
                    }
                    string text = textBox1.Text + "\r\n\r\nDate written: " + date;
                    fileOut.WriteLine(text);
                    MessageBox.Show("Information written to file");
                    fileOut.Close();
                }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menus
{
    public partial class Form1 : Form
    {
        TextClass textClass = new TextClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(object element in checkedListBox1.CheckedItems){
                MessageBox.Show(element.ToString());
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tab1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void tab2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    

                            System.IO.StreamReader SReader = new System.IO.StreamReader(openFileDialog1.FileName);
            richTextBox1.Text = SReader.ReadToEnd();
     
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();          
            if (fontDialog1.ShowDialog() != DialogResult.Cancel){
                exitButton.Font = fontDialog1.Font;

            }

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                submitButton.BackColor = colorDialog1.Color;

            }
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hippie");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            printForm1.Print();
        }

       
         private void saveTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.FileName = " ";
            saveFileDialog1.Filter = "Text Files|.txt|Word Document|.doc";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

         private void sendToClass_Click(object sender, EventArgs e)
         {
             textClass.textString = richTextBox1.Text;
             MessageBox.Show(textClass.textString);
         }

         private void formTwoPass_Click(object sender, EventArgs e)
         {
             Form2 form2 = new Form2();
             form2.setClass(textClass);
             this.Hide();
             form2.Show();
         }
    }
}

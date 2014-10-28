using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.ForeColor = colorDialog1.Color;
            textBox1.BackColor = colorDialog1.Color;
            button1.BackColor = colorDialog1.Color;
        }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fontDialog1.ShowDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                button1.Font = fontDialog1.Font;
                menuStrip1.Font = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                comboBox1.BackColor = colorDialog1.Color;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Selected_File = " ";
            
            openFileDialog1.InitialDirectory = "C:";
            openFileDialog1.Title = "Open File";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "All Files|*.*|Text Files|*.txt|JPEG Image|*.jpg|Word Document|*.Doc";

            openFileDialog1.ShowDialog();

            //Selected_File = openFileDialog1.FileName;
            //pictureBox1.Image = Image.FromFile(Selected_File);
            System.IO.StreamReader SReader = new System.IO.StreamReader(openFileDialog1.FileName);
            richTextBox1.Text = SReader.ReadToEnd();
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.FileName = " ";
            saveFileDialog1.Filter = "Text Files|.txt|Word Document|.doc";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }

        }
    }
}

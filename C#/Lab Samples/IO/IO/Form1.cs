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


namespace IO
{
    public partial class Form1 : Form
    {
        string[] PersonalData = new string[10];
        int indexInteger;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonalData[indexInteger++] = textBox1.Text;
            PersonalData[indexInteger++] = textBox2.Text;

           
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("Textfile.txt", PersonalData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filestring = File.ReadAllText("Textfile.txt");
            string[] aFieldStirng = filestring.Split('\n');
            listBox1.Items.AddRange(aFieldStirng);
        }
    }
}

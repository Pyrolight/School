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

namespace IOAppend
{
    public partial class Form1 : Form
    {
        private StreamWriter fileOut;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                fileOut = new StreamWriter("textfile.txt", true);
            }
            catch (System.IO.IOException io)
            {
                MessageBox.Show(io.Message, "Error accessing the file");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            string phone;

            name = textBox1.Text;
            phone = textBox2.Text;

            fileOut.WriteLine(name + " " + phone);
            MessageBox.Show("Information written to file");
            ClearEntryFields();
        }

        private void ClearEntryFields(){
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileOut.Close();
        }
    }
}

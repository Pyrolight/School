using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form1
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal Sentinal = 0m;

            if (radioButton1.Checked)
            {
                Class1 aClass1 = new Class1();
                aClass1.MsgBase();
            }
            else
            {
                Class2 aClass2 = new Class2();
                aClass2.MsgBase();

                if (decimal.TryParse(textBox1.Text, out Sentinal) == true)
                    aClass2.methBase(Sentinal);
                else
                    aClass2.methBase(Convert.ToString(Sentinal));

            }
        }
    }
}

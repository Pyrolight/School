using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classStuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1<string> aGeneric = new Class1<string>();
            aGeneric.dataMember = "String Message";
            MessageBox.Show("You are a string");

            Class1<decimal> bGeneric = new Class1<decimal>();
            bGeneric.dataMember = 99.9m;
            MessageBox.Show("DataMemeber content in Decimal is " + bGeneric.dataMember);

            Class1<bool> cGeneric = new Class1<bool>();
            cGeneric.dataMember = true;
            MessageBox.Show("DataMemeber content in boolean is " + cGeneric.dataMember);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dynamic intData = 22;
            MessageBox.Show("Dynamic DataMember content is Integer = " + intData);

            dynamic stringData = "String Data";
            MessageBox.Show("Dynamic DataMember content is String = " + stringData);

            dynamic boolData = "Boolean Data";
            MessageBox.Show("Dynamic DataMember content is Boolean = " + boolData);

            dynamic dateData = System.DateTime.Today;
            MessageBox.Show("Dynamic DataMember content is Date = " + dateData);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var intInfo = 1000;
            MessageBox.Show("Var Declared DataMemer content is = " + intInfo);

            var stringInfo = "Word to your mother";
            MessageBox.Show("Var Declared DataMemer content is = " + stringInfo);

            var boolInfo = true;
            MessageBox.Show("Var Declared DataMemer content is = " + boolInfo);

            var dateInfo = System.DateTime.Today;
            MessageBox.Show("Var Declared DataMemer content is = " + dateInfo);
        }


    }
}

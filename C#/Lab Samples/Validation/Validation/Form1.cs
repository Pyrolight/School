using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
            errorProvider1.SetError(textBox2, String.Empty);
            int quantityIteger;
            decimal priceDecimal;

            try
            {
                quantityIteger = int.Parse(textBox1.Text);
                try
                {
                    priceDecimal = decimal.Parse(textBox2.Text); 
                    MessageBox.Show("The data has been entered correctly");
                }
                catch (FormatException)
                {
                    errorProvider1.SetError(textBox2, "Price must be numeric");
                    textBox2.Focus();
                    textBox2.SelectAll();
                }
            }
            catch (FormatException)
            {
                errorProvider1.SetError(textBox1, "Quantity must be numeric.");
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }
    }
}

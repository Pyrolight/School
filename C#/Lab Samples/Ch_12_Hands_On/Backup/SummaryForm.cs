/* Program:			Ch12HandsOn
 * Programmer:		Bradley/Millspaugh
 * Date:			June 2009
 * Description:		Calculate sales price using the ClothingSale class.
 * 					Summary form for hands-on project.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ch12HandsOn
{
    public partial class SummaryForm : BaseForm
    {
        public SummaryForm()
        {
            InitializeComponent();
        }
        private decimal salesTotalDecimal;
        private int salesCountInteger;

        public decimal SalesTotal
        {
            set
            {
                salesTotalDecimal = value;
            }
        }

        public int SalesCount
        {
            set
            {
                salesCountInteger = value;
            }
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            // Fill the text boxes.

            salesCountTextBox.Text = salesCountInteger.ToString();
            salesTotalTextBox.Text = salesTotalDecimal.ToString("C");
        }

    }
}


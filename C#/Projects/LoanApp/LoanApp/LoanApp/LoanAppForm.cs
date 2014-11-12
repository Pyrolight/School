using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanApp
{
    public partial class LoanAppForm : Form
    {
        public LoanAppForm()
        {
            InitializeComponent();
        }

        private void cmboTypeOfLoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboTypeOfLoan.SelectedIndex == 1)
            {
                lblInterestRate.Text = "7.5%";
                lblYears.Text = "4";
                MakeAutoStuffVisible(true);
                MakeHomeStuffVisible(false);
            }
            else
                if (cmboTypeOfLoan.SelectedIndex == 2)
                {
                    lblInterestRate.Text = "5.5%";
                    lblYears.Text = "15";
                    MakeAutoStuffVisible(false);
                    MakeHomeStuffVisible(true);
                }

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";
            if (txtBxLastName.Text == "")
            {
                lblErrorMsg.Text = "Enter last name";
                txtBxLastName.Focus();
            }
            if (txtBxFirstName.Text == "")
            {
                lblErrorMsg.Text = "Enter first name";
                txtBxFirstName.Focus();
            }
            if (txtBxLoanAmt.Text == "")
            {
                lblErrorMsg.Text = "Enter loan amount";
                txtBxLoanAmt.Focus();
            }
            if (cmboTypeOfLoan.SelectedIndex == 1)
            {
                // Code could be modified to make sure numeric values are entered prior to parsing. Better solution would involve TryParse( )
                AutoLoan car = new AutoLoan(txtBxFirstName.Text, txtBxLastName.Text, .075, 
                                                double.Parse(txtBxLoanAmt.Text),
                                                int.Parse(lblYears.Text), int.Parse(txtBxAutoYear.Text), 
                                                txtBxAutoModel.Text, txtBxAutoMake.Text);
                MessageBox.Show( car.ToString(), "Loan Details");
            }
            else
                if (cmboTypeOfLoan.SelectedIndex == 2)
                {
                    HomeLoan condo = new HomeLoan(txtBxFirstName.Text, txtBxLastName.Text,
                                                    .055, double.Parse(txtBxLoanAmt.Text),
                                                    int.Parse(lblYears.Text), int.Parse(txtBxHomeYrBuilt.Text), 
                                                    int.Parse(txtBxHomeSqFt.Text), txtBxHomeAddress.Text);
                    MessageBox.Show(condo.ToString(), "Loan Details");

                }
                else
                {
                    lblErrorMsg.Text = "Select type of loan";
                    cmboTypeOfLoan.Focus();
                }
  

        }

        private void MakeAutoStuffVisible(bool vis)
        {
            lblErrorMsg.Text = "";
            lbAutolMake.Visible = vis;
            lblAutoColor.Visible = vis;
            lblAutoYear.Visible = vis;
            lblAutoModel.Visible = vis;
            txtBxAutoColor.Visible = vis;
            txtBxAutoMake.Visible = vis;
            txtBxAutoModel.Visible = vis;
            txtBxAutoYear.Visible = vis;
            lblAutoHeading.Visible = vis;
        }

        private void MakeHomeStuffVisible(bool vis)
        {
            lblErrorMsg.Text = "";
            lblHouseHeading.Visible = vis;
            lblHomeSqFt.Visible = vis;
            lblHomeYearBuilt.Visible = vis;
            lblHomeAddress.Visible = vis;
            txtBxHomeAddress.Visible = vis;
            txtBxHomeSqFt.Visible = vis;
            txtBxHomeYrBuilt.Visible = vis;
        }
    }
}

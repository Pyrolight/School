using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Program Name: Hats R Us
Author: Michael Fesser
Version: #1.0
Description: This is a basic hat ordering program.  The customer can select a hat, the quanity and the shipping they wish
to use.  There is some basic validation based on empty fields for the customer info, hat quantity and shipping.    
     
After the user clicks calculate order and there are no errors a total will appear on the order form.  They will then be able
to use the process order form to display all the information they entered as well as all the charges for the hats.
Dependencies: None.
Change History: None.
*/
namespace HatsRUs
{
    /*
    Class Name: OrderForm
    Author: Michael Fesser
    Version: #1.0
    Description: This is the main class for the program.  It holds all the fields related to the hats, the customer and the 
    total, subtotal and shipping information.
    Dependencies: None.
    Change History: None.
    */
    public partial class OrderForm : Form
    {
        // Hat price constants.
        private const decimal FULL_DECORATIVE_PRICE = 50.00m;
        private const decimal BEADED_PRICE = 45.00m;
        private const decimal PIRATE_PRICE = 40.00m;
        private const decimal FRINGED_PRICE = 25.00m;
        private const decimal LEATHER_PRICE = 80.00m;
        private const decimal PLAIN_PRICE = 20.00m;

        // Shipping constants.
        private const decimal OVERNIGHT_SERVICE = .10m;
        private const decimal THREE_DAY_SERVICE = .07m;
        private const decimal STANDARD_SERVICE = .05m;

        // The hat types.
        public Boolean fullDecorative { get; set; }
        public Boolean beaded { get; set; }
        public Boolean pirate { get; set; }
        public Boolean fringed { get; set; }
        public Boolean leather { get; set; }
        public Boolean plain { get; set; }
        public String hatSelected { get; set; }
        public decimal quantity { get; set; }
        public int shippingType { get; set; }

        // Totals
        public decimal subtotal { get; set; }
        public decimal shippingTotal { get; set; }
        public decimal total { get; set; }

        // The customer info string.
        public String customerInfo { get; set; }


        /*
        Constructor name: OrderForm
        Version: #1.0
        Author: Michael Fesser
        Description: Sets the default values for the form properties.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        public OrderForm()
        {
            InitializeComponent();
            orderSubtotalTB.Text = 0.ToString("c");
            orderSippingTB.Text = 0.ToString("c");
            orderTotalTB.Text = 0.ToString("c");
        }


        /*
        Method name: exitToolStripMenuItem_Click
        Version: #1.0
        Author: Michael Fesser
        Description: A menu item to close the application.
        Returns: None.
        Change History: None.
        */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
        Method name: calculateOrder_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This method gets all the values from the user, does all the calculations, as well as builds any 
        strings used in the complete order form.  This is where the basic validaion occurs.
        Returns: None.
        Change History: None.
        */
        private void calculateOrder_Click(object sender, EventArgs e)
        {
            // Set totals to 0.
            this.subtotal = 0m;
            this.shippingTotal = 0m;
            this.total = 0m;
            // Used in validation.
            int error = 0;

            // Get the hat values.
            this.fullDecorative = fullDecorativeRB.Checked;
            this.beaded = beadedRB.Checked;
            this.pirate = pirateRB.Checked;
            this.fringed = fringedRB.Checked;
            this.leather = leatherRB.Checked;
            this.plain = plainRB.Checked;
            this.shippingType = shippingCB.SelectedIndex;

            // Get the customer information.
            String firstName = firstNameTB.Text;
            String lastName = lastNameTB.Text;
            String email = emailTB.Text;

            // Build the customer string.
            this.customerInfo = firstName + "\r\n" + lastName + "\r\n" + email;

            // Validate empty fields.
            if (firstNameTB.Text == "")
            {
                error = 1;
                MessageBox.Show("Enter your first name.");
            }
            if (lastNameTB.Text == "")
            {
                error = 1;
                MessageBox.Show("Enter your last name.");
            }
            if (emailTB.Text == "")
            {
                error = 1;
                MessageBox.Show("Enter your email.");
            }

            // This if/else block is used to determine which hat was selecte, the quantity, and then calculate the subtotal.
            if (fullDecorative == true)
            {
                this.hatSelected = fullDecorativeRB.Text;
                this.quantity = fullDecorativeUD.Value;
                this.subtotal += FULL_DECORATIVE_PRICE * this.quantity;
            }
            else if (beaded == true)
            {
                this.hatSelected = beadedRB.Text;
                this.quantity = beadedUD.Value;
                this.subtotal += BEADED_PRICE * this.quantity;
            }
            else if (beaded == true)
            {
                this.hatSelected = pirateRB.Text;
                this.quantity = pirateUD.Value;
                this.subtotal += PIRATE_PRICE * this.quantity;
            }
            else if (beaded == true)
            {
                this.hatSelected = fringedRB.Text;
                this.quantity = fringedUD.Value;
                subtotal += FRINGED_PRICE * this.quantity;
            }
            else if (beaded == true)
            {
                this.hatSelected = leatherRB.Text;
                this.quantity = leatherUD.Value;
                subtotal += LEATHER_PRICE * this.quantity;
            }
            else if (beaded == true)
            {
                this.hatSelected = plainRB.Text;
                this.quantity = plainUD.Value;
                subtotal += PLAIN_PRICE * this.quantity;
            }
            // Validate no hat selected.
            else
            {
                MessageBox.Show("No hat selected.");
                error = 1;
            }

            // Validate no hat quantity selected.
            if (subtotal == 0)
            {
                MessageBox.Show("You need to select a quanity of hats.");
                error = 1;
            }

            // This switch statement is used for the shipping.
            switch (this.shippingType)
            {
                case 0:
                    this.shippingTotal = this.subtotal * OVERNIGHT_SERVICE;
                    break;
                case 1:
                    this.shippingTotal = this.subtotal * THREE_DAY_SERVICE;
                    break;
                case 2:
                    this.shippingTotal = this.subtotal * STANDARD_SERVICE;
                    break;
                default:
                    // Validate no shipping selected.  Might come up since the property for selected index in the designer for this element is flaky for some reason.
                    MessageBox.Show("No shipping Selected.");
                    error = 1;
                    break;
            }
            this.total = this.subtotal + this.shippingTotal;

            // Display totals to user.
            orderSubtotalTB.Text = this.subtotal.ToString("c");
            orderSippingTB.Text = this.shippingTotal.ToString("c");
            orderTotalTB.Text = this.total.ToString("c");

            // Enable the process shipping button and menu item is no errors.
            if (error == 0)
            {
                processOrderButton.Enabled = true;
                processOrderToolStripMenuItem.Enabled = true;
            }
        }

        /*
        Method name: processOrder_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This method creates the completed order form obejct and passes the required variables.
        Returns: None.
        Change History: None.
        */
        private void processOrder_Click(object sender, EventArgs e)
        {
            // Created completeOrder object
            CompletedOrder completedOrder = new CompletedOrder();
            // Pass all variables to the setOrder method.
            completedOrder.setOrder(this.customerInfo, this.hatSelected, this.quantity, this.subtotal, this.shippingTotal, this.total);
            // Show the second form.  As a note the first from is left open in this case.  This allows for the exit menu functionality to get more use.
            completedOrder.Show();
        }
    }
}

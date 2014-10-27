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
    Program Name: Pizza In A Minute
    Author: Michael Fesser
    Version: #1.0
    Description: This is a basic pizza place order form.  The form takes the user selections and then generates a total for the user.
    The user can at any time on the first form change their order and this will be reflected when they click the choose selection buttion.  No price 
    is shown until they first update the order after they make their selections.  After they choose their selecton and they have filled
    in their contact information they will be allowed to place the order.
    Dependencies: None.
    Change History: None.
    */
namespace PizzaInAMinute
{
    /*
    Class Name: OrderForm
    Author: Michael Fesser
    Version: #1.0
    Description: This is the main class for the orderForm form.  This class holds all the methods that get the information from the user.
    Dependencies: None.
    Change History: None.
    */
    public partial class orderForm : Form
    {
        // Create order object.
        Order order = new Order();
        private decimal subTotal;
        private decimal total;

        /*
        Constructor name: orderForm
        Version: #1.0
        Author: Michael Fesser
        Description: Sets the default values for the form properties.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        public orderForm()
        {
            InitializeComponent();
            hamAndPineappleCombo.SelectedIndex = 0;
            chickenLickenCombo.SelectedIndex = 0;
            beefEaterCombo.SelectedIndex = 0;
            veggieCombo.SelectedIndex = 0;
            canadianCombo.SelectedIndex = 0;
            americanCombo.SelectedIndex = 0;
            chefCreationCombo.SelectedIndex = 0;
            buildYourOwnCombo.SelectedIndex = 0;
            subtotalTB.Text = 0.ToString("c");
            taxTB.Text = "14%";
            totalTB.Text = 0.ToString("c");
            // Lock submit button.
            submitOrderButton.Enabled = false;
        }

        /*
        Method name: addItemsButton_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This method sets all the values for the various order from items in the order class.
        Outputs: subtotal and total.
        Returns: None.
        Change History: None.
        */
        private void addItemsButton_Click(object sender, EventArgs e)
        {
            order.hamPineapple = hamAndPinapleRB.Checked;
            order.chickenLicken = chickenLickenRB.Checked;
            order.beefEater = beefEaterRB.Checked;
            order.veggie = veggieRB.Checked;
            order.canadian = CanadianRB.Checked;
            order.american = AmericanRB.Checked;
            order.chefCreation = ChefCreationRB.Checked;
            order.buildYourOwn = buildYourOwnRB.Checked;
            order.hamPineappleCombo = hamAndPineappleCombo.SelectedIndex;
            order.chickenLickenCombo = chickenLickenCombo.SelectedIndex;
            order.beefEaterCombo = beefEaterCombo.SelectedIndex;
            order.veggieCombo = veggieCombo.SelectedIndex;
            order.canadianCombo = canadianCombo.SelectedIndex;
            order.americanCombo = americanCombo.SelectedIndex;
            order.chefCreationCombo = chefCreationCombo.SelectedIndex;
            order.buildYourOwnCombo = buildYourOwnCombo.SelectedIndex;
            order.regularCrust = regularCrustRB.Checked;
            order.cheezeFilled = cheeseFilledCrustRB.Checked;
            order.pretzel = pretzelCrustRB.Checked;
            order.meatFilled = meatFilledCrustRB.Checked;
            order.sauceFilled = sauceFilledCrustRB.Checked;
            order.spinTheWheel = spinTheWheelCrustRB.Checked;
            order.ham = hamCB.Checked;
            order.pepperoni = pepperoniCB.Checked;
            order.sausage = sausageCB.Checked;
            order.hamburger = hamburgerCB.Checked;
            order.salami = SalamiCB.Checked;
            order.onion = onionCB.Checked;
            order.greenPepper = greenPepperCB.Checked;
            order.olives = oliveCB.Checked;
            order.pineapple = pineappleCB.Checked;
            order.mushrooms = mushroomCB.Checked;
            order.tomatoes = tomatoesCB.Checked;
            order.extraSauce = extraSauceCB.Checked;
            order.extraCheese = extraCheeseCB.Checked;
            order.extraThinkCrust = extraThinkCrustCB.Checked;
            order.twistyBread = twistyBreadCB.Checked;
            order.garlicFingers = garlicFingersCB.Checked;
            order.crazyBread = crazyBreadCB.Checked;
            order.hotWings = hotWingsCB.Checked;
            order.buffaloWings = buffaloWingsCB.Checked;
            order.chefWings = chefWingsCB.Checked;
            order.pepsi = pepsiCB.Checked;
            order.coke = cokeCB.Checked;
            order.rootBeer = rootBeerCB.Checked;
            // Enable submit button.
            submitOrderButton.Enabled = true;

            // Get the subtotal.
            this.subTotal = order.calculateSubTotal();
            // Get the total.
            this.total = order.calculateTotal(subTotal);
            // Display the subtotal and total.
            subtotalTB.Text = this.subTotal.ToString("c");
            totalTB.Text = this.total.ToString("c");
        }

        /*
        Method name: resetOrderButton_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This resets the order form.  It does not reset the customer information.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        private void resetOrderButton_Click(object sender, EventArgs e)
        {
            buildYourOwnRB.Checked = true;
            hamAndPineappleCombo.SelectedIndex = 0;
            chickenLickenCombo.SelectedIndex = 0;
            beefEaterCombo.SelectedIndex = 0;
            veggieCombo.SelectedIndex = 0;
            canadianCombo.SelectedIndex = 0;
            americanCombo.SelectedIndex = 0;
            chefCreationCombo.SelectedIndex = 0;
            buildYourOwnCombo.SelectedIndex = 0;
            regularCrustRB.Checked = true;
            hamCB.Checked = false;
            pepperoniCB.Checked = false;
            sausageCB.Checked = false;
            hamburgerCB.Checked = false;
            SalamiCB.Checked = false;
            onionCB.Checked = false;
            greenPepperCB.Checked = false;
            oliveCB.Checked = false;
            pineappleCB.Checked = false;
            mushroomCB.Checked = false;
            tomatoesCB.Checked = false;
            extraSauceCB.Checked = false;
            extraCheeseCB.Checked = false;
            extraThinkCrustCB.Checked = false;
            twistyBreadCB.Checked = false;
            garlicFingersCB.Checked = false;
            crazyBreadCB.Checked = false;
            hotWingsCB.Checked = false;
            buffaloWingsCB.Checked = false;
            chefWingsCB.Checked = false;
            pepsiCB.Checked = false;
            cokeCB.Checked = false;
            rootBeerCB.Checked = false;
            subtotalTB.Text = 0.ToString("c");
            totalTB.Text = 0.ToString("c");
            submitOrderButton.Enabled = false;
        }

        /*
        Method name: submitOrderButton_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This submits the values from the order class to the order summary form.  The button has some basic validation.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        private void submitOrderButton_Click(object sender, EventArgs e)
        {
            int error = 0;

            // Validaite the first name to not be empty.  If no errors send the value to the order class.
            if (firstNameTB.Text == "")
            {
                error++;
                MessageBox.Show("Please enter your first name",
                   "Data Entry Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                firstNameTB.Focus();
            }
            else
            {
                order.firstName = firstNameTB.Text;
            }

            // Validaite the last name to not be empty.  If no errors send the value to the order class.
            if (lastNameTB.Text == "")
            {
                error++;
                MessageBox.Show("Please enter your last name",
                   "Data Entry Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                lastNameTB.Focus();
            }
            else
            {
                order.lastName = lastNameTB.Text;
            }

            // Validaite the address to not be empty.  If no errors send the value to the order class.
            if (addressTB.Text == "")
            {
                error++;
                MessageBox.Show("Please enter an address",
                   "Data Entry Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                addressTB.Focus();
            }
            else
            {
                order.address = addressTB.Text;
            }

            // Validaite the phone number based the the mask.  If no errors send the value to the order class.
            if (!phoneNumberMTB.MaskCompleted)
            {
                error++;
                MessageBox.Show("Please enter your phone number",
                   "Data Entry Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                phoneNumberMTB.Focus();
            }
            else
            {
                order.phoneNumber = phoneNumberMTB.Text;
            }

            // Validaite the email to not be empty.  If no errors send the value to the order class.
            if (emailTB.Text == "")
            {
                error++;
                MessageBox.Show("Please enter your email",
                   "Data Entry Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                emailTB.Focus();
            }
            else
            {
                order.email = emailTB.Text;
            }

            // If there are no errors allow the required values to be sent to the order summary form.
            if (error == 0)
            {
                //  Call the method to generate the contact info string.
                order.contactInfo();
                // Call the method to completely clear the form once submitOrder is clicked.
                clearForm();
                // Create the order summary form and send the selected strings to it.
                OrderSummaryForm orderSummary = new OrderSummaryForm(order.customerInfoString, order.pizzaString, order.toppingsString, order.extraString, order.drinksString, this.total);
                // Show the order summary form.
                orderSummary.Show();
                // Hide this form.
                this.Hide();
            }
        }

        /*
        Method name: clearUserInfoButton_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This resets the customer information.  It does not reset any other part of the order form.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        private void clearUserInfoButton_Click(object sender, EventArgs e)
        {
            lastNameTB.Clear();
            emailTB.Clear();
            firstNameTB.Clear();
            phoneNumberMTB.Clear();
            addressTB.Clear();
        }

        /*
        Method name: clearForm
        Version: #1.0
        Author: Michael Fesser
        Description: This resets the whole form.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        private void clearForm()
        {
            buildYourOwnRB.Checked = true;
            hamAndPineappleCombo.SelectedIndex = 0;
            chickenLickenCombo.SelectedIndex = 0;
            beefEaterCombo.SelectedIndex = 0;
            veggieCombo.SelectedIndex = 0;
            canadianCombo.SelectedIndex = 0;
            americanCombo.SelectedIndex = 0;
            chefCreationCombo.SelectedIndex = 0;
            buildYourOwnCombo.SelectedIndex = 0;
            regularCrustRB.Checked = true;
            hamCB.Checked = false;
            pepperoniCB.Checked = false;
            sausageCB.Checked = false;
            hamburgerCB.Checked = false;
            SalamiCB.Checked = false;
            onionCB.Checked = false;
            greenPepperCB.Checked = false;
            oliveCB.Checked = false;
            pineappleCB.Checked = false;
            mushroomCB.Checked = false;
            tomatoesCB.Checked = false;
            extraSauceCB.Checked = false;
            extraCheeseCB.Checked = false;
            extraThinkCrustCB.Checked = false;
            twistyBreadCB.Checked = false;
            garlicFingersCB.Checked = false;
            crazyBreadCB.Checked = false;
            hotWingsCB.Checked = false;
            buffaloWingsCB.Checked = false;
            chefWingsCB.Checked = false;
            pepsiCB.Checked = false;
            cokeCB.Checked = false;
            rootBeerCB.Checked = false;
            subtotalTB.Text = 0.ToString("c");
            totalTB.Text = 0.ToString("c");
            submitOrderButton.Enabled = false;
            lastNameTB.Clear();
            emailTB.Clear();
            firstNameTB.Clear();
            phoneNumberMTB.Clear();
            addressTB.Clear();
        }

        /*
        Method name: exitButton_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This closes the program.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

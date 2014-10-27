using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaInAMinute
{
    /*
    Class Name: OrderForm
    Author: Michael Fesser
    Version: #1.0
    Description: This is the main class for the order summary form.  This class holds all the methods that display information to the user
    about their order.
    Dependencies: None.
    Change History: None.
    */
    public partial class OrderSummaryForm : Form
    {

        /*
        Constructor name: orderSummaryForm
        Version: #1.0
        Author: Michael Fesser
        Description: This constructor sets all the textboxes in the order summary form when the object is created. 
        It uses the string created in the order class and that were passed there from the order form.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        public OrderSummaryForm(String customerInfoString, String pizzaString, String toppingsString, String extraString, String drinksString, decimal total)
        {
            InitializeComponent();
            customerTB.Text = customerInfoString;
            pizzaTB.Text = pizzaString;
            toppingsTB.Text = toppingsString;
            extrasTB.Text = extraString;
            drinksTB.Text = drinksString;
            totalTB.Text = total.ToString("c");
        }

        /*
        Method name: printOrderButton_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This prints the form in a preview mode.  The preview value is set in the properties of the element itself.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        private void printOrderButton_Click(object sender, EventArgs e)
        {
            printSummary.Print();
        }

        /*
        Method name: exitButton_Click
        Version: #1.0
        Author: Michael Fesser
        Description: This exits the whole application.  This closes both forms.
        Outputs: None.
        Returns: None.
        Change History: None.
        */
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HatsRUs
{
    /*
    Class Name: CompletedOrder
    Author: Michael Fesser
    Version: #1.0
    Description: This class displays the finished order.  It shows the customer info, the total, subtotal and shipping as well as
    the items ordered.  All these values are based to this class and used in the form.
    Dependencies: None.
    Change History: None.
    */
    public partial class CompletedOrder : Form
    {
        public CompletedOrder()
        {
            InitializeComponent();
        }

        /*
        Method name: setOrder
        Version: #1.0
        Author: Michael Fesser
        Description: Them method accepts the variables from the order from and displays them in the appropriate boxes.
        Returns: None.
        Change History: None.
        */
        public void setOrder(String customerInfo, String hatSelected, decimal quantity, decimal subTotal, decimal shipping, decimal total)
        {
            customerInfoRTB.Text = customerInfo;
            orderInfoRTB.Text = " Hat: " + hatSelected + "\r\n Quantity: " + quantity.ToString();
            subtotalTB.Text = subTotal.ToString("c");
            shippingTB.Text = shipping.ToString("c");
            totalTB.Text = total.ToString("c");

        }

        /*
        Method name: printOrder_Click
        Version: #1.0
        Author: Michael Fesser
        Description: Prints the form to a preview.
        Returns: None.
        Change History: None.
        */
        private void printOrder_Click(object sender, EventArgs e)
        {
            orderPrint.Print();
        }

        /*
        Method name: closeFormButton_Click
        Version: #1.0
        Author: Michael Fesser
        Description: Closes the form.
        Returns: None.
        Change History: None.
        */
        private void closeFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

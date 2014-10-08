/* FirstWinApp.cs	 
 * This application enables users to
 * enter their name. The GUI includes
 * labels, a text box, and a button.
 * When the user selects the button, 
 * the name is retrieved and displayed.
 * Various properties are changed on the 
 * form and other controls.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsApp
{
    public partial class FirstWindowsApp : Form
    {
        public FirstWindowsApp()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "Congratulations, " +
                        txtBxName.Text + ", you retreived the data!";
        }
    }
}

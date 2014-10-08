/* Program:			Ch12HandsOn
 * Programmer:		Bradley/Millspaugh
 * Date:			June 2009
 * Description:		Base form for hands-on project.
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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public virtual void  okButton_Click(object sender, EventArgs e)
        {
            // Close the form.

            this.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menus
{
    public partial class Form2 : Form1
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        public void setClass(TextClass textclass)
        {
            richTextBox2.Text = textclass.textString;
        }
    }
}

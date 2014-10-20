using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Class2 : Class1
    {
        public Class2()
        {

        }
        public override void MsgBase()
        {
            MessageBox.Show("OverrideBase Class", "Confirmation");
        }

        public void methBase(decimal num)
        {
            MessageBox.Show("Methode Base is a number: " + num, "Confirmation");
        }
        public void methBase(string num)
        {
            MessageBox.Show("Methode Override Base method is a letter: " + num, "Confirmation");
        }
        
    }
}
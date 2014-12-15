using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _3Tier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusinessLayer getTitle = new BusinessLayer();
            List<String> title = new List<String>();
            title = getTitle.getTitle();
            for (int i = 0; i < title.Count; i++)
            {
                MessageBox.Show(title[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusinessLayer getTitle = new BusinessLayer();
            List<String> title = new List<String>();
            title = getTitle.getTitle();
            for (int i = 0; i < title.Count; i++)
            {
                comboBox1.Items.Add(title[i].ToString());
            }
        }
    }
}


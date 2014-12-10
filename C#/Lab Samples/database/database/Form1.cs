using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carsDataSet.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.carsDataSet.Reservations);
            // TODO: This line of code loads data into the 'carsDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.carsDataSet.Customer);

        }
    }
}

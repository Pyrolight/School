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

namespace moreDatabases
{
    public partial class Form1 : Form
    {
        private OleDbDataAdapter customerDataAdapter;
        private DataSet customerDS;
        private OleDbCommandBuilder commBuilder;
        private OleDbConnection dbConn;
        private OleDbCommand dbcommand;
        private string sConnection;
        private string sql;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = C:\\Users\\mfesser\\Documents\\Visual Studio 2012\\Database\\customers.accdb";

            dbConn = new OleDbConnection(sConnection);

            sql = "select * from CustomerTable;";

            dbcommand = new OleDbCommand();

            dbcommand.CommandText = sql;

            dbcommand.Connection = dbConn;

            customerDataAdapter = new OleDbDataAdapter();

            customerDataAdapter.SelectCommand = dbcommand;

            customerDS = new DataSet();

            customerDataAdapter.Fill(customerDS, "CustomerTable");

            dataGridView1.DataSource = customerDS;

            dataGridView1.DataMember = "CustomerTable";

            dbConn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            commBuilder = new OleDbCommandBuilder(customerDataAdapter);
            customerDataAdapter.Update(customerDS, "CustomerTable");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _3Tier
{
    class DAO
    {
        private OleDbConnection dbconn;
        private OleDbCommand dbCmd;
        private OleDbDataReader dbReader;
        private string sConnection;
        private string sql;
        List<String> title;

        public List<String> titleDAO()
        {
            try
            {
               title = new List<String>();
                sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=rnrBooks.mdb";
                dbconn = new OleDbConnection(sConnection);
                dbconn.Open();

                sql = "SELECT title FROM books";
                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbconn;
                dbReader = dbCmd.ExecuteReader();
                while (dbReader.Read())
                {                
                    title.Add(dbReader["title"].ToString());
                }

                dbReader.Close();
                dbconn.Close();
                
            }
            catch (Exception ex)
            {
            }
            return title;
        }
    }
}

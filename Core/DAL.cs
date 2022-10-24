using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class DAL
    {
        private SqlConnection conn;
        private string connStr;

        public string ConnStr
        {
            get { return connStr; }
            set { connStr = value; }
        }

        public DAL()
        {
            conn = new SqlConnection("Data Source=A102PC24;Initial Catalog=QLSinhVien;Integrated Security=True");
        }
        public DAL(string svName, string dbName)
        {
            conn = new SqlConnection("Data Source=" + svName + ";Initial Catalog=" + dbName + ";Integrated Security=True");
        }
        public void Commit(string query)
        {

        }
    }
}

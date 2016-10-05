using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjMicaDiy
{
    class DBConnect
    {
        public SqlConnection sqlConn;
        public SqlCommand sqlCmd;
        public SqlDataReader sqlDR;
        public SqlDataAdapter sqlDA;
        public void OpenConnection()
        {

            try
            {
                sqlConn = new SqlConnection();
                sqlConn.ConnectionString = ("Data Source = VCDNSTDST04PC05\\VARSITYCOLLEGE; Initial Catalog = MicaDiy; Integrated Security = SSPI");
                sqlConn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error - Connection not establish. \n" + ex.Message);
            }
        }
    }
    
}

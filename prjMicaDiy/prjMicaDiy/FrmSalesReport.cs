using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMicaDiy
{
    public partial class FrmSalesReport : Form 
    {
        public FrmSalesReport()
        {
            InitializeComponent();
        }

        private void btnShowSales_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect objCon = new DBConnect();
                objCon.OpenConnection();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("No Connection" + ex.Message);
            }
        }

        private void listViewSales_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}

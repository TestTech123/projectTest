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
    public partial class FrmMicaDIY : Form
    {
        public FrmMicaDIY()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FrmProduct objFrmProd = new FrmProduct();// calls the Product form
            objFrmProd.Show();
            this.Hide();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            FrmSalesReport objFrmSales = new FrmSalesReport();// calls the sales form
            objFrmSales.Show();
            this.Hide();
        }
    }
}

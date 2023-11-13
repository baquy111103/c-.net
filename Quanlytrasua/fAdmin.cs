using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlytrasua
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
            
        }

        void LoadAccountList()
        {
            string query = "select * from dbo.Account";    
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void LoadFoodList()
        {
            string query = "select * from dbo.Trasua";
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void btnViewBill_Click(object sender, EventArgs e)
        {

        }
    }
}

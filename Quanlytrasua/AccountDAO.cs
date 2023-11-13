using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlytrasua
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO();return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public bool Login1(string userName, string passWord) 
        {
            string query = "select * from Account where UserName = N'"+ userName +" 'and Password = N'" + passWord +"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0; 
        }
    }
}

using QLKho.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Controller
{
    public class AccountData
    {
        private static AccountData instance;
        public static AccountData Instance
        {
            get { if (instance == null) instance = new AccountData(); return instance; }
            set { instance = value; }
        }

        private AccountData() { }

        public bool Login(string userName, string passWord)
        {
            string query = string.Format("Select * from dbo.Account where username = '{0}' and password = '{1}'", userName, passWord);
            DataTable result = SqlConnect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public Account GetAccount(string userName)
        {
            string query = string.Format("SELECT * FROM dbo.Account WHERE username = '{0}'", userName);
            DataTable data = SqlConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }
    }
}

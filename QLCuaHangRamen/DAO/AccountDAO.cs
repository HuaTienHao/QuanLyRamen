using QLCuaHangRamen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangRamen.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = string.Format("SELECT * FROM TBL_ACCOUNT WHERE username = '{0}' AND password = '{1}'", username, password); //"USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{username, password});

            return result.Rows.Count > 0;
        }
    }
}

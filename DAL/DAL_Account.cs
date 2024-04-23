using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Account
    {
        private DTO_Account account;
        public DAL_Account(string userName, string password, DateTime dateCreated, DateTime lastLoginDate, string role) {
            account = new DTO_Account(userName, password, dateCreated, lastLoginDate, role);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Account VALUES('" + account.Password + "', '" + account.DateCreated.ToString() + "', '" + account.UserName + "', '" + account.LastLoginDate.ToString() + "', '" + account.Role + "')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE Account SET password = '" + account.Password + "', date_created =  '" + account.DateCreated.ToString() + "', lastLoginDate = '" + account.LastLoginDate.ToString() + "', role_ = '" + account.Role + "' WHERE username = '" + account.UserName + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM Account WHERE username = '" + account.UserName + "'";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM Account";
            return Connection.selectQuery(s);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Net.Http.Headers;

namespace DAL
{
    public class DAL_AdminAccount
    {
        private DTO_AdminAccount account;
        public DAL_AdminAccount(string userName, string password, DateTime dateCreated, DateTime lastLoginDate, string email) {
            account = new DTO_AdminAccount(userName, password, dateCreated, lastLoginDate, email);
        }

        public void addQuery()
        {
            string query1 = "INSERT INTO Account VALUES('" + account.Password + "', '" + account.DateCreated.ToString() + "', '" + account.UserName + "', '" + account.LastLoginDate.ToString() + "', '" + account.Role + "')";
            string query2 = "INSERT INTO Admin_Account VALUES('" + account.Email + "', '" + account.UserName + "')";
            Connection.actionQuery(query1);
            Connection.actionQuery(query2);
        }

        public void updateQuery()
        {
            string query1 = "UPDATE Admin_Account SET email = '" + account.Email + "' WHERE username = '" + account.UserName + "'";
            string query2 = "UPDATE Account SET password = '" + account.Password + "', WHERE username = '" + account.UserName + "'";
            Connection.actionQuery(query1);
            Connection.actionQuery(query2);
        }

        public void updateLoginDate()
        {
            string query = "UPDATE lastLoginDate = '" + account.LastLoginDate.ToString() + "' WHERE username = '" + account.UserName + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query1 = "DELETE FROM Account WHERE username = '" + account.UserName + "'";
            string query2 = "DELETE FROM Admin_Account WHERE username = '" + account.UserName + "'";
            Connection.actionQuery(query1);
            Connection.actionQuery(query2);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT acc.*, admin_acc.email FROM Account acc INNER JOIN Admin_Account admin_acc ON acc.username = admin_acc.username";
            return Connection.selectQuery(s);
        }
    }
}

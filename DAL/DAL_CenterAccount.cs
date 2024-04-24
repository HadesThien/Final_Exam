using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    internal class DAL_CenterAccount
    {
        private DTO_CenterAccount centerAccount;

        public DAL_CenterAccount(string username, string password, DateTime dateCreated, DateTime lastloginDate)
        {
            centerAccount = new DTO_CenterAccount(username, password, dateCreated, lastloginDate);
        }

        public void addQuery()
        {
            string query1 = "INSERT INTO Account VALUES('" + centerAccount.Password + "', '" + centerAccount.DateCreated.ToString() + "', '" + centerAccount.UserName + "', '" + centerAccount.LastLoginDate.ToString() + "', '" + centerAccount.Role + "')";
            string query2 = "INSERT INTO Center_Account VALUES('" + centerAccount.UserName + "', '" + centerAccount.NumberPhone + "')";
            {
                string query3 = "";
                for (int i = 0; i < centerAccount.staffs.Count; i++)
                {
                    query3 = "INSERT INTO Staff VALUES('" + centerAccount.UserName + "', '" + centerAccount.staffs[i] + "')";
                    Connection.actionQuery(query3);
                }
            }
            Connection.actionQuery(query1);
            Connection.actionQuery(query2);
        }

        public void updateQuery()
        {
            string query = "UPDATE Account SET password = '" + centerAccount.Password + "', WHERE username = '" + centerAccount.UserName + "'";
            Connection.actionQuery(query);
        }

        public void updateLoginDate()
        {
            string query = "UPDATE lastLoginDate = '" + centerAccount.LastLoginDate.ToString() + "' WHERE username = '" + centerAccount.UserName + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM Center_Account WHERE username = '" + centerAccount.UserName + "'";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT acc.username, acc.date_created, acc.lastLoginDate, acc.role_ FROM Account acc INNER JOIN Center_Account center_acc ON acc.username = center_acc.username";
            return Connection.selectQuery(s);
        }

        public DataTable selectPassword()
        {
            string s = "SELECT acc.password FROM Account acc INNER JOIN Center_Account center_acc ON acc.username = center_acc.username WHERE center_acc.username = '" + centerAccount.UserName + "'";
            return Connection.selectQuery(s);
        }
    }
}

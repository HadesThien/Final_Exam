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
        public DAL_Account(string userName, string password, DateTime dateCreated, DateTime lastLoginDate, string role,string email,string numberPhone,string name) {
            account = new DTO_Account(userName, password, dateCreated, lastLoginDate, role, email, numberPhone,name);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Account VALUES('" + account.Password + "', '" + account.DateCreated.ToString() + "', '" + account.UserName + "', '" + account.LastLoginDate.ToString() + "', '" + account.Role + "')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE Account SET password = '" + account.Password + "', dateCreated =  '" + account.DateCreated.ToString("yyyy/MM/dd")
                + "', lastLoginDate = '" + account.LastLoginDate.ToString("yyyy/MM/dd")
                +"', role = '" + account.Role + "', email = '" + account.Email +"', numberPhone = '"+ account.NumberPhone
                + "',name = '"+account.Name+"'  WHERE username = '" + account.UserName + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM Account WHERE username = '" + account.UserName + "'";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT username,password,role,email,numberphone,name,lastLoginDate,dateCreated FROM Account";
            return Connection.selectQuery(s);
        }
         public string getUsername() {
            return account.UserName;
        }
        public string getPassword() {
            return account.Password;
        }
        public string getRole() {
            return account.Role;
        }
        public string getEmail() {
            return account.Email;
        }
        public string getName() {
            return account.Name;
        }
        public string getNumberphone() {
            return account.NumberPhone;
        }
        public DateTime getLastLoginDate() {
            return account.LastLoginDate;
        }
        public DateTime getDateCreated() {
            return account.DateCreated;
        }
        public void setPassword(string password) { 
            if(password != null && password != "") {
                Console.WriteLine(password);
                account.Password = password;    
            }
        }
    }
}

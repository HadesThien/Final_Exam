using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Account
    {
        //Properties
        DAL_Account account; 
        //Constructos
        public BUS_Account(string userName, string password, DateTime dateCreated, DateTime lastLoginDate, string role,string email,string numberPhone,string name) {
            account = new DAL_Account(userName,password,dateCreated,lastLoginDate,role,email,numberPhone,name);
        }
        public DataTable showAccounts() {
            return account.selectQuery();
        }
        public void remove() {
            account.deleteQuery();
        }
        public void changePassword(string newPassword) {
            account.setPassword(newPassword);
            account.updateQuery();
        }
        public string getUsername() {
            return account.getUsername();
        }
        public string getPassword() {
            return account.getPassword();
        }
        public string getRole() {
            return account.getRole();
        }
        public string getEmail() {
            return account.getEmail();
        }
        public string getName() {
            return account.getName();
        }
        public string getNumberphone() {
            return account.getNumberphone();
        }
        public DateTime getLastLoginDate() {
            return account.getLastLoginDate();
        }
        public DateTime getDateCreated() {
            return account.getDateCreated();
        }
        
    }
}

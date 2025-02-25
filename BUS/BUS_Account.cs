using DAL;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class BUS_Account
    {
        //Properties
        DAL_Account account; 
        //Constructos
        public BUS_Account(DTO_Account account) {
            this.account = new DAL_Account(account);
        }

        public DataTable showAccounts() {
            DataTable dt = account.selectQuery();
            return dt;
        }
        public void remove() {
            account.deleteQuery();
        }
        public void changePassword(string newPassword) {
            account.setPassword(newPassword);
            account.updateQuery();
        }
        public void addAccount() {
            account.addQuery();
        }
        public void updateAccount() {
            account.updateQuery();
        }
        

        //Get set methods
        public string getUsername() {
            return account.getUsername();
        }
        public string getPassword() {
            return account.getPassword();
        }
        public string getRole() {
            return account.getRole();
        }
        public DateTime getDateCreated() {
            return account.getDateCreated();
        }
        
    }
}

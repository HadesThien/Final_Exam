using System;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_Account
    {
        private DTO_Account account;
        public DAL_Account(DTO_Account account) {
            this.account = account;
        }

        public void addQuery()
        {
            string query = "INSERT INTO Account VALUES('" + account.getUsername()+ "', '" + account.getPassword() + "', '" + account.getDateCreated().ToString("MM/dd/yyyy") + ", '" + account.getRole() + "' )";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE Account SET password = '" + account.getPassword() + "', date_created =  '" + account.getDateCreated().ToString("yyyy/MM/dd")
                +"'  WHERE username = '" + account.getUsername() + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM Account WHERE username = '" + account.getUsername() + "'";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string query = "SELECT * FROM Account";
            return Connection.selectQuery(query);
        }

        //Getter
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
        public void setPassword(string password) { 
            if(password != null && password != "") {
                Console.WriteLine(password);
                account.setPassword(password);
            }
        }
    }
}

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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class DTO_CenterAccount : DTO_Account{
        //Properties
        public List<string > NumberPhones = new List<string>();
        public List<string> UsersName = new List<string>();

        //Constructor
        public DTO_CenterAccount(string username, string password, DateTime dateCreated, DateTime lastloginDate): 
            base(username,password,dateCreated,lastloginDate,"Staff") {
        }
        
    }
}

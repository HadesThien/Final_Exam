using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class DTO_AdminAccount : DTO_Account{
        public string Email { get; set; }

        public DTO_AdminAccount(string userName, string password, DateTime dateCreated,DateTime lastLoginDate,string email) 
            :base(userName,password,dateCreated,lastLoginDate,"Admin") {
            Email = email;
        }
    }
}

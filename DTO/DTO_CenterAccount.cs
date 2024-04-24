using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class DTO_CenterAccount : DTO_Account{
        //Properties
        public string NumberPhone { get; set; }
        public List<string> staffs = new List<string>();

        //Constructor
        public DTO_CenterAccount(string username, string password, DateTime dateCreated, DateTime lastloginDate): 
            base(username,password,dateCreated,lastloginDate,"Staff") {
        }

        public void addStaff(string staff)
        {
            staffs.Add(staff);
        }
        
    }
}

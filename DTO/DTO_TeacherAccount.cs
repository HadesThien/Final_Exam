using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class DTO_TeacherAccount : DTO_Account{
        public DTO_TeacherAccount(string username, string password, DateTime dateCreated, DateTime lastLoginDate)
            :base(username,password, dateCreated, lastLoginDate, "Teacher") {}
    }
}

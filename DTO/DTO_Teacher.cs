using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class DTO_Teacher :DTO_Person{
        //Properties
        public string Subject { get; set; }
        //Constructor
        public DTO_Teacher(string id, string name, string gender, DateTime dob,string numberPhone, string subject)
            : base(id, name, gender, dob, numberPhone) {
            Subject = subject;
        }
    }
}

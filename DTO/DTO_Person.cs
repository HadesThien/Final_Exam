using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class DTO_Person {
        //Properties
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }

        public string NumberPhone { get; set; }

        //Constructor
        public DTO_Person(string id, string name, string gender, DateTime dob, string numberPhone) {
            Id = id;
            Name = name;
            Gender = gender;
            Dob = dob;
            NumberPhone = numberPhone;
        }

    }
}

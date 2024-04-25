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
        public List<string> Number_Phones { get; set; }

        //Constructor
        public DTO_Person(string id, string name, string gender, DateTime dob, string numberPhone) {
            Id = id;
            Name = name;
            Gender = gender;
            Dob = dob;
            this.Number_Phones = new List<string>();
            Number_Phones.Add(numberPhone);
        }
        public void addNumberPhone(string numberPhone) {
            Number_Phones.Add(numberPhone);
        }
        
        

    }
}

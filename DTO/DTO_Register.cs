using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class DTO_Register {
        public DTO_Student Student {  get; set; }
        public DTO_Class Class {  get; set; }
        public DateTime AddmissionDay {  get; set; }
        public string State { get; set; }

        public DTO_Register(DTO_Student s, DTO_Class c, DateTime admision_Day, string state) {
            Student = s;
            Class = c;
            State = state;
            AddmissionDay = admision_Day;
        }
    }
}

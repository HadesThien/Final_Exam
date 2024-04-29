using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class DTO_Register {
        public string StudentId {  get; set; }
        public string ClassId {  get; set; }
        public DateTime AddmissionDay {  get; set; }

        public DTO_Register(string s, string c, DateTime admision_Day) {
            StudentId = s;
            ClassId = c;
            AddmissionDay = admision_Day;
        }
    }
}

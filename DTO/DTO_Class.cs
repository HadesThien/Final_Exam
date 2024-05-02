using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class DTO_Class {
        public string ClassId {  get; set; }
        public string Subject { get; set; }
        public string Shift { get; set; }
        public int Grade { get; set; }
        public int Price {  get; set; }
        public int Number_Of_Session { get; set; }
        public int Number_Of_Student {  get; set; }
        public DateTime Date_Created { get; set; }
        public string Status { get; set; }
        public string TeacherId { get; set; }
        public List<DTO_Register> Registers { get; set; }

        public DTO_Class(string classId, string subject, string shift,  int grade, int price, int n_Session, int n_Student, DateTime date_Created,string status, string teacherId) {
            ClassId = classId;
            Subject = subject;
            Shift = shift;
            Grade = grade;
            Price = price;
            Number_Of_Session = n_Session;
            Number_Of_Student = n_Student;
            Date_Created = date_Created;
            TeacherId = teacherId;
            Status = status;
            Registers = new List<DTO_Register>();
        }

        
    }
}

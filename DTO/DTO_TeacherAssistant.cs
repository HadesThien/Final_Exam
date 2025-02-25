using System;
using System.Collections.Generic;

namespace DTO {
    public class DTO_TeacherAssistant : DTO_Employee{
        //Property
        private string subject;
        private List<DTO_Class> classes;

        //Constructor
        public DTO_TeacherAssistant(
            string id,
            string fullname,
            int coefficient,
            int dayOffLeft,
            DateTime dob,
            string phoneNumber,
            string email,
            DateTime hireDate,
            DTO_Subject subject
            ) : 
            base(id,fullname,coefficient,dayOffLeft,dob,phoneNumber,email,hireDate) {
            this.subject = subject.getSubject();
            this.classes = new List<DTO_Class>();
        }
        public DTO_TeacherAssistant(string id):base(id) { }

        //Methods
        public void addClassObj(DTO_Class classObj) { classes.Add(classObj); }
        public void removeClassObj(DTO_Class classObj ) { classes.Remove(classObj); }
        //Setter
        public void setSubject(string subject) { this.subject = subject; }  
        public void setClasslist(List<DTO_Class> classes) { this.classes = classes; }
        //Getter
        public string getSubject( ) { return subject; }
        public List<DTO_Class> getClasslist( ) { return classes; }
    }
}

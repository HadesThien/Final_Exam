using System;

namespace DTO {
    public class DTO_Subject {
        //Property
        private string subjectId;
        private string subject;

        //Constructor
        public DTO_Subject(string subjectId, string subject) {
            this.subjectId = subjectId;
            this.subject = subject;
        }
        public DTO_Subject() {

        }
        //Methods
        //Setter
        public void setSubjectId(string subjectId) { this.subjectId = subjectId; }
        public void setSubject(string subject) { this.subject = subject; }

        //Getter
        public string getSubject() { return this.subject; }
        public string getSubjectId() {  return this.subjectId; }

    }
}

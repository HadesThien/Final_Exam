using System;

namespace DTO {
    public class DTO_Register {
        //Property
        private string registerId;
        private DateTime date;
        private DateTime dateOff;
        
        private DTO_Student student;
        private DTO_Class className;

        //Constructor
        public DTO_Register(string registerId, DateTime date, DateTime dateOff) {
            this.registerId = registerId;
            this.date = date;
            this.dateOff = dateOff;
        }
        public DTO_Register() {

        }
        //Setter
        public void setStudent(DTO_Student student) {
            this.student = student;
        }
        public void setClass(DTO_Class className) {
            this.className = className;
        }
        public void setRegisterId(string registerId) {
            this.registerId = registerId;
        }
        public void setDate(DateTime date) {
            this.date = date; 
        }
        public void setDateOff(DateTime dateOff) {
            this.dateOff = dateOff;
        }

        //Getter
        public string getRegisterId() {
            return this.registerId;
        }
        public DateTime getDate() {
            return this.date;
        }
        public DateTime getDateOff() {
            return this.dateOff;
        }
        public DTO_Student getStudent() {
            return this.student;
        }
        public DTO_Class getClassName() {
            return this.className;
        }

    }
}

using System;
using System.Collections.Generic;

namespace DTO {
    public class DTO_Student {
        //Property
        private string studentId;
        private string fullname;
        private string address;
        private DateTime dateOfBirth;
        private string phoneNumber;
        private string school;
        private string status;
        private string parrentPhoneNumber;
        private string note;
        private List<DTO_Payment> payments;
        private List<DTO_Register> registers;


        //Constructor
        public DTO_Student(string studentId, string fullname, string address, DateTime dateOfBirth, string phoneNumber, string school, string status, string parrentPhoneNumber, string note) {
            this.studentId = studentId;
            this.fullname = fullname;
            this.address = address;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.school = school;
            this.status = status;
            this.parrentPhoneNumber = parrentPhoneNumber;
            this.note = note;
            payments = new List<DTO_Payment>();
            registers = new List<DTO_Register>();
        }
        public DTO_Student() {

        }

        //Methods
        //Setter
        public void setStudentId(string studentId) {
            this.studentId = studentId;
        }
        public void setFullName(string fullName) {
            this.fullname = fullName;
        }

        public void setStatus(string status) {
            this.status = status;
        }

        public void setSchool(string school) {
            this.school = school;
        }
        public void setPaymentList(List<DTO_Payment> payments) {
            this.payments = payments;
        }
        public void setRegisterList(List<DTO_Register> registers) {
            this.registers = registers;
        }

        public void setPhoneNumber(string phoneNumber) {
            this.phoneNumber = phoneNumber;
        }

        public void setParrentPhoneNumber(string parrentPhoneNumber) {
            this.parrentPhoneNumber = parrentPhoneNumber;
        }
        public void setNote(string note) {
            this.note = note;
        }
        public void setAddress(string address) {
            this.address = address;
        }
        public void setDateOfBirth(DateTime dateOfBirth) {
            this.dateOfBirth = dateOfBirth;
        }

        //Getter
        public string getStudentId() {
            return this.studentId;
        }
        public string getFullName() {
            return this.fullname;
        }
        public DateTime getDateOfBirth() {
            return this.dateOfBirth;
        }
        public string getPhoneNumber() {
            return this.phoneNumber;
        }
        public string getSchool() {
            return this.school;
        }
        public string getStatus() {
            return this.status;
        }
        public string getParrentPhoneNumber() {
            return this.parrentPhoneNumber;
        }
        public string getNote() {
            return this.note;
        }
        public List<DTO_Payment> getPayments() {
            return this.payments;
        }
        public List<DTO_Register> getRegisters() {
            return this.registers;
        }
        public string getAddress() {
            return this.address;
        }

    }
}

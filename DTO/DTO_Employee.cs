using System;
using System.Collections.Generic;

namespace DTO {
    public class DTO_Employee {
        //Property 
        private string id;
        private string fullname;
        private float coefficient;
        private int dayOffLeft;
        private DateTime dateOfBirth;
        private string phoneNumber;
        private string email;
        private DateTime hireDate;
        private DTO_Account account;
        private List<DTO_Payroll> payrolls;
        private List<DTO_Leave> leaves;

        //Constructor 
        public DTO_Employee(
            string id, 
            string fullname, 
            float coefficient, 
            int dayOffLeft,
            DateTime dateOfBirth, 
            string phoneNumber, 
            string email,
            DateTime hireDate
            ) {
            this.id = id;
            this.fullname = fullname;
            this.coefficient = coefficient;
            this.dayOffLeft = dayOffLeft;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.hireDate = hireDate;
            this.payrolls = new List<DTO_Payroll>();
            this.leaves = new List<DTO_Leave>();
        }
        public DTO_Employee(string id) {
            this.id = id;
        }
        //Methods 
        public void addPayroll(DTO_Payroll payroll) {
            payrolls.Add(payroll);
        }
        public void removePayroll(DTO_Payroll payroll) {
            payrolls.Remove(payroll);
        }
        public void addLeave ( DTO_Leave leave) {
            leaves.Add(leave);
        }
        public void removeLeave(DTO_Leave leave) {
            leaves.Remove(leave);
        }
        
        //Setter
        public void setId(string id) { this.id=id; }
        public void setFullname(string fullname) { this.fullname=fullname; }
        public void setCoefficient(int coefficient) { this.coefficient= coefficient; }
        public void setDateOff(int dayOffLeft) {  this.dayOffLeft = dayOffLeft; }
        public void setDateOfBirth(DateTime dateOfBirth) { this.dateOfBirth=dateOfBirth; }
        public void setPhoneNumber(string phoneNumber) {  this.phoneNumber=phoneNumber; }
        public void setEmail(string email) {  this.email=email; }
        public void setHireDate(DateTime date) { this.hireDate=date; }
        public void setAccount(DTO_Account account) { this.account=account; }
        public void setPayrolls(List<DTO_Payroll> payrolls) { this.payrolls=payrolls; }
        public void setLeaves (List<DTO_Leave> leaves) { this.leaves = leaves; }


        //Getter
        public string getId() { return id; }
        public string getFullname() { return fullname; }
        public float getSalarayCoefficient() { return coefficient; }
        public int getDateOff() { return dayOffLeft; }
        public DateTime getDateOfBirth() { return dateOfBirth; }
        public string getPhoneNumber() { return phoneNumber; }
        public string getEmail() {  return email; }
        public DTO_Account getAccount() { return account; }
        public DateTime getHireDate() {  return hireDate; }
        public List<DTO_Payroll> getPayrolls() { return payrolls; }
        public List<DTO_Leave> getLeaves() { return leaves; }


    }
}

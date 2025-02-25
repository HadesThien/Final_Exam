using System;
using System.Collections.Generic;

namespace DTO {
    public class DTO_Salary {
        //Property
        private string salaryId;
        private DateTime date;
        private int amount;
        private int bonus;
        public List<DTO_Payroll> payrolls;

        //Constructor
        public DTO_Salary(string salaryId,DateTime date, int amount, int bonus) {
            this.salaryId = salaryId;
            this.date = date;
            this.amount = amount;
            this.bonus = bonus;
            payrolls = new List<DTO_Payroll>();
        }

        public DTO_Salary() {

        }
        //Methods
        public void addPayroll(DTO_Payroll payroll) {
            this.payrolls.Add(payroll);
        }
        public void removePayroll(DTO_Payroll payroll) {
            this.payrolls.Remove(payroll);
        }

        //Setter
        public void setSalaryId(string salaryId) { this.salaryId = salaryId; }
        public void setDate(DateTime date) { this.date = date; }
        public void setAmount(int amount) { this.amount = amount; }
        public void setBonus(int bonus) {  this.bonus = bonus; }
        public void setPayroll(List<DTO_Payroll> payrolls) { this.payrolls = payrolls; }
        
        //Getter
        public string getSalaryId() { return salaryId; }
        public DateTime getDate() { return date; }
        public int getAmount() { return amount; }
        public int getBonus() {return bonus;}
        public List<DTO_Payroll> GetPayrolls() { return payrolls; }
        
    }
}

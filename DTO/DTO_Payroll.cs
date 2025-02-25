using System;
using System.Collections.Generic;

namespace DTO {
    public class DTO_Payroll {
        //Property
        private string payrollId;
        private string report;
        private int totalAmount;
        private DateTime date;


        //Constructor
        public DTO_Payroll(string payrollId, string report, int totalAmount, DateTime date) {
            this.payrollId = payrollId;
            this.report = report;
            this.totalAmount = totalAmount;
            this.date = date;
        }
        //Methods
        //Setter
        public void setPayrollId(string payrollId) {this.payrollId=payrollId;}
        public void setReport(string report) {this.report=report;}
        public void setTotalAmount(int totalAmount) { this.totalAmount=totalAmount;}
        public void setDate(DateTime date) {this.date=date;}

        //Getter
        public string getPayrollId() {return this.payrollId;}
        public string getReport() { return this.report;}
        public int getTotalAmount() {return this.totalAmount;}
        public DateTime getDate() {return this.date;}
          
    }
}

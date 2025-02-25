using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
    public class DAL_Employee {
        //Property
        private DTO_Employee employee;
        //Constructor
        public DAL_Employee(DTO_Employee employee) { this.employee = employee; }
        //Methods
        // Insert employee into table  
        public void addQuery()
        {
            string query = "";
            Connection.actionQuery(query);
        }
        //Edit or Update information of employee
        public void updateQuery()
        {
            string query = "";
            Connection.actionQuery(query);
        }
        //Remove Employee
        public void deleteQuery()
        {
            string query = "";
            Connection.actionQuery(query);
        }
        //Show one or all employee
        public DataTable selectQuery()
        {
            string query = "Select * from Employee";
            return Connection.selectQuery(query);
        }
        public DataTable selectSpecificEmployee(string id) {
            string query = $"Select * from Employee where employee_id = '{id}'";
            return Connection.selectQuery(query);
        }

        //Getter 

        public string getId() { return employee.getId(); }
        public string getFullname() { return employee.getFullname(); }
        public float getSalarayCoefficient() { return employee.getSalarayCoefficient(); }
        public int getDateOff() { return employee.getDateOff(); }
        public DateTime getDateOfBirth() { return employee.getDateOfBirth(); }
        public string getPhoneNumber() { return employee.getPhoneNumber(); }
        public string getEmail() {  return employee.getEmail(); }
        public DTO_Account getAccount() { return employee.getAccount(); }
        public DateTime getHireDate() {  return getHireDate(); }
        public List<DTO_Payroll> getPayrolls() { return employee.getPayrolls(); }
        public List<DTO_Leave> getLeaves() { return employee.getLeaves(); }
    }
}

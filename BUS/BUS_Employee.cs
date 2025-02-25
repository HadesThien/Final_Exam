using DAL;
using DTO;
using System;
using System.Data;

namespace BUS {
    public class BUS_Employee {
        //Propery
        private DAL_Employee employee;

        //Constructor 
        public BUS_Employee(DTO_Employee employee) { this.employee = new DAL_Employee(employee); }
        //Methods
        public DataTable showEmployees() {
            return employee.selectQuery();
        }
        public DataTable showEmployee() {
            return employee.selectSpecificEmployee(employee.getId());
        }
        
        //Getter 
        public string getId() { return employee.getId(); }
        public string getFullname() { return employee.getFullname(); }
        public float getSalarayCoefficient() { return employee.getSalarayCoefficient(); }
        public int getDateOff() { return employee.getDateOff(); }
        public DateTime getDateOfBirth() { return employee.getDateOfBirth(); }
        public string getPhoneNumber() { return employee.getPhoneNumber(); }
        public string getEmail() {  return employee.getEmail(); }
        public DateTime getHireDate() {  return getHireDate(); }
    }
}

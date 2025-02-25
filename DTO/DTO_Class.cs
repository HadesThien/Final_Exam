using System;
using System.Activities.Statements;
using System.Collections.Generic;

namespace DTO {
    public class DTO_Class {
        //Property
        private string classId;
        private string className;
        private int capacity;
        private DateTime dateOpened;
        private DateTime dateClosed;
    
        private DTO_Subject subject;
        private DTO_Period period;
        private DTO_Branch branch;
        private List<DTO_Register> registers;

        //Constructor 
        public DTO_Class(string classId, string className, int capacity, DateTime dateOpened, DateTime dateClosed) {
            this.classId = classId;
            this.className = className;
            this.capacity = capacity;
            this.dateOpened = dateOpened;
            this.dateClosed = dateClosed;
            this.registers = new List<DTO_Register>();
        }
        public DTO_Class() {

        }


        //Methods
        public void addRegister(DTO_Register register) {
            registers.Add(register);
        }
        public void removeRegister(DTO_Register register) {
            registers.Remove(register);
        }

        //Setter
        public void setSubject(DTO_Subject subject) {
            this.subject = subject;
        }
        public void setPeriod(DTO_Period period) {
            this.period = period;
        }
        public void setBranch(DTO_Branch branch) {
            this.branch = branch;
        }
        public void setClassId(string classId) {
            this.classId = classId;
        }
        public void setCapacity(int capacity) {
            this.capacity = capacity;
        }
        public void setDateOpened(DateTime dateOpened) {
            this.dateOpened = dateOpened;
        }
        public void setDateClosed(DateTime dateClosed) {
            this.dateClosed = dateClosed;
        }
        public void setRegisterList(List<DTO_Register> registers) {
            this.registers = registers;
        }

        //Getter
        public string getClassId() {return classId;}
        public string getClassName() { return className; }
        public int getCapacity() { return capacity; }
        public DateTime getDateOpened() { return dateOpened; }
        public DateTime getDateClosed() { return dateClosed; }
        public DTO_Branch getBranch() { return branch; }
        public DTO_Period getPeriod() { return period; }
        public DTO_Subject getSubject() { return subject; }
        public List<DTO_Register> GetRegisters() { return registers; }

    }
}

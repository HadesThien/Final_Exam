using System;

namespace DTO {
    public class DTO_JobDepartment {
        //Property
        private string jobId;
        private string jobDepartment;
        private string name;
        private string description;

        //Constructor
        public DTO_JobDepartment(string jobId, string jobDepartment, string name, string description) {
            this.jobId = jobId;
            this.jobDepartment = jobDepartment;
            this.name = name;
            this.description = description;
        }
        public DTO_JobDepartment() { }

        //Methods
        //Setter
        public void setJobId(string jobId) {  this.jobId=jobId; }
        public void setJobDepartment(string jobDepartment) { this.jobDepartment=jobDepartment; }
        public void setName(string name) {  this.name = name; }
        public void setDescription(string description) { this.description = description; }

        //Getter
        public string getJobId() { return jobId; }
        public string getJobDepartment() { return jobDepartment; }
        public string getName() { return name; }
        public string getDescription() { return description; }

    }
}

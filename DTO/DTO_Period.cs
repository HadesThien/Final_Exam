using System;

namespace DTO {
    public class DTO_Period {
        //Property
        private string periodId;
        private DateTime dateCreated;
        private string semester; 

        //Constructor
        public DTO_Period(string periodId, DateTime dateCreated,string semester) {
            this.periodId = periodId;
            this.dateCreated = dateCreated;
            this.semester = semester;
        }
        public DTO_Period() {

        }

        //Methods
        //Setter
        public void setPeriodId(string periodId) {
            this.periodId = periodId;
        }
        public void setDateCreated(DateTime dateCreated) {
            this.dateCreated = dateCreated;
        }
        public void setSemester(string semester) {
            this.semester = semester;
        }

        //Getter
        public string getPeriodId() {
            return this.periodId;
        }
        public DateTime getDateCreated() {
            return this.dateCreated;
        }
        public string getSemester() {
            return this.semester;
        }

    }
}

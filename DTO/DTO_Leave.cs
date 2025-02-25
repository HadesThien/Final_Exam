using System;
using System.Collections.Generic;

namespace DTO {
    public class DTO_Leave {
        private string leaveId;
        private DateTime date;
        private string reason;

        public DTO_Leave(string leaveId, DateTime date, string reason) {
            this.leaveId = leaveId;
            this.date = date;
            this.reason = reason;
        }
        public DTO_Leave() { }

        //Methods
        //Setter
        public void setLeaveId(string leaveId) { this.leaveId = leaveId; }
        public void setDate(DateTime date) { this.date = date; }
        public void setReason(string reason) { this.reason = reason; }
        //Getter
        public string getLeaveId() { return leaveId; }
        public DateTime getDate() { return date; }
        public string getReason() { return reason; }
    }
}

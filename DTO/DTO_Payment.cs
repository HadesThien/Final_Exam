using System;

namespace DTO {
    public class DTO_Payment {
        //Property
        private string paymentId;
        private string name;
        private int price;
        private string status;
        private DateTime datePaid;
        private string subject;
        private DateTime dateCreated;
        private string note;

        private DTO_Period period;
        private DTO_Student student;

        //Constructor
        public DTO_Payment(string paymentId, string name, int price, string status, DateTime datePaid, string subject, DateTime dateCreated, string note) {
            this.paymentId = paymentId;
            this.name = name;
            this.price = price;
            this.status = status;
            this.datePaid = datePaid;
            this.subject = subject;
            this.dateCreated = dateCreated;
            this.note = note;
        }
        public DTO_Payment() {

        }
        //Methods  
        //Setter
        public void setStudent(DTO_Student student) {
            this.student = student;
        }

        public void setPeriod(DTO_Period period) { 
            this.period = period; 
        }
        public void setPayment(string paymentId) {
            this.paymentId = paymentId;
        }
        public void setPaymentId(string paymentId) {
            this.paymentId = paymentId;
        }
        public void setName(string name) { this.name = name; }
        public void setPrice(int price) { this.price = price; }
        public void setStatus(string status) { this.status = status; }
        public void setDatePaid(DateTime datePaid) { this.datePaid=datePaid; }
        public void setSubject(string  subject) { this.subject = subject; } 
        public void setDateCreated(DateTime dateCreated) {  this.dateCreated = dateCreated; }
        public void setNote(string note) { this.note = note; }




        //Getter
        public string getPaymentId() {
            return paymentId;
        }
        public string getName() {
            return name;
        }
        public int getPrice() {
            return price;
        }
        public string getStatus() {
            return status;
        }
        public DateTime getDatePaid() {
            return datePaid;
        }
        public string getSubject() {
            return subject;
        }
        public DateTime getDateCreated() {
            return dateCreated;
        }
        public string getNote() {
            return note;
        }
    }
}

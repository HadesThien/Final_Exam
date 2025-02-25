using System;

namespace DTO {
    public class DTO_DetailItem {
        //Property
        private string detailItemId;
        private int quantity;
        private DateTime dateImport;
        private string status;
        private string note;
        private DTO_Item item;
        private DTO_Repository repository;
        //Constructor 
        public DTO_DetailItem(string detailItemId, int quantity,DateTime dateImport, string status, string note,DTO_Item item, DTO_Repository repository) {
            this.detailItemId = detailItemId;
            this.quantity = quantity;
            this.dateImport = dateImport;   
            this.status = status;
            this.note = note;
            this.item = item;
            this.repository = repository;
        }
        public DTO_DetailItem() {

        }
        //Methods
        //Setter
        public void setDetailItemid(string detailItemId) { this.detailItemId = detailItemId; }
        public void setQuantity(int quantity) { this.quantity = quantity; } 
        public void setDateImport(DateTime dateImport) { this.dateImport = dateImport; }    
        public void setStatus(string status) { this.status = status; }  
        public void setNote(string note ) { this.note = note; }
        public void setItem(DTO_Item item) { this.item = item; }
        public void setRepository(DTO_Repository repository) { this.repository = repository; }

        //Getter
        public string getDetailItemId() { return detailItemId; }
        public int getQuantity() { return quantity; }
        public DateTime getDateImport() { return dateImport; }
        public string getStatus() { return status; }
        public string getNote() { return note; }
        public DTO_Item getItem() { return item; }
        public DTO_Repository getRepository() { return repository; }

    }
}

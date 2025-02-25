using System;

namespace DTO {
    public class DTO_Item {
        //Property
        private string itemId;
        private string name;
        private string type;
        private string unit;
        private string company;
        private string description;

        //Constructor
        public DTO_Item(string itemId, string name, string type,string unit, string company, string description) {
            this.itemId = itemId;
            this.name = name;
            this.type = type;
            this.unit = unit;
            this.company = company;
            this.description = description;
        }
        public DTO_Item(string name) {
            this.name=name;
        }
        public DTO_Item() { }

        //Methods
        //Setter
        public void setItemId(string itemId) {  this.itemId = itemId; }
        public void setName(string name) { this.name = name; }
        public void setCompany(string company) { this.company = company; }
        public void setType(string type) { this.type = type; }
        public void setDescription(string description) { this.description = description; }
        public void setUnit(string  unit) { this.unit = unit; } 

        //Getter
        public string getItemId() { return itemId; }
        public string getName() { return name; }
        public string getCompany() { return company; }
        public string getDescription() { return description; }
        public string getType() { return type; }
        public string getUnit() {  return unit; }

    }
}

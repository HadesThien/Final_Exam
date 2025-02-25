using System;
using System.Collections.Generic;

namespace DTO {

    public class DTO_Branch {
        //Property
        private string branchId;
        private string branchName;
        private string address;
        private DTO_Repository repository;
        private List<DTO_Class> classes; 

        //Constructor
        public DTO_Branch(string branchId, string branchName, string address) {
            this.branchId = branchId;
            this.branchName = branchName;
            this.address = address;
            this.repository = new DTO_Repository();
            this.repository.setRepositoryName(branchName);
            this.classes = new List<DTO_Class>();
        }
        public DTO_Branch() {

        }

        //Methods
        public void addItems(List<DTO_Item> items) {
            this.repository.setItems(items);
        }
        public void addClass(DTO_Class classObj) {
            this.classes.Add(classObj);
        }
        public void removeClass(DTO_Class classObj) {
            this.classes.Remove(classObj);  
        }
        //Setter
        public void setBranchId(string branchId) { this.branchId = branchId; }
        public void setBranchName(string branchName) {this.branchName = branchName;}
        public void setAddress(string address) { this.address = address;}
        //Getter
        public string getBranchId() {  return this.branchId;}
        public string getBranchName() {  return this.branchName;}
        public string getAddress() { return this.address;}

    }
}

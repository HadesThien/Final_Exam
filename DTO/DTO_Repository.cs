using System;
using System.Collections.Generic;

namespace DTO {
    public class DTO_Repository {
        //Property
        private string repositoryId;
        private string repositoryName;
        private List<DTO_Item> items;

        //Constructor 
        public DTO_Repository(string repositoryId,  string repositoryName) {
            this.repositoryId = repositoryId;
            this.repositoryName = repositoryName;
            items = new List<DTO_Item>();
        }
        public DTO_Repository(string repositoryId) {
            this.repositoryId= repositoryId;
        }
        public DTO_Repository() {

        }


        //Methods
        public void addItem(DTO_Item item) {
            items.Add(item);
        }
        public void removeItem(DTO_Item item) {
            items.Remove(item);
        }
        //Setter 
        public void setRepositoryName(string repositoryName) {
            this.repositoryName = repositoryName;
        }
        public void setRepositoryId(string repositoryId) {
            this.repositoryId = repositoryId;
        }
        public void setItems(List<DTO_Item> items) {
            this.items = items;
        }

        //Getter
        public string getRepositoryId() {
            return repositoryId;
        }
        public string getRepositoryName() {
            return repositoryName;
        }
        public List<DTO_Item> getItems() { return items; }

    }
}

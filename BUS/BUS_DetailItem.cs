using DAL;
using DTO;
using System;
using System.Data;
using System.Xml;

namespace BUS {
    public class BUS_DetailItem {
        
        //-----------------------------------Property-----------------------------------\\
        private DAL_DetailItem detailItem;
        private DTO_DetailItem detailItemObj;
        

        //-----------------------------------Constructor-----------------------------------\\

        //To show specific something
        public BUS_DetailItem(DTO_DetailItem detailItem) {
            this.detailItem = new DAL_DetailItem(detailItem);
            this.detailItemObj = detailItem;
        }
       
        // Used to call some select database query function 
        public BUS_DetailItem() { this.detailItem = new DAL_DetailItem(); }



        //-----------------------------------Methods about handle logic business-----------------------------------\\

        //Used to generate Id for Detail Item
        public string generateId() {
            string id = "DI";
            DataTable dt = detailItem.countQuery();
            int number = int.Parse(dt.Rows[0][0].ToString().Substring(id.Length)) + 1;
            int n = 1;
            int numPart = 10000000;
            while (n != numPart) {
                n *= 10;
                if (number < n) {
                    for (int i = 1; i <= (numPart/n); i*=10) {
                        id += "0";
                    }
                    id += number;
                    break;
                }
            }
            return id;
        }



        //-----------------------------------Call data from database by query-----------------------------------\\

        //When create a new item, then store it in somewhere repository
        public void storeItem() {
            detailItem.createQuery();
        }

        //Used to remove all detail item there is 0 item
        public void clear() {
            detailItem.clearQuery();
        }

        //To remove detail item
        public void removeDetailItem() {
            detailItem.removeDetailItemQuery();
        }

        //To export an amount of items
        public void exportDetailItem() {
            //To decrease an amount of item 
            detailItem.exportDetailItemQuery();
            //To create a detail item at "Xuất kho"

            detailItemObj.setStatus("Xuất kho");
            detailItemObj.setDetailItemid(generateId());
            detailItemObj.setRepository(new DTO_Repository("REP011","Xuất kho"));
            new DAL_DetailItem(detailItemObj).createQuery();
        }

        //To change an amount of items from old repository to new one 
        public void moveItemTo(int quantity, string repositoryName) {

            //Set quantity must-decrease and increase in a new repository
            detailItemObj.setQuantity(quantity);
            //Decrease amount of item at old repository
            new DAL_DetailItem(detailItemObj).decreaseQuery();

            //Set a new repository
            DTO_Repository newRepository = new DTO_Repository("",repositoryName);
            //Find repository id and set id by name 
            newRepository.setRepositoryId(new BUS_Repository(newRepository).getRepoId()); 
            detailItemObj.setRepository(newRepository);

            //Set a new DetailItem with a new repository
            DAL_DetailItem newDetailItem = new DAL_DetailItem(detailItemObj);

            //Check existance of that item at new repository
            DataTable dt = newDetailItem.checkExistQuery();
            if (dt.Rows.Count != 0) { // if item exists 
                newDetailItem.moveItemQuery(); //Move item from old repository to new one 
            }
            else {
                string newDetailItemId = generateId();
                detailItemObj.setDetailItemid(newDetailItemId);
                // Else then create a new item and detail item in new repository
                new DAL_DetailItem(detailItemObj).createQuery();
            }
        }
        
        //To decrease amount of items in detail item
        public void decreaseItem() {
            detailItem.decreaseQuery();
        }

        //Used to update note of detail item 
        public void updateNoteItem() {
            detailItem.updateNoteQuery();
        }

        //Used to increase amount of items 
        public void increaseItem() {
            detailItem.increaseQuery();
        }

        //Used to remove Item at all repository
        public void removeItem() {
            detailItem.removeItemQuery();
        }

        //Used to clear all exported item 
        public void clearExportedItem() {
            detailItem.clearExportedItemQuery();
        }

        //Used to update information of item
        public void updateItem() {
            detailItem.updateItemQuery();
        }

        //Used to select all detiail item in database 
        public DataTable showTable() {
            return detailItem.selectForTable();
        }

        //Used to get all properties of detail item, item and repository
        public DataTable showAll() {
            return detailItem.selectAll();
        }        

        //Search 
        public DataTable searchItem() {
            return detailItem.searchItemQuery();
        }

        //To show all items of a specific repository
        public DataTable showItemsInRepository() { 
            return detailItem.showItemsInRepository();
        }

             
    }
}

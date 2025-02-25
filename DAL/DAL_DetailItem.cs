using DTO;
using System;
using System.Data;
using System.Security.Policy;

namespace DAL {
    public class DAL_DetailItem {
        //Property
        private DTO_DetailItem detailItem;
        private DTO_Repository repository;
        private DTO_Item item;
        private string header;

        //Constructor
        //This constructor is used to show information of detail item
        public DAL_DetailItem(DTO_DetailItem detailItem) {
            this.detailItem = detailItem;
            this.repository = detailItem.getRepository();
            this.item =detailItem.getItem();
            this.header= $"SELECT d.detail_item_id, i.name, i.type, i.unit, d.status ,r.name , d.quantity, d.date_import, d.note FROM Detail_Item d ";
        }

        public DAL_DetailItem() {
            this.header= $"SELECT d.detail_item_id, i.name, i.type, i.unit, d.status ,r.name , d.quantity, d.date_import, d.note FROM Detail_Item d ";
        }
       
        
        
        //Methods

        //Show all items in this repository
        public DataTable showItemsInRepository() {
            string query = header + 
                $"Inner Join Item i on i.item_id = d.item_id " +
                $"Inner Join Repository r on r.repository_id = d.repository_id " +
                $"Where r.name = N'{repository.getRepositoryName()}'";
            return Connection.selectQuery(query);
        }

        //Show one or all items
        public DataTable selectForTable()
        {
            string query = header + 
                            $"JOIN Item i ON i.item_id = d.item_id " +
                            $"JOIN Repository r ON r.repository_id = d.repository_id";
            return Connection.selectQuery(query);
        }
        
        //Used to search item in detail item table
        public DataTable searchItemQuery() {
            string query = header + 
                $"Inner Join Item i on i.item_id = d.item_id " +
                $"Inner Join Repository r on r.repository_id = d.repository_id " +
                $"Where i.name like N'%{item.getName()}%' and r.name  != N'Xuất kho'";
            return Connection.selectQuery(query);
        }
        
        //Used to select all properties of detail item, item and repository
        public DataTable selectAll() {
            string query = $"select * from Detail_Item d " +
                $"JOIN Item i on i.item_id = d.item_id " +
                $"JOIN Repository r ON r.repository_id = d.repository_id " +
                $"WHERE d.detail_item_id = '{detailItem.getDetailItemId()}' and r.name != N'Xuất kho'";
            return Connection.selectQuery(query);
        }
        
        //Used to find to largest detail item id 
        public DataTable countQuery() {
            string query = $"SELECT TOP 1 detail_item_id from Detail_Item Order by detail_item_id desc";
            return Connection.selectQuery(query);
        }

        // Used to check if item exists then return data of detail item 
        public DataTable checkExistQuery() {
            string query = header + 
                $"INNER JOIN Item i ON i.item_id = d.item_id " +
                $"INNER JOIN Repository r ON r.repository_id = d.repository_id " +
                $"WHERE i.item_id = '{item.getItemId()}' AND r.repository_id = N'{repository.getRepositoryId()}';";
            return Connection.selectQuery(query);
        }

        //Used to create a new detail item
        public void createQuery() {
            string query = $"INSERT INTO Detail_Item(detail_item_id, quantity,date_import, status, item_id, repository_id) " +
                $"VALUES ('{detailItem.getDetailItemId()}',{detailItem.getQuantity()},'{DateTime.Now.ToString("yyyy-MM-dd")}', N'Mới','{item.getItemId()}','{repository.getRepositoryId()}' );";
            Console.WriteLine(query);
            Connection.actionQuery(query);
        }

        //Used to remove detail Item 
        public void removeDetailItemQuery() {
            string query = $"DELETE FROM DETAIL_ITEM WHERE Detail_Item.detail_item_id = '{detailItem.getDetailItemId()}';";
            Connection.actionQuery(query);
        }

        //Used to remove Item at all repository
        public void removeItemQuery() {
            //Delete all item at any reposittory
            string query =  $"DELETE FROM DETAIL_ITEM " +
                            $"WHERE item_id = N'{item.getItemId()}';";
            Connection.actionQuery(query);
            //Delete item
            new DAL_Item(item).deleteItemQuery();
        }

        //Used to clear all exported item
        public void clearExportedItemQuery() {
            string query = $"DELETE FROM Detail_Item Where repository_id = 'REP011'; ";
            Connection.actionQuery(query);
        }
        
        //Change status to "Xuất kho" 
        public void exportDetailItemQuery() {
            string query = $"UPDATE Detail_Item " +
                $"SET quantity -= {detailItem.getQuantity()} " +
                $"Where detail_item_id = '{detailItem.getDetailItemId()}';";
            Connection.actionQuery(query);
        }

        //Used to update quantity of item where item's at the same name of repository
        public void moveItemQuery() {
            string query = $"UPDATE Detail_Item " +
                $"SET quantity += {detailItem.getQuantity()} " +
                $"FROM Detail_Item " +
                $"JOIN Repository ON Detail_Item.repository_id = repository.repository_id " + 
                $"JOIN Item ON Detail_Item.item_id = item.item_id " + 
                $"WHERE repository.repository_id = '{repository.getRepositoryId()}' and item.item_id = '{item.getItemId()}'";
            Connection.actionQuery(query);
        }

        //Used to decrease amount of item
        public void decreaseQuery() {
            string query = $"UPDATE Detail_Item " +
                $"SET quantity -= {detailItem.getQuantity()} " +
                $"Where detail_item_id = '{detailItem.getDetailItemId()}'";
            Connection.actionQuery(query);
        }

        //Used to increase amount of items 
        public void increaseQuery() {
            string query = $"UPDATE Detail_Item " +
                $"SET quantity += {detailItem.getQuantity()} " +
                $"Where detail_item_id = '{detailItem.getDetailItemId()}'";
            Connection.actionQuery(query);
        }
        
        //Used to update note of detail item 
        public void updateNoteQuery() {
            string query = $"UPDATE Detail_Item " +
                $"SET note = N'{detailItem.getNote()}' " +
                $"Where detail_item_id = '{detailItem.getDetailItemId()}'";
            Connection.actionQuery(query);
        }

        //Used to clear all detail item with 0 item
        public void clearQuery() {
            string query = "DELETE FROM Detail_Item WHERE Detail_Item.quantity = 0;";
            Connection.actionQuery(query);
        }
    
        //Used to update information of item
        public void updateItemQuery() {
            //Update detail item
            string query = $"UPDATE Detail_Item " +
                $"SET Detail_Item.status = N'{detailItem.getStatus()}'";
            Connection.actionQuery (query);
            //Update item
            new DAL_Item(item).updateItemQuery();
        }
    }
}

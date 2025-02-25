using DTO;
using System.Data;

namespace DAL {
    public class DAL_Item {
        //Property 
        private DTO_Item item;

        //Constructor

        public DAL_Item(DTO_Item item) { this.item = item;  }

        //Methods

        // Create an item 
        public void addQuery() {
            string query = $"INSERT INTO Item (item_id, name, type, unit, company, description) " +
                $"VALUES ('{item.getItemId()}', N'{item.getName()}', N'{item.getType()}', N'{item.getUnit()}', N'{item.getCompany()}', N'{item.getDescription()}')";
            Connection.actionQuery(query);
        }

        //Used to get Top of item id
        public DataTable getTopIdQuery() {
            string query = $"Select TOP 1 item_id from Item order by item_id desc"; 
            return Connection.selectQuery(query);
        }

        //Used to update information of item
        public void updateItemQuery() {
            string query = $"UPDATE Item " +
                $"SET name = N'{item.getName()}', type = N'{item.getType()}' , unit = N'{item.getUnit()}' , description = N'{item.getDescription()}', company = N'{item.getCompany()}' " +
                $"WHERE item.item_id = '{item.getItemId()}'";
            Connection.actionQuery(query) ;
        }
        
        //Used to delete item 
        public void deleteItemQuery() {
            string query = $"DELETE FROM Item WHERE Item.item_id = N'{item.getItemId()}' ";
            Connection.actionQuery(query);
        }
    }
}

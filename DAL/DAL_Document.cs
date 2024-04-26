using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Document
    {
        private DTO_Document doc;

        public DAL_Document(string id, int inventory, string name, DateTime dateCreated, DateTime dateUpdate)
        {
            doc = new DTO_Document(id, inventory, name, dateCreated, dateUpdate);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Document VALUES(" + doc.Inventory + ", '" + doc.DocumentId + "', '" + doc.Name + "', '" + doc.DateCreated.ToString() + "', '" + doc.DateUpdated.ToString() + "')";
            Connection.actionQuery(query);
        }      

        public void updateQuery()
        {
            string query = "UPDATE Document SET inventory = " + doc.Inventory + ", name = '" + doc.Name + "', dateCreated = '" + doc.DateCreated.ToString() + "', dateUpdated = '" + doc.DateUpdated.ToString() + "' WHERE handoutId = '" + doc.DocumentId + "'";
            Connection.actionQuery(query);
        }   

        public void deleteQuery()
        {
            string query = "DELETE FROM Document WHERE handoutId = '" + doc.DocumentId + "'";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM Document";
            return Connection.selectQuery(s);
        }
    }
}

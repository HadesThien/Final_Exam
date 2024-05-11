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

        public DAL_Document(string id, int inventory, string name, DateTime dateCreated, DateTime dateUpdate, int price)
        {
            doc = new DTO_Document(id, inventory, name, dateCreated, dateUpdate, price);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Document VALUES(" + doc.Inventory + ", '" + doc.DocumentId + "', N'" + doc.Name + "', '" + doc.DateCreated.ToString("yyyy/MM/dd") + "', '" + doc.DateUpdated.ToString("yyyy/MM/dd") + "', " + doc.Price + ")";
            Connection.actionQuery(query);
        }      

        public void updateQuery()
        {
            string query = "UPDATE Document SET inventory = " + doc.Inventory + ", name = N'" + doc.Name + "', dateUpdated = '" + doc.DateUpdated.ToString("yyyy/MM/dd") + "', price = " + doc.Price + " WHERE handoutId = '" + doc.DocumentId + "'";
            Connection.actionQuery(query);
        }   

        public void deleteQuery()
        {
            string query = "DELETE FROM Document WHERE handoutId = '" + doc.DocumentId + "'";
            Connection.actionQuery(query);
        }

        public DataTable detailedSelectQuery()
        {
            string s = "SELECT handoutId, name, inventory, price, dateUpdated, dateCreated FROM Document";
            return Connection.selectQuery(s);
        }

        public DataTable findDocument()
        {
            string s = "SELECT name, price FROM Document WHERE handoutId = '" + doc.DocumentId + "'";
            return Connection.selectQuery(s);
        }

        public DataTable getLatestId()
        {
            string s = "SELECT TOP 1 handoutId FROM Document ORDER BY handoutId DESC";
            return Connection.selectQuery(s);
        }

        public DataTable searchDocument()
        {
            string s = $"SELECT handoutId, name, inventory, price, dateUpdated, dateCreated FROM Document WHERE name LIKE N'%{doc.Name}%'";
            return Connection.selectQuery(s);

        }

        public DataTable getNames()
        {
            string s = "SELECT name FROM Document";
            return Connection.selectQuery(s);
        }

        public DataTable getDocumentFromName()
        {
            string s = "SELECT * FROM Document WHERE name = N'" + doc.Name + "'";
            return Connection.selectQuery(s);
        }

        public void updateAfterBuying()
        {
            string s = $"UPDATE Document SET inventory = inventory - 1 WHERE name = N'{doc.Name}'";
            Connection.actionQuery(s);
        }
    }
}

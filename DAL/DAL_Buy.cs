using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Buy
    {
        private DTO_Buy buy;

        public DAL_Buy(string s, string d, DateTime buyingDate, int n, int p, string status, string month, string note, string id) {
            buy = new DTO_Buy(s, d, buyingDate, n, p, status, month, note, id);
        }
        
        public void addQuery()
        { 
            string query = "INSERT INTO Buy VALUES('" + buy.BuyingDate.ToString("d") + "', " + buy.Number + "', " + buy.Price + "', '" + buy.Status + "', '" + buy.Month + "', '" + buy.Note + "', '" + buy.Id + "', '" + buy.StudentId + "', '" + buy.DocumentId + "')";
            Connection.actionQuery(query);
        }
        
        public void deleteQuery()
        {
            string query = "DELETE FROM Buy WHERE buyId = '" + buy.Id + "', studentId = '" + buy.StudentId + "', handoutId = '" + buy.DocumentId + "'";
            Connection.actionQuery(query);
        }
        public DataTable selectQuery() {
            string s = "Select * from Payment";
            return Connection.selectQuery(s);
        }

        public DataTable showBuys() {
            string s = "Select b.buyId, d.name, b.period, b.note, b.dateCreated from buy b Join Document d On d.handoutId = b.handoutId;";
            return Connection.selectQuery(s);
        }

        public DataTable getLatestId()
        {
            string s = "SELECT TOP 1 buyId FROM Buy ORDER BY buyId DESC";
            return Connection.selectQuery(s);
        }

    }
}

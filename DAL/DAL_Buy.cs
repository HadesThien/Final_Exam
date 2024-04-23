using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    internal class DAL_Buy
    {

        private DTO_Buy buy;
        public DAL_Buy(DTO_Student s, DTO_Document d, DateTime buyingDate, int n, int p, string status, string month, string note) {
            buy = new DTO_Buy(s, d, buyingDate, n, p, status, month, note);
        }
        
        public void addQuery()
        { 
            string query = "INSERT INTO Buy VALUES('" + buy.BuyingDate.ToString() + "', " + buy.Number + "', " + buy.Price + "', '" + buy.Status + "', '" + buy.Month + "', '" + buy.Note + "', '" + buy.Student.Id + "', '" + buy.Document.DocumentId + "')";
            Connection.actionQuery(query);
        }
        
        public void deleteQuery()
        {
            string query = "DELETE * FROM Buy WHERE studentId = '" + buy.Student.Id + "', handoutId = '" + buy.Document.DocumentId + "'";
            Connection.actionQuery(query);
        }

    }
}

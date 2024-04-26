using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Payment
    {
        private DTO_Payment payment;
        public DAL_Payment( string paymentId, DateTime dateCreated, int month, string status, string note, float promotion, int n_session, string studentId)
        {
            payment = new DTO_Payment(paymentId, dateCreated, month, status, note, promotion, n_session, studentId);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Payment VALUES('" + payment.DateCreated + "', " + payment.Month + ", '" + payment.Status + "', '" + payment.Note + "', " + payment.Promotion + ", " + payment.Number_Of_Session + ", '" + payment.PaymentId + "', '" + payment.StudentId + "')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE Payment SET status = '" + payment.Status + "', note = '" + payment.Note + "' WHERE paymentId = '" + payment.PaymentId + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM Payment WHERE paymentId = '" + payment.PaymentId + "'";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM Payment";
            return Connection.selectQuery(s);
        }
    }
}

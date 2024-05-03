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
        public DAL_Payment( string paymentId, DateTime dateCreated, DateTime period, string status, string note, float promotion, int n_session, string studentId,string classId)
        {
            payment = new DTO_Payment(paymentId, dateCreated,period, status, note, promotion, n_session, studentId,classId);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Payment VALUES('" + payment.DateCreated + "', " + payment.Period.ToString("MM/yyyy") + ", '" + payment.Status + "', '" + payment.Note + "', " + payment.Promotion + ", " + payment.Number_Of_Session + ", '" + payment.PaymentId + "', '" + payment.StudentId + "', " + payment.ClassId+ "')";
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
            string s = $"SELECT p.paymentId,pe.name AS TenHocSinh,CONCAT(c.subject, ' ', c.grade, '.', c.shift) AS TenLop,c.Price, FORMAT(p.period, 'MM/yyyy') AS Period,p.status,p.promotion,p.numberOfSession,p.dateCreated\r\n" +
                $"FROM \r\n    Payment p\r\n" +
                $"JOIN Register r ON r.studentId = p.studentId and r.classId = p.classId\r\n" +
                $"JOIN Student s ON s.studentId = r.studentId\r\n" +
                $"JOIN Person pe ON s.studentId = pe.Id\r\n" +
                $"JOIN Class c ON c.classId = r.classId\r\n";
               return Connection.selectQuery(s);
        }
        public DataTable showPayments() {
            string s ="Select p.paymentId, ConCat(c.subject,' ', c.grade, '.' , c.shift) as name, p.period,p.note,p.dateCreated From Payment p Join Register r On p.StudentId = r.registerId Join Class c On r.classId = c.ClassId;";
            return Connection.selectQuery(s);
        }

        public DataTable getLatestId()
        {
            string s = "SELECT TOP 1 paymentId FROM Payment ORDER BY paymentId DESC";
            return Connection.selectQuery(s);
        }
    }
}

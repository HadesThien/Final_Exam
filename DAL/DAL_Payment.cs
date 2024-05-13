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
        public DAL_Payment(string paymentId, DateTime dateCreated, DateTime period, string status, string note, float promotion, int n_session, string studentId, string classId)
        {
            payment = new DTO_Payment(paymentId, dateCreated, period, status, note, promotion, n_session, studentId, classId);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Payment VALUES('" + payment.DateCreated.ToString("yyyy/MM/dd") + "', '" + payment.Period.ToString("yyyy/MM/dd") + "', N'" + payment.Status + "', N'" + payment.Note + "', " + payment.Promotion + ", " + payment.Number_Of_Session + ", '" + payment.PaymentId + "', '" + payment.StudentId + "', '" + payment.ClassId + "')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE Payment SET period = '" + payment.Period.ToString("yyyy/MM/dd") + "', status = N'" + payment.Status + "', note = N'" + payment.Note + "' WHERE paymentId = '" + payment.PaymentId + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM Payment WHERE paymentId = '" + payment.PaymentId + "'";
            Connection.actionQuery(query);
        }

        public DataTable selectPaidQuery()
        {
            string s = $"SELECT \r\n    p.paymentId as [Mã thanh toán],\r\n    pe.name AS [Tên học sinh],\r\n    c.subject + ' ' + cast(c.grade as varchar) + '.' + c.shift AS [Tên lớp],c.Price as [Học phí],\r\n    RIGHT(CONVERT(VARCHAR(10), p.period, 103), 7) AS [Kỳ],\r\n    p.status as [Tình trạng],\r\n    p.numberOfSession as [Số buổi học],\r\n    p.dateCreated as [Ngày tạo]\r\n" +
                $"FROM \r\n    Payment p\r\n" +
                $"JOIN \r\n    Student s ON p.studentId = s.studentId\r\n" +
                $"JOIN \r\n    Person pe ON s.studentId = pe.Id\r\n" +
                $"JOIN \r\n    Register r ON s.studentId = r.studentId AND r.classId = p.classId\r\n" +
                $"JOIN \r\n    Class c ON c.classId = r.classId " +
                $"WHERE p.status = N'Thanh toán'";
            return Connection.selectQuery(s);
        }
        public DataTable selectRegisteredQuery()
        {
            string s = $"SELECT \r\n    p.paymentId as [Mã thanh toán],\r\n    pe.name AS [Tên học sinh],\r\n    c.subject + ' ' + cast(c.grade as varchar) + '.' + c.shift AS [Tên lớp],c.Price as [Học phí],\r\n    RIGHT(CONVERT(VARCHAR(10), p.period, 103), 7) AS [Kỳ],\r\n    p.status as [Tình trạng],\r\n    p.numberOfSession as [Số buổi học],\r\n    p.dateCreated as [Ngày tạo]\r\n" +
                $"FROM \r\n    Payment p\r\n" +
                $"JOIN \r\n    Student s ON p.studentId = s.studentId\r\n" +
                $"JOIN \r\n    Person pe ON s.studentId = pe.Id\r\n" +
                $"JOIN \r\n    Register r ON s.studentId = r.studentId AND r.classId = p.classId\r\n" +
                $"JOIN \r\n    Class c ON c.classId = r.classId " +
                $"WHERE p.status = N'Đăng ký'";
            return Connection.selectQuery(s);
        }
        public DataTable selectQuery()
        {
            string s = $"SELECT \r\n    p.paymentId as [Mã thanh toán],\r\n    pe.name AS [Tên học sinh],\r\n    c.subject + ' ' + cast(c.grade as varchar) + '.' + c.shift AS [Tên lớp],c.Price as [Học phí],\r\n    RIGHT(CONVERT(VARCHAR(10), p.period, 103), 7) AS [Kỳ],\r\n    p.status as [Tình trạng],\r\n    p.numberOfSession as [Số buổi học],\r\n    p.dateCreated as [Ngày tạo]\r\n" +
                $"FROM \r\n    Payment p\r\n" +
                $"JOIN \r\n    Student s ON p.studentId = s.studentId\r\n" +
                $"JOIN \r\n    Person pe ON s.studentId = pe.Id\r\n" +
                $"JOIN \r\n    Register r ON s.studentId = r.studentId AND r.classId = p.classId\r\n" +
                $"JOIN \r\n    Class c ON c.classId = r.classId";
            return Connection.selectQuery(s);
        }

        public DataTable getLatestId()
        {
            string s = "SELECT TOP 1 paymentId FROM Payment ORDER BY paymentId DESC";
            return Connection.selectQuery(s);
        }

        public void deletePaymentsOfAStudent()
        {
            string s = "DELETE FROM Payment WHERE studentId = '" + payment.StudentId + "'";
            Connection.actionQuery(s);
        }

        public DataTable selectPaymentOfAPeriod()
        {
            string s = "SELECT paymentId " +
                       "FROM Payment " +
                      $"WHERE studentId = '{payment.StudentId}' AND classId = '{payment.ClassId}' AND (MONTH(period) = MONTH('{payment.Period.ToString("yyyy/MM/dd")}') AND YEAR(period) = YEAR('{payment.Period.ToString("yyyy/MM/dd")}')) AND status = N'Thanh toán'";
            return Connection.selectQuery(s);
        }
        public DataTable selectPaymentOfAPeriod1()
        {
            string s = "SELECT paymentId " +
                       "FROM Payment " +
                      $"WHERE studentId = '{payment.StudentId}' AND classId = '{payment.ClassId}' AND (MONTH(period) = MONTH('{payment.Period.ToString("yyyy/MM/dd")}') AND YEAR(period) = YEAR('{payment.Period.ToString("yyyy/MM/dd")}')) AND status = N'Đăng ký'";
            return Connection.selectQuery(s);
        }

        public DataTable existsRegisteredPayment()
        {
            string s = "SELECT period " +
                       "FROM Payment " +
                      $"WHERE studentId = '{payment.StudentId}' AND classId = '{payment.ClassId}' AND status = N'Đăng ký'";
            return Connection.selectQuery(s);
        }

        public DataTable selectPaymentId()
        {
            string s = "SELECT paymentId " +
                       "FROM Payment " +
                       $"WHERE studentId = '{payment.StudentId}' AND (MONTH(period) = MONTH('{payment.Period.ToString("yyyy/MM/dd")}') AND YEAR(period) = YEAR('{payment.Period.ToString("yyyy/MM/dd")}')) AND classId = '{payment.ClassId}'";
            return Connection.selectQuery(s);
        }

        public DataTable selectPayment()
        {
            string s = $"SELECT * FROM Payment WHERE paymentId = '{payment.PaymentId}'";
            return Connection.selectQuery(s);
        }

        public DataTable selectRegisteredClasses()
        {
            string s = $"SELECT DISTINCT classId\r\nFROM Payment\r\nWHERE studentId = '{payment.StudentId}' AND status = N'Đăng ký'";
            return Connection.selectQuery(s);
        }

        public DataTable selectStudentId()
        {
            string s = $"SELECT studentId FROM Payment WHERE paymentId = '{payment.PaymentId}'";
            return Connection.selectQuery(s);
        }
        public DataTable select5NewPayment() {
            // Viet Code o day 
            string s = $"SELECT \r\n TOP 5   p.paymentId as [Mã thanh toán],\r\n    pe.name AS [Tên học sinh],\r\n    c.subject + ' ' + cast(c.grade as varchar) + '.' + c.shift AS [Tên lớp],c.Price as [Học phí],\r\n    RIGHT(CONVERT(VARCHAR(10), p.period, 103), 7) AS [Kỳ],\r\n    p.status as [Tình trạng],\r\n    p.numberOfSession as [Số buổi học],\r\n    p.dateCreated as [Ngày tạo]\r\n" +
                $"FROM \r\n    Payment p\r\n" +
                $"JOIN \r\n    Student s ON p.studentId = s.studentId\r\n" +
                $"JOIN \r\n    Person pe ON s.studentId = pe.Id\r\n" +
                $"JOIN \r\n    Register r ON s.studentId = r.studentId AND r.classId = p.classId\r\n" +
                $"JOIN \r\n    Class c ON c.classId = r.classId";

            return Connection.selectQuery(s);
        }
    }
}
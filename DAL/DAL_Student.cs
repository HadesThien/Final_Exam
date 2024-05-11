using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Student
    {
        private DTO_Student student;

        public DAL_Student(string id, string name, string gender, DateTime dob, string numberPhone, string school, string street, string ward, string district, string city, DateTime dateCreated, string status, string note)
        {
            student = new DTO_Student(id, name, gender, dob, numberPhone, school, street, ward, district, city, dateCreated, status, note);
        }

        public void addQuery()
        {
            string query1 = "INSERT INTO Person VALUES('" + student.Id + "', N'" + student.Name + "', N'" + student.Gender + "', '" + student.Dob.ToString("yyyy/MM/dd") + "', '" + student.NumberPhone + "')";
            string query2 = "INSERT INTO Student VALUES(N'" + student.School + "', N'" + student.Street + "', N'" + student.Ward + "', N'" + student.District + "', N'" + student.City + "', '" + student.DateCreated.ToString("yyyy/MM/dd") + "', N'" + student.Status + "', N'" + student.Note + "', '" + student.Id + "')";
            Connection.actionQuery(query1);
            Connection.actionQuery(query2);
            //string query3 = "";
            //{
            //    for (int i = 0; i < student.Registers.Count; i++)
            //    {
            //        query3 = "INSERT INTO Register VALUES('" + student.Registers[i].AddmissionDay.ToString("d") + "', '" + student.Registers[i].State + "', '" + student.Registers[i].Student.Id + "', '" + student.Registers[i].Class.ClassId + "')";
            //        Connection.actionQuery(query3);
            //    }
            //}
            //{
            //    for (int i = 0; i < student.Payments.Count; i++)
            //    {
            //        query3 = "INSERT INTO Payment VALUES('" + student.Payments[i].DateCreated + "', " + student.Payments[i].Month + ", N'" + student.Payments[i].Status + "', N'" + student.Payments[i].Note + "', " + student.Payments[i].Promotion + ", " + student.Payments[i].Number_Of_Session + ", '" + student.Payments[i].PaymentId + "', '" + student.Id + "')";
            //        Connection.actionQuery(query3);
            //    }
            //}
            //{
            //    for (int i = 0; i < student.Buys.Count; i++)
            //    {
            //        query3 = "INSERT INTO Buy VALUES('" + student.Buys[i].BuyingDate.ToString("d") + "', " + student.Buys[i].Number + "', " + student.Buys[i].Price + "', '" + student.Buys[i].Status + "', '" + student.Buys[i].Month + "', N'" + student.Buys[i].Note + "', '" + student.Id + "', '" + student.Buys[i].Document.DocumentId + "')";
            //        Connection.actionQuery(query3);
            //    }
            //}
        }

        public void updateQuery()
        {
            string query1 = "UPDATE Person SET name = N'" + student.Name + "', gender = N'" + student.Gender + "', dob = '" + student.Dob.ToString("yyyy/MM/dd") + "', numberPhone = '" + student.NumberPhone + "' WHERE Id = '" + student.Id + "'";
            string query2 = "UPDATE Student SET school = N'" + student.School + "', street = N'" + student.Street + "', ward = N'" + student.Ward + "', district = N'" + student.District + "', city = N'" + student.City + "', status = N'" + student.Status + "', note = N'" + student.Note + "' WHERE studentId = '" + student.Id + "'";
            Connection.actionQuery(query1);
            Connection.actionQuery(query2);
        }
        public DataTable selectClassesOfAStudent()
        {
            string s = $"SELECT c.subject + ' ' + cast(c.grade as varchar) + '.' + c.shift as [Tên lớp], c.numberOfSession as [Số buổi], c.numberOfStudent as [Số học sinh], c.price as [Học phí], c.dateCreated as [Ngày tạo]\r\nfrom Class c\r\ninner join Register r on r.classId = c.classId\r\nwhere r.studentId = '{student.Id}'\r\n";
            return Connection.selectQuery(s);
        }

        public void deleteQuery()
        {
            string query1 = "DELETE FROM Student WHERE studentId = '" + student.Id + "'";
            string query2 = "DELETE FROM Person WHERE Id = '" + student.Id + "'";
            string s = "Delete From Register Where StudentId = '" + student.Id + "'";
            Connection.actionQuery(s);
            Connection.actionQuery(query1);
            Connection.actionQuery(query2);
        }

        public DataTable basicSelectQuery()
        {
            string s = "SELECT p.Id, p.name, p.numberphone, p.dob, p.gender, s.dateCreated " +
                "FROM Person p " +
                "INNER JOIN Student s ON s.studentId = p.Id";
            return Connection.selectQuery(s);
        }
        public DataTable searchedStudentQuery() {
            string s = "Select p.Id,p.name,p.numberphone, p.dob, p.gender, s.dateCreated " +
                "From Person p " +
                "INNER JOIN Student s ON s.studentId = p.Id " +
                $"Where p.name like N'%{student.Name}%'";

            return Connection.selectQuery(s);
        }
        public DataTable basicSelectQueryOfficial()
        {
            string s = "SELECT p.Id, p.name, p.numberphone, p.dob, p.gender, s.dateCreated " +
                "FROM Person p " +
                "INNER JOIN Student s ON s.studentId = p.Id " +
                "WHERE s.status = N'Đang học'";
            return Connection.selectQuery(s);
        }
        public DataTable basicSelectQueryTrial()
        {
            string s = "SELECT p.Id, p.name, p.numberphone, p.dob, p.gender, s.dateCreated " +
                "FROM Person p " +
                "INNER JOIN Student s ON s.studentId = p.Id " +
                "WHERE s.status = N'Học thử'";
            return Connection.selectQuery(s);
        }
        public DataTable basicSelectQueryDropout()
        {
            string s = "SELECT p.Id, p.name, p.numberphone, p.dob, p.gender, s.dateCreated " +
                "FROM Person p " +
                "INNER JOIN Student s ON s.studentId = p.Id " +
                "WHERE s.status = N'Thôi học'";
            return Connection.selectQuery(s);
        }

        public DataTable findStudentBasic()
        {
            string s = "SELECT p.Id, p.name, p.numberphone, p.dob, p.gender, s.dateCreated " +
                "FROM Person p " +
                "INNER JOIN Student s ON s.studentId = p.Id " +
                "WHERE s.studentId = '" + student.Id + "'";
            return Connection.selectQuery(s);
        }

        public DataTable findStudentDetailed()
        {
            string s = "SELECT p.*, s.* " +
                "FROM Person p " +
                "INNER JOIN Student s ON s.studentId = p.Id " +
                "WHERE s.studentId = '" + student.Id + "'";
            return Connection.selectQuery(s);
        }

        public DataTable detailedSelectQuery()
        {
            string s = "SELECT p.*, s.* " +
                "FROM Person p " +
                "INNER JOIN Student s ON s.studentId = p.Id";
            return Connection.selectQuery(s);
        }

        public DataTable getLatestId()
        {
            string s = "SELECT TOP 1 studentId FROM Student ORDER BY studentId DESC";
            return Connection.selectQuery(s);
        }
        public DataTable selectAllPayment() {
            string s = $"Select p.paymentId, c.subject + ' ' + cast(c.grade as varchar) + '.' + cast(c.shift as varchar) as name, RIGHT(CONVERT(VARCHAR(10), p.period, 103), 7),p.status,p.note,p.dateCreated " +
                $"From Payment p " +
                $"JOIN \r\n    Student s ON p.studentId = s.studentId\r\n" +
                $"JOIN \r\n    Person pe ON s.studentId = pe.Id\r\n" +
                $"Join Register r On p.StudentId = r.studentId and r.classId = p.classId " +
                $"Join Class c On r.classId = c.ClassId" +
                $" Where p.studentId ='{student.Id}'" +
                $"\r\nUnion all\r\n" +
                $"Select b.buyId, d.name, RIGHT(CONVERT(VARCHAR(10), b.period, 103), 7),b.status, b.note, b.buyingDate " +
                $"from buy b " +
                $"Join Document d On d.handoutId = b.handoutId " +
                $"where b.studentId ='{student.Id}';";
            return Connection.selectQuery(s);
        }
        public void updateStatus() {
            string s = $"Update Student set status = N'{student.Status}' where StudentId = '{student.Id}'";
            string s2 = $"Update Student set status = N'Đang học' where status = N'Nhập học'";
            Connection.actionQuery(s);
            Connection.actionQuery(s2);
        }

        public DataTable getIdAndName()
        {
            string s = "SELECT s.studentId + ' - ' + p.name as [student] " +
                       "FROM Person p " +
                       "INNER JOIN Student s ON p.Id = s.studentId";
            return Connection.selectQuery(s);
        }
    }
}

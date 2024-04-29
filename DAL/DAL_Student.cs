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
    public class DAL_Student
    {
        private DTO_Student student;

        public DAL_Student(string id, string name, string gender, DateTime dob, string numberPhone, string school, string number, string street, string ward, string district, DateTime dateCreated, string status, string note)
        {
            student = new DTO_Student(id, name, gender, dob, numberPhone, school, number, street, ward, district, dateCreated, status, note);
        }

        public void addQuery()
        {
            string query1 = "INSERT INTO Person VALUES('" + student.Id + "', N'" + student.Name + "', N'" + student.Gender + "', '" + student.Dob.ToString("d") + "', '" + student.NumberPhone + "')";
            string query2 = "INSERT INTO Student VALUES('N" + student.School + "', '" + student.Number + "', N'" + student.Street + "', N'" + student.Ward + "', N'" + student.District + "', '" + student.DateCreated.ToString("d") + "', '" + student.Status + "', '" + student.Note + "', '" + student.Id + "')";
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
            string query1 = "UPDATE Person SET name = N'" + student.Name + "', N'" + student.Gender + "', dob = '" + student.Dob.ToString("d") + "' WHERE Id = '" + student.Id + "'";
            string query2 = "UPDATE Student SET school = 'N" + student.School + "', number = '" + student.Number + "', street = N'" + student.Street + "', ward = N'" + student.Ward + "', district = N'" + student.District + "', status = '" + student.Status + "', note = '" + student.Note + "', WHERE studentId = '" + student.Id + "')";
            Connection.actionQuery(query1);
            Connection.actionQuery(query2);
        }

        public void deleteQuery()
        {
            string query1 = "DELETE FROM Student WHERE Id = '" + student.Id + "'";
            string query2 = "DELETE FROM Person WHERE Id = '" + student.Id + "'";
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
        public DataTable selectAllPayment() {
            string s = $"Select p.paymentId, ConCat(c.subject,' ', c.grade, '.' , c.shift) as name, p.period,p.status,p.note,p.dateCreated " +
                $"From Payment p " +
                $"Join Register r On p.StudentId = r.studentId " +
                $"Join Class c On r.classId = c.ClassId" +
                $" Where p.studentId ='{student.Id}'" +
                $"\r\nUnion all\r\n" +
                $"Select b.buyId, d.name, b.period,b.status, b.note, b.buyingDate " +
                $"from buy b " +
                $"Join Document d On d.handoutId = b.handoutId " +
                $"where b.studentId ='{student.Id}';";
            Console.WriteLine(s);
            return Connection.selectQuery(s);
        }
    }
}

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

        public DAL_Student(string id, string name, string gender, DateTime dob, string numberPhone, string school, string number, string street, string ward, string district)
        {
            student = new DTO_Student(id, name, gender, dob, numberPhone, school, number, street, ward, district);
        }

        public void addQuery()
        {
            string query1 = "INSERT INTO Person VALUES('" + student.Id + "', N'" + student.Name + "', N'" + student.Gender + "', '" + student.Dob.ToString("d") + "')";
            string query2 = "INSERT INTO Student VALUES('N" + student.School + "', '" + student.Number + "', N'" + student.Street + "', N'" + student.Ward + "', N'" + student.District + "', '" + student.Id + "')";
            Connection.actionQuery(query1);
            Connection.actionQuery(query2);
            string query3 = "";
            {
                for (int i = 0; i < student.Registers.Count; i++)
                {
                    query3 = "INSERT INTO Register VALUES('" + student.Registers[i].AddmissionDay.ToString("d") + "', '" + student.Registers[i].State + "', '" + student.Registers[i].Student.Id + "', '" + student.Registers[i].Class.ClassId + "')";
                    Connection.actionQuery(query3);
                }
            }
            {
                for (int i = 0; i < student.Payments.Count; i++)
                {
                    query3 = "INSERT INTO Payment VALUES('" + student.Payments[i].DateCreated + "', " + student.Payments[i].Month + ", N'" + student.Payments[i].Status + "', N'" + student.Payments[i].Note + "', " + student.Payments[i].Promotion + ", " + student.Payments[i].Number_Of_Session + ", '" + student.Payments[i].PaymentId + "', '" + student.Id + "')";
                    Connection.actionQuery(query3);
                }
            }
            {
                for (int i = 0; i < student.Buys.Count; i++)
                {
                    query3 = "INSERT INTO Buy VALUES('" + student.Buys[i].BuyingDate.ToString() + "', " + student.Buys[i].Number + "', " + student.Buys[i].Price + "', '" + student.Buys[i].Status + "', '" + student.Buys[i].Month + "', N'" + student.Buys[i].Note + "', '" + student.Id + "', '" + student.Buys[i].Document.DocumentId + "')";
                    Connection.actionQuery(query3);
                }
            }
        }

        public void updateQuery()
        {
            string query1 = "UPDATE Person SET name = N'" + student.Name + "', N'" + student.Gender + "', dob = '" + student.Dob.ToString("d") + "' WHERE Id = '" + student.Id + "'";
            string query2 = "UPDATE Student SET school = 'N" + student.School + "', number = '" + student.Number + "', street = N'" + student.Street + "', ward = N'" + student.Ward + "', district = N'" + student.District + "' WHERE studentId = '" + student.Id + "')";
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
            string s = "SELECT p.Id, p.name, p.numberphone, c.classId, p.dob, p.gender, r.admission_day " +
                "FROM Person p " +
                "INNER JOIN Student s ON s.studentId = p.Id " +
                "INNER JOIN Register r ON s.studentId = r.studentId " +
                "INNER JOIN Class c ON c.classId = r.classId";
            return Connection.selectQuery(s);
        }
    }
}

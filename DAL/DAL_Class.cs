using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_Class
    {
        private DTO_Class dto_class;
        public DAL_Class(string classId, string subject, string shift,  int grade, int price, int n_Session, int n_Student, DateTime date_Created, string status,string id)
        {
            dto_class = new DTO_Class(classId, subject, shift, grade, price, n_Session, n_Student, date_Created,status, id);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Class VALUES('" + dto_class.ClassId + "', '" + dto_class.Subject + "', '" + dto_class.Shift + "', " + dto_class.Grade + ", " + dto_class.Price + ", " + dto_class.Number_Of_Session + ", " + dto_class.Number_Of_Student + ", " + dto_class.Date_Created.ToString() + ", '" + dto_class.TeacherId + "')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE Class SET subject = '" + dto_class.Subject + "', shift = '" + dto_class.Shift + "', grade = " + dto_class.Grade + ", price = " + dto_class.Price + ", numberOfSession = " + dto_class.Number_Of_Session + ", numberOfStudent = " + dto_class.Number_Of_Student + ", dateCreated = " + dto_class.Date_Created.ToString() + ", teacherId = '" + dto_class.TeacherId + "' WHERE classId = '" + dto_class.ClassId + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM Class WHERE classId = '" + dto_class.ClassId + "'";
            string s = $"Delete From Register Where classId = '{dto_class.ClassId}'";
            Connection.actionQuery(s);
            Connection.actionQuery(query);
        }

        public DataTable detailedSelectQuery()
        {
            string s = "SELECT * FROM Class";
            return Connection.selectQuery(s);
        }
        public DataTable getClass() {
            string s = $"Select * From Class Where classId = '{dto_class.ClassId}'";
            return Connection.selectQuery(s);
        }

        public DataTable basicSelectQuery()
        {
            string s = "SELECT subject + ' ' + cast(grade as varchar) + '.' + cast(shift as varchar) as name, numberOfSession, numberOfStudent, price, dateCreated " +
                       "FROM Class";
            return Connection.selectQuery(s);
        }
        public DataTable selectOptionalClass() {
            string s = "SELECT subject + ' ' + cast(grade as varchar) + '.' + cast(shift as varchar) as name, numberOfSession, numberOfStudent, price, dateCreated " +
                       $"FROM Class Where status = N'{dto_class.Status}'";
            return Connection.selectQuery(s);
        }

        public DataTable selectId()
        {
            string s = "SELECT classId " +
                       "FROM Class " +
                       "WHERE subject = N'" + dto_class.Subject + "' AND shift = N'" + dto_class.Shift + "' AND grade = " + dto_class.Grade;
            return Connection.selectQuery(s);
        }

        public DataTable getLatestId()
        {
            string s = "SELECT TOP 1 classId FROM Class ORDER BY classId DESC";
            return Connection.selectQuery(s);
        }

        public DataTable getNames()
        {
            string s = "SELECT subject + ' ' + cast(grade as varchar) + '.' + shift as name " +
                       $"FROM Class Where status = N'{dto_class.Status}'";
            
            return Connection.selectQuery(s);
        }
        public DataTable getRegisteredStudent() {
            string s = $"Select p.Id, p.Name, p.gender,p.dob,p.numberPhone, s.note,s.dateCreated from Student s \r\nINNER JOIN Person p On p.Id = s.studentId\r\nINNER JOIN Register r On r.studentId = s.studentId \r\nINNER JOIN Class c On c.classId = r.classId \r\nWHERE c.classId = '{dto_class.ClassId}';";
            return Connection.selectQuery(s);
        }


        //Get set method
        public string getname() {
            return dto_class.Subject + " " + dto_class.Grade + "." + dto_class.Shift;
        }
        public string getSubject() {
            return dto_class.Subject;
        }
        public int getGrade() {
            return dto_class.Grade;
        }
        public string getShift() {
            return dto_class.Shift;
        }
        public int getPrice() {
            return dto_class.Price;
        }
        public int getNumberOfSession() {
            return dto_class.Number_Of_Session;
        }
        public int getNumberOfStudent() {
            return dto_class.Number_Of_Student;
        }
        public string getStatus() {
            return dto_class.Status;
        }
    }
}

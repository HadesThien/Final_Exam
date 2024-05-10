using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Teacher
    {
        private DTO_Teacher teacher;
        //Constructor
        public DAL_Teacher(string id, string name, string gender, DateTime dob,string numberPhone, string subject) {
            teacher = new DTO_Teacher(id, name, gender, dob, numberPhone, subject);
        }
        
        public void addQuery()
        {
            string query1 = "INSERT INTO Person VALUES('" + teacher.Id + "', N'" + teacher.Name + "', N'" + teacher.Gender + "', '" + teacher.Dob.ToString("d") + "', '" + teacher.NumberPhone + "')";
            string query2 = "INSERT INTO Student VALUES('N" + teacher.Subject + "')";
            Connection.actionQuery(query1);
            Connection.actionQuery(query2);
        }

        public void updateQuery()
        {
            string query1 = "UPDATE Person SET name = N'" + teacher.Name + "', N'" + teacher.Gender + "', dob = '" + teacher.Dob.ToString("d") + "' WHERE Id = '" + teacher.Id + "'";
            string query2 = "UPDATE Teacher SET subject = 'N" + teacher.Subject + "'";
            Connection.actionQuery(query1);
            Connection.actionQuery(query2);
        }

        public void deleteQuery()
        {
            string query1 = "DELETE FROM Student WHERE Id = '" + teacher.Id + "'";
            string query2 = "DELETE FROM Person WHERE Id = '" + teacher.Id + "'";
            Connection.actionQuery(query1);
            Connection.actionQuery(query2);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM Teacher";
            return Connection.selectQuery(s);
        }

        public DataTable getLatestId()
        {
            string s = "SELECT TOP 1 teacherId FROM Teacher ORDER BY teacherId DESC";
            return Connection.selectQuery(s);
        }


        //get and set methods
        public string getName() {
            string s = $"Select p.name from Person p Inner Join Teacher t On p.Id = t.teacherId Where TeacherId = '{teacher.Id}'";
            DataTable dt =  Connection.selectQuery(s);
            return dt.Rows[0][0].ToString();
        }

        public DataTable getTeachers()
        {
            string s = "SELECT t.teacherId + ' - ' + p.name + ' - ' + t.subject as teacher " +
                       "FROM Person p " +
                       "INNER JOIN Teacher t ON t.teacherId = p.Id";
            return Connection.selectQuery(s);
        }
    }
}

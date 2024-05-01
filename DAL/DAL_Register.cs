using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Register
    {
        private DTO_Register register;

        public DAL_Register(string s, string c, DateTime admision_Day)
        {
            register = new DTO_Register(s, c, admision_Day);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Register VALUES('" + register.AddmissionDay.ToString("yyyy/MM/dd") + "', '" + register.StudentId + "', '" + register.ClassId + "')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE Register SET admissionDay = '" + register.AddmissionDay.ToString("yyyy/MM/dd") + "' WHERE studentId = '" + register.StudentId + "', classId = '" + register.ClassId + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM Register WHERE studentId = '" + register.StudentId + "', classId = '" + register.ClassId + "'";
            Connection.actionQuery(query);
        }
        public void deleteAStudentFromAllClasses()
        {
            string s = "DELETE FROM Register WHERE studentId = '" + register.StudentId + "'";
            Connection.actionQuery(s);
        }

        public DataTable getClassesOfAStudent()
        {
            string s = "SELECT classId FROM Register WHERE studentId = '" + register.StudentId + "'";
            return Connection.selectQuery(s);
        }
    }
}

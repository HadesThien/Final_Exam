using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Register
    {
        private DTO_Register register;

        public DAL_Register(DTO_Student s, DTO_Class c, DateTime admision_Day, string state)
        {
            register = new DTO_Register(s, c, admision_Day, state);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Register VALUES('" + register.AddmissionDay.ToString("d") + "', '" + register.Student.Id + "', '" + register.Class.ClassId + "')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE Register SET admissionDay = '" + register.AddmissionDay.ToString("d") + "', state = '" + register.State + "' WHERE studentId = '" + register.Student.Id + "', classId = '" + register.Class.ClassId + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM Register WHERE studentId = '" + register.Student.Id + "', classId = '" + register.Class.ClassId + "'";
            Connection.actionQuery(query);
        }
    }
}

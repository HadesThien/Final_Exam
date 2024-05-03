using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Register
    {
        private DAL_Register register;

        public BUS_Register(string s, string c, DateTime admision_Day)
        {
            register = new DAL_Register(s, c, admision_Day);
        }

        public void addQuery()
        {
            register.addQuery();
        }

        public void updateQuery()
        {
            register.updateQuery();
        }

        public void deleteQuery()
        {
            register.deleteQuery();
        }
        public void deleteAStudentFromAllClasses()
        {
            register.deleteAStudentFromAllClasses();
        }

        public DataTable getClassesOfAStudent()
        {
            return register.getClassesOfAStudent();
        }
    }
}

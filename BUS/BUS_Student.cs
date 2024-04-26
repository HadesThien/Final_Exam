using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Student
    {
        private DAL_Student student;

        public BUS_Student(string id, string name, string gender, DateTime dob, string numberPhone, string school, string number, string street, string ward, string district)
        {
            student = new DAL_Student(id, name, gender, dob, numberPhone, school, number, street, ward, district);
        }

        public void addQuery()
        {
            student.addQuery();
        }

        public void updateQuery()
        {
            student.updateQuery();
        }
        public void deleteQuery()
        {
            student.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return student.basicSelectQuery();
        }
    }
}

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

        public BUS_Student(string id, string name, string gender, DateTime dob, string numberPhone, string school, string street, string ward, string district, string city, DateTime dateCreated, string status, string note)
        {
            student = new DAL_Student(id, name, gender, dob, numberPhone, school, street, ward, district, city, dateCreated, status, note);
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

        public DataTable basicSelectQuery()
        {
            return student.basicSelectQuery();
        }

        public DataTable basicSelectQueryOfficial()
        {
            return student.basicSelectQueryOfficial();
        }
        public DataTable basicSelectQueryTrial()
        {
            return student.basicSelectQueryTrial();
        }
        public DataTable basicSelectQueryDropout()
        {
            return student.basicSelectQueryDropout();
        }

        public DataTable findStudentBasic()
        {
            return student.findStudentBasic();
        }

        public DataTable findStudentDetailed()
        {
            return student.findStudentDetailed();
        }

        public DataTable detailedSelectQuery()
        {
            return student.detailedSelectQuery();
        }

        public string getId()
        {
            DataTable tb = student.getLatestId();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();
                int stt = int.Parse(res.Substring(2, 3)) + 1;
                if (stt < 10)
                    res = "HS00" + stt.ToString();
                else if (stt < 100)
                    res = "HS0" + stt.ToString();
                else
                    res = "HS" + stt.ToString();
                return res;
            }
            else
            {
                return "HS001";
            }
        }

    }
}

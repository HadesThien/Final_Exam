using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Teacher
    {
        private DAL_Teacher teacher;
        //Constructor
        public BUS_Teacher(string id, string name, string gender, DateTime dob,string numberPhone, string subject) {
            teacher = new DAL_Teacher(id, name, gender, dob, numberPhone, subject);
        }

        public void addQuery()
        {
            teacher.addQuery();
        }

        public void updateQuery()
        {
            teacher.updateQuery();
        }

        public void deleteQuery()
        {
            teacher.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return teacher.selectQuery();
        }

        public string getId()
        {
            DataTable tb = teacher.getLatestId();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();
                int stt = int.Parse(res.Substring(2, 3)) + 1;
                if (stt < 10)
                    res = "GV00" + stt.ToString();
                else if (stt < 100)
                    res = "GV0" + stt.ToString();
                else
                    res = "GV" + stt.ToString();
                return res;
            }
            else
            {
                return "GV001";
            }
        }
    }
}

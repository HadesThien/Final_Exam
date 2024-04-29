using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Class
    {

        private DAL_Class dal_class;
        public BUS_Class(string classId, string subject, string shift,  int grade, int price, int n_Session, int n_Student, DateTime date_Created, string id)
        {
            dal_class = new DAL_Class(classId, subject, shift, grade, price, n_Session, n_Student, date_Created, id);
        }

        public void addQuery()
        {
            dal_class.addQuery();
        }

        public void updateQuery()
        {
            dal_class.updateQuery();
        }

        public void deleteQuery()
        {
            dal_class.deleteQuery();
        } 

        public DataTable basicSelectQuery()
        {
            return dal_class.basicSelectQuery();
        }

        public DataTable detailedSelectQuery()
        {
            return dal_class.detailedSelectQuery();
        }
        public string getId()
        {
            DataTable tb = dal_class.getLatestId();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();
                int stt = int.Parse(res.Substring(2, 3)) + 1;
                if (stt < 10)
                    res = "LH00" + stt.ToString();
                else if (stt < 100)
                    res = "LH0" + stt.ToString();
                else
                    res = "LH" + stt.ToString();
                return res;
            }
            else
            {
                return "LH001";
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Class
    {

        private DAL_Class dal_class;
        public BUS_Class(string classId, string subject, string shift,  int grade, int price, int n_Session, int n_Student, DateTime date_Created,string status, string id)
        {
            dal_class = new DAL_Class(classId, subject, shift, grade, price, n_Session, n_Student, date_Created,status, id);
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
        public DataTable selectOptionalClass() {
            return dal_class.selectOptionalClass();
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

        public string getClassId()
        {
            DataTable tb = dal_class.selectId();
            return tb.Rows[0][0].ToString();
        }
        public DataTable getClass() {
            return dal_class.getClass();
        }

        public DataTable getNames()
        {
            return dal_class.getNames();
        }
        public DataTable getRegisteredStudent() {
            return dal_class.getRegisteredStudent();
        }

        public string getClassName()
        {
            return dal_class.getClassName().Rows[0][0].ToString();
        }

        //Get and set methods
        public string getName() {
            return dal_class.getname();
        }
        public string getShift() {
            return dal_class.getShift();
        }
        public int getGrade() {
            return dal_class.getGrade();
        }
        public int getNumberOfSession() {
            return dal_class.getNumberOfSession();
        }
        public int getNumberOfStudent() {
            return dal_class.getNumberOfStudent();
        }
        public string getStatus() {
            return dal_class.getStatus();
        }
        public int getPrice() {
            return dal_class.getPrice();
        }
        public string getSubject() {
            return dal_class.getSubject();
        }
    }
}

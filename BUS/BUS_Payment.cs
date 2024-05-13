using DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace BUS
{
    public class BUS_Payment
    {
        private DAL_Payment payment;

        public BUS_Payment(string paymentId, DateTime dateCreated, DateTime period, string status, string note, float promotion, int n_session, string studentId, string classId)
        {
            payment = new DAL_Payment(paymentId, dateCreated, period, status, note, promotion, n_session, studentId, classId);
        }
        public DataTable selectQuery()
        {
            return payment.selectQuery();
        }
        public void addQuery()
        {
            payment.addQuery();
        }

        public void updateQuery()
        {
            payment.updateQuery();
        }

        public void deleteQuery()
        {
            payment.deleteQuery();
        }

        public string getId()
        {
            DataTable tb = payment.getLatestId();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();
                int stt = int.Parse(res.Substring(2, 3)) + 1;
                if (stt < 10)
                    res = "DK00" + stt.ToString();
                else if (stt < 100)
                    res = "DK0" + stt.ToString();
                else
                    res = "DK" + stt.ToString();
                return res;
            }
            else
            {
                return "DK001";
            }
        }
        public void deletePaymentsOfAStudent()
        {
            payment.deletePaymentsOfAStudent();
        }
        public string existsPaymentOfAPeriod()
        {
            if (payment.selectPaymentOfAPeriod().Rows.Count > 0)
            {
                return payment.selectPaymentOfAPeriod().Rows[0][0].ToString();
            }
            else
            {
                return "";
            }
        }

        public string existsPaymentOfAPeriod1()
        {
            if (payment.selectPaymentOfAPeriod1().Rows.Count > 0)
            {
                return payment.selectPaymentOfAPeriod1().Rows[0][0].ToString();
            }
            else
            {
                return "";
            }
        }

        public List<String> periodsOfExistsRegisteredPayments()
        {
            DataTable dt = payment.existsRegisteredPayment();
            List<String> ret = new List<string>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ret.Add(dt.Rows[i][0].ToString());
                }
            }
            return ret;
        }

        public string getPaymentId()
        {
            return payment.selectPaymentId().Rows[0][0].ToString();
        }

        public DataTable selectPayment()
        {
            return payment.selectPayment();
        }

        public List<string> selectRegisteredClasses()
        {
            List<string> ret = new List<string>();
            DataTable dt = payment.selectRegisteredClasses();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ret.Add(dt.Rows[i][0].ToString());
            }
            return ret;
        }
        public string getStudentId()
        {
            return payment.selectStudentId().Rows[0][0].ToString();
        }
        public DataTable selectPaidQuery()
        {
            return payment.selectPaidQuery();
        }
        public DataTable selectRegisteredQuery()
        {
            return payment.selectRegisteredQuery();
        }
        public DataTable get5newPayment() {
            return payment.select5NewPayment();
        }
    }

}
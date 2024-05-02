using DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Payment
    {
        private DAL_Payment payment;

        public BUS_Payment(string paymentId, DateTime dateCreated, DateTime period, string status, string note, float promotion, int n_session, string studentId)
        {
            payment = new DAL_Payment(paymentId, dateCreated, period, status, note, promotion, n_session, studentId);
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
                    res = "TT00" + stt.ToString();
                else if (stt < 100)
                    res = "TT0" + stt.ToString();
                else
                    res = "TT" + stt.ToString();
                return res;
            }
            else
            {
                return "TT001";
            }
        }
        
        public void deletePaymentsOfAStudent()
        {
            payment.deletePaymentsOfAStudent();
        }

    }
}

using DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Buy
    {
        private DAL_Buy buy;
        public BUS_Buy(DateTime buyingDate, int n, int p, string status, string month, string note, string id, string s, string d) { 
            buy = new DAL_Buy(s, d, buyingDate, n, p, status, month, note, id);
        }

        public void addQuery()
        {
            buy.addQuery();
        }

        public void deleteQuery()
        {
            buy.deleteQuery();
        }
        public string getId()
        {
            DataTable tb = buy.getLatestId();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();
                int stt = int.Parse(res.Substring(2, 3)) + 1;
                if (stt < 10)
                    res = "DH00" + stt.ToString();
                else if (stt < 100)
                    res = "DH0" + stt.ToString();
                else
                    res = "DH" + stt.ToString();
                return res;
            }
            else
            {
                return "DH001";
            }
        }


    }
}

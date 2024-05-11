using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Document
    {
        private DAL_Document doc;
        public BUS_Document(int inventory, string id, string name, DateTime dateCreated, DateTime dateUpdate, int price)
        {
            doc = new DAL_Document(id, inventory, name, dateCreated, dateUpdate, price);
        }

        public void addQuery()
        {
            doc.addQuery();
        }

       public void updateQuery()
        {
            doc.updateQuery();
        }

        public void deleteQuery()
        {
            doc.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return doc.detailedSelectQuery();
        }

        public string getId()
        {
            DataTable tb = doc.getLatestId();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();
                int stt = int.Parse(res.Substring(2, 3)) + 1;
                if (stt < 10)
                    res = "TL00" + stt.ToString();
                else if (stt < 100)
                    res = "TL0" + stt.ToString();
                else
                    res = "TL" + stt.ToString();
                return res;
            }
            else
            {
                return "TL001";
            }
        }

        public DataTable findDocument()
        {
            return doc.findDocument();
        }

        public DataTable searchDocument()
        {
            return doc.searchDocument();
        }

        public DataTable getNames()
        {
            return doc.getNames();
        }

        public DataTable getDocumentFromName()
        {
            return doc.getDocumentFromName();
        }
        public void updateAfterBuying()
        {
            doc.updateAfterBuying();
        }


    }
}

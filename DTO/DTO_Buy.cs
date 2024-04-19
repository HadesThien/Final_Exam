using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class DTO_Buy {

        //Properties
        public DTO_Student Student {  get; set; }
        public DTO_Document Document { get; set; }
        public DateTime BuyingDate { get; set; }
        public int Number { get; set; }
        public int Price { get; set; }

        //Constructor
        public DTO_Buy(DTO_Student s, DTO_Document d, DateTime buyingDate, int n, int p) {
            Student = s;
            Document = d;
            BuyingDate = buyingDate;
            Number = n;
            Price = p;
        }

    }
}

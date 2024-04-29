using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class DTO_Buy {

        //Properties
        public string StudentId {  get; set; }
        public string DocumentId { get; set; }
        public DateTime BuyingDate { get; set; }
        public int Number { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }
        public DateTime Period { get; set; }
        public string Note { get; set; }
        public string Id { get; set; }


        //Constructor
        public DTO_Buy(string s, string d, DateTime buyingDate, int n, int p, string status, DateTime period, string note, string id)
        {
            StudentId = s;
            DocumentId = d;
            BuyingDate = buyingDate;
            Number = n;
            Price = p;
            Status = status;
            Period = period; 
            Note = note;
            Id = id;
        }

    }
}

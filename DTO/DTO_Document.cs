using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class DTO_Document {
        //Properties
        public string DocumentId { get; set; }
        public int Inventory {  get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int Price { get; set; }

        //Constructor
        public DTO_Document(string id, int inventory, string name, DateTime dateCreated, DateTime dateUpdate, int price) {
            DocumentId = id;
            Inventory = inventory;
            Name = name;
            DateCreated = dateCreated;
            DateUpdated = dateUpdate;
            Price = price;
        }

    }
}

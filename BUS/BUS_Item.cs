using DAL;
using DTO;
using System;
using System.Data;

namespace BUS {
    public class BUS_Item {
        //Property
        private DAL_Item item;
        //Constructor
        public BUS_Item(DTO_Item item) { this.item = new DAL_Item(item);  }

        //Methods
        //Genrate item id
        public string generateId() {
            string id = "I";
            DataTable dt = item.getTopIdQuery();
            int number = int.Parse(dt.Rows[0][0].ToString().Substring(id.Length)) + 1;
            int n = 1;
            int numPart = 100000000;
            while (n != numPart) {
                n *= 10;
                if (number < n) {
                    Console.WriteLine(numPart);
                    for (int i = 1; i <= (numPart/n); i*=10) 
                        id += "0";
                    id += number;
                    break;
                }
            }
            return id;
        }

        public void createItem() {
            item.addQuery();
        }
    }
}

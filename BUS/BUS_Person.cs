using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Person
    {
        public DAL_Person person;

        public BUS_Person(string id, string name, string gender, DateTime dob, string numberPhone)
        {
            person = new DAL_Person(id, name, gender, dob, numberPhone);
        }

        public void addQuery()
        {
            person.addQuery();
        }

        public void updateQuery()
        {
            person.updateQuery();
        }

        public void deleteQuery()
        {
            person.deleteQuery();
        }
    }
}

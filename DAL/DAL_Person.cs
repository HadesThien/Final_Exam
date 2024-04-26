using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Person
    {

        private DTO_Person person;
        public DAL_Person(string id, string name, string gender, DateTime dob, string numberPhone)
        {
            person = new DTO_Person(id, name, gender, dob, numberPhone);
        }
        
        public void addQuery()
        {
            string query1 = "INSERT INTO Person VALUES('" + person.Id + "', N'" + person.Name + "', N'" + person.Gender + "', '" + person.Dob.ToString("d") + "', '" + person.NumberPhone + "')";
            Connection.actionQuery(query1);
        }

        public void updateQuery()
        {
            string query = "UPDATE Person SET numberphone = '" + person.NumberPhone + "', name = N'" + person.Name + "', N'" + person.Gender + "', dob = '" + person.Dob.ToString("d") + "' WHERE Id = '" + person.Id + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM Person WHERE Id = '" + person.Id + "'";
            Connection.actionQuery(query);
        }
    }
}

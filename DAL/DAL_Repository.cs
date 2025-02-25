using DTO;
using System;
using System.Data;
using System.Data.Odbc;

namespace DAL {
    public class DAL_Repository {
        //property
        private DTO_Repository repository;

        //Constructor
        public DAL_Repository(DTO_Repository repository) {
            this.repository = repository;
        }
        public DAL_Repository() { }

        //Methods
        // Insert employee into table  
        public void addQuery()
        {
            string query = "";
            Connection.actionQuery(query);
        }
        //Edit or Update information of employee
        public void updateQuery()
        {
            string query = "";
            Connection.actionQuery(query);
        }
        //Remove Employee
        public void deleteQuery()
        {
            string query = "";
            Connection.actionQuery(query);
        }
        //Show one or all employee
        public DataTable selectQuery()
        {
            string query = "Select * from Repository";
            return Connection.selectQuery(query);
        }
        public DataTable showAllItems() {
            string query = $"select d.detail_item_id, i.name, i.type, i.unit, d.status ,r.name ,d.quantity from Detail_Item d " +
                "Inner Join Item i on i.repository_id = r.repository_id";
            return Connection.selectQuery(query);
        }

        public DataTable countQuery() {
            string query = $"SELECT TOP 1 FROM Repository ORDER BY DESC";
            return Connection.selectQuery(query);
        }
        public DataTable getId() {
            string query = $"SELECT repository_id FROM Repository WHERE name = N'{repository.getRepositoryName()}'";
            return Connection.selectQuery(query);
        }
    }
}

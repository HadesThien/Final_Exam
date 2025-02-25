using DAL;
using DTO;
using System;
using System.Data;

namespace BUS {
    public class BUS_Repository  {
        //-----------------------------------Property-----------------------------------\\
        private DAL_Repository repository;

        
        //-----------------------------------Constructor-----------------------------------\\
        
        public BUS_Repository(DTO_Repository repository) {
            this.repository = new DAL_Repository(repository);
        }

        public BUS_Repository() { repository = new DAL_Repository(); }

        //-----------------------------------Methods handle some logical business-----------------------------------\\
        //To generate id 
        public string generateId() {
            string id = "ITEM";
            DataTable dt = repository.countQuery();
            int number = int.Parse(dt.Rows[0][0].ToString().Substring(3)) + 1;
            if (number < 10) {
                id += "00000" + number;
            }
            else if (number < 100) {
                id += "0000" + number;
            }else if(number < 1000) {
                id += "000" + number;
            } else if(number < 10000) {
                id += "00" + number;
            }else if (number < 100000) {
                id += "0" + number;
            }
            else {
                id += number;
            }
            return id;
        }

        //-----------------------------------Call data from database by query function-----------------------------------\\

        //To show all items of all repository
        public DataTable showAllItems() {
            return repository.showAllItems();
        }

        //To show all information of all repository
        public DataTable showAllRepository() {
            return repository.selectQuery();
        }
        

        //find repository id with a name of item in detail item 
        public string getRepoId() {
            return repository.getId().Rows[0][0].ToString();   
        }
        


    }
}

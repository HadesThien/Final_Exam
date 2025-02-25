using System;

namespace DTO {
    public class DTO_Account {
        //Property
        public string username;
        public string password;
        public DateTime dateCreated;
        public string role;

        //Constructor
        public DTO_Account(string userName, string password, DateTime dateCreated, string role) {
            this.username= userName;
            this.password= password;
            this.dateCreated= dateCreated;
            this.role = role;
        }
        public DTO_Account() { }

        //Methods
        
        //Setter
        public void setUsername(string username) {this.username= username;}
        public void setPassword(string password) {this.password= password;}
        public void setDateCreated(DateTime dateCreated) {this.dateCreated= dateCreated;}
        public void setRole(string role) {this.role= role;}

        //Getter
        public string getUsername() {return username;}
        public string getPassword() {return password;}
        public DateTime getDateCreated() {return dateCreated;}
        public string getRole() {return role;}

    }
}

using System;

namespace DTO {
    public class DTO_Saler : DTO_Employee {
        private string role;

        public DTO_Saler(
            string id,
            string fullname,
            int coefficient,
            int dayOffLeft,
            DateTime dob,
            string phoneNumber,
            string email,
            string role,
            DateTime hireDate
            ) :
            base(id,fullname,coefficient,dayOffLeft,dob,phoneNumber,email,hireDate){
            this.role = role;

        }
        public void setRole( string role ) { this.role = role; }
        public string getRole() { return this.role; }
    }
}

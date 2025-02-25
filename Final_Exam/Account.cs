using BUS;

namespace NQH_Application{
    public class Account {
        //Properties
        private static BUS_Account account;
        private static BUS_Employee user;
        private static bool confirmPassword;

        //Constructor
        public Account() { }

        //Methods

        /* Methods relevanting to right of this account used to login to this system application */
        //This function is used to allow access from account's attemping to this system if password's correct and account's existed
        public static void access() {
            Account.confirmPassword = true;
        }
        //This function is used to deny access to this system because account does not exist or password is incorrect
        public static void denyAccess() {
            Account.confirmPassword = false;
        }
        //This function is used to be called somewhere to check accoutn's right of accessing this system
        public static bool isPermited() {
            return Account.confirmPassword; 
        }


        //Methods are used to check some information of this account 


        // set user logging in this system 
        public static void setUser(BUS_Employee employee) {
            Account.user = employee;
        }
        // Set account logging in this system 
        public static void setAccount(BUS_Account account) {
            Account.account = account;
        }

        //Return account object
        public static BUS_Account getAccount() {
            return Account.account;
        }
        //Return user object
        public static BUS_Employee getUser() {
            return Account.user; 
        }

    }
}

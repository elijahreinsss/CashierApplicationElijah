using System;

namespace ElijahCashierApplication
{
    internal class Cashier : UserAccount
    {
        private string department;
        private string fullName;

        public Cashier(string name, string department, string userName, string password) : base(name, userName, password)
        {
            this.fullName = name;
            this.department = department;
        }

        public override bool validateLogin(string username, string password)
        {
            if (user_name.Equals("cashier101") && password.Equals("12345"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string getDepartment()
        {
            return department;
        }

        public string getFullName()
        {
            return this.fullName;
        }
    }
}

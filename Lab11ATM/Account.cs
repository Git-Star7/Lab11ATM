using System;
namespace Lab11ATM
{
    public class Account
    {
        //fields
        private string name;
        private string password;
        private double balance;

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        //constructors
        public Account(string _name, string _password)
        {
            Name = _name;
            Password = _password;
        }
    }
}

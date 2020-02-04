using System;
using System.Collections.Generic;

namespace Lab11ATM
{
    public class ATM
    {
        //fields
        private Account loggedInAcc;
        public bool loggedInState;
        private List<Account> userAccounts = new List<Account>();
        private List<string> loggedInMenu = new List<string>
        {
            "1: Check Balance",
            "2: Deposit",
            "3: Withdraw",
            "2: Log Out",
            "3: Exit"
        };
        private List<string> loggedOutMenu = new List<string>
        {
            "1: Add New",
            "2: Log Out",
            "3: Exit"
        };

        //properties

        //constructors
        public ATM()
        {

        }

        //methods
        public void PrintMenu()
        {
            if (loggedInAcc == null)
            {
                foreach (string s in loggedOutMenu)
                {
                    Console.WriteLine(s);
                }
            }
            else
            {
                foreach (string s in loggedInMenu)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void MakeNewAccount(string name, string pw)
        {
            Account newAcc = new Account(name, pw);
            userAccounts.Add(newAcc);
            //return to menu
        }

        public void LogIn(string name, string pw)
        {
            for (int i = 0; i < userAccounts.Count; i++)
            {
                if (userAccounts[i].Name == name && userAccounts[i].Password == pw)
                {
                    loggedInAcc = userAccounts[i];
                    loggedInState = true;
                }
            }
        }

        public void LogOut()
        {
            loggedInAcc = null;
            loggedInState = false;
        }

        public void CheckBalance()
        {
            if (loggedInState == true)
            {
                Console.WriteLine(loggedInAcc.Balance);
            }
        }

        public void Deposit(int input)
        {
            if (loggedInState == true)
            {
                loggedInAcc.Balance += input;
            }
        }

        public void Withdraw(int input)
        {
            if (loggedInState == true)
            {
                try
                {
                    loggedInAcc.Balance -= input;
                }
                catch
                {
                    Console.WriteLine("Insufficient funds... big sad...");
                }
            }
        }

    }
}

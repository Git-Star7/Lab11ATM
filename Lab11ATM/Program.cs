using System;
using System.Collections.Generic;

namespace Lab11ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM myATM = new ATM();

            myATM.MakeNewAccount(GetUserInput("New Account Name: "), GetUserInput("New Password: "));

            if (myATM.loggedInState == false)
            {
                if (YesOrNo("Do you want to log out? yes/no", "yes", "no") == true)
                {
                    myATM.LogOut();
                    //return to menu
                }
            }
            else
            {
                myATM.LogIn(GetUserInput("Account Name: "), GetUserInput("Password: "));

                if (myATM.loggedInState == false)
                {
                    Console.WriteLine("Incorrect username and/or password");
                    //return to menu
                }
            }

            myATM.CheckBalance();
            myATM.Deposit(GetUserInt("How much?: "));
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int GetUserInt(string message)
        {
            int num = 0;
            try
            {
                num = int.Parse(GetUserInput(message));
            }
            catch
            {
                GetUserInt(message);
            }
            return num;
        }

        public static bool YesOrNo(string message, string yes, string no)
        {
            string userContinue = null;
            while (userContinue != yes && userContinue != yes)
            {
                Console.Write(message);
                userContinue = Console.ReadLine().ToLower();

                if (userContinue == no)
                {
                    Console.WriteLine("Okay!!");
                    return false;
                }
            }
            return true;
        }
    }
}

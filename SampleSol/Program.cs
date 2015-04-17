using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SampleSol
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_1 = "user1";
            string user_2 = "user2";
            string admin = "admin";
            //string user_3 = "user3";
            string feedback_1 = "";
            string feedback_2 = "";
            int Account_1 = 156573;
            int Account_2 = 1657561;
            int AccBalance1 = 25000;
            int AccBalance2 = 35000;

            while (true)
            {
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();

                if (username == "q" || username == "quit" || username == "exit")
                    break;

                if (username == user_1)
                {
                    while (true)
                    {
                        Console.WriteLine("1. Account");
                        Console.WriteLine("2. Promoutions");
                        Console.WriteLine("3. Feedback");
                        Console.WriteLine("4. Exit");

                        Console.Write("\n>");
                        string choice = Console.ReadLine();

                        if (choice == "1")
                        {
                            Console.WriteLine("Account ID: " + Account_1);
                            Console.WriteLine("Balance: " + AccBalance1);
                        }

                        if (choice == "2")
                        {
                            Console.WriteLine("Submenu Promoutions");
                        }

                        if (choice == "3")
                        {
                            Console.WriteLine("Submenu Feedback");
                            Console.Write("\nFB:>");
                            feedback_1 = Console.ReadLine();
                        }

                        if (choice == "4")
                        {
                            break;
                        }
                    }
                }
                if (username == user_2)
                {
                    while (true)
                    {
                        Console.WriteLine("1. Account");
                        Console.WriteLine("2. Promoutions");
                        Console.WriteLine("3. Feedback");
                        Console.WriteLine("4. Exit");

                        Console.Write("\n>");
                        string choice = Console.ReadLine();

                        if (choice == "1")
                        {
                            Console.WriteLine("Account ID: " + Account_2);
                            Console.WriteLine("Balance: " + AccBalance2);
                        }

                        if (choice == "2")
                        {
                            Console.WriteLine("Submenu Promoutions");
                        }

                        if (choice == "3")
                        {
                            Console.WriteLine("Submenu Feedback");
                            Console.Write("\nFB:>");
                            feedback_2 = Console.ReadLine();
                        }

                        if (choice == "4")
                        {
                            break;
                        }
                    }
                }
                if (username == admin)
                {
                    while (true)
                    {
                        Console.WriteLine("1. Watch feedback");
                        Console.WriteLine("2. Exit");
                        string choice = Console.ReadLine();

                        if (choice == "1")
                        {
                            Console.WriteLine(user_1 + ": " + feedback_1);
                            Console.WriteLine(user_2 + ": " + feedback_2);
                        }

                        if (choice == "2")
                            break;
                    }

                }
                
            }
        }   
    }
}
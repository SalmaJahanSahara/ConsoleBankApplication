using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("Developer's bank", 5000);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Welcome to Developer's Bank");
            Console.WriteLine("-----------------------------------\n");

            bool choice = true;

            while(choice)
            {
                //Console.WriteLine("Enter Your Keyword: ");
                string s = System.Convert.ToString(System.Console.ReadLine());

                Console.WriteLine("What do you want to do?");
                Console.WriteLine("\n1. Open a Bank Account");
                Console.WriteLine("\n2. Perform transactions for an account");
                Console.WriteLine("\n3. Exit the application");
                Console.WriteLine("-----------------------------------\n");

                Console.WriteLine("Enter Your Choice: ");
                string input = System.Convert.ToString(System.Console.ReadLine());
                Console.WriteLine("-----------------------------------");

                switch(s)
                {

                    case "open":
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("You Have Chosen Open a Bank Account");
                        Console.WriteLine("---------------------------------");

                        Console.WriteLine("You have following options: \n");
                        Console.WriteLine("\t1. Open Savings Account ");
                        Console.WriteLine("\t2. Open Checking Account ");
                        Console.WriteLine("\t3. Exit from the application");


                        Console.WriteLine("Enter You Option: ");
                        string input1 = System.Convert.ToString(System.Console.ReadLine());
						switch(s1)
						{
							case "savings":

								Console.WriteLine("Open a savings account");
                                Console.WriteLine("Enter Employee Name: ");
								String customerName1 = System.Convert.ToString(System.Console.ReadLine());

                                Console.WriteLine("Enter Date of Birth: ");
								String dateOfBirth1 = System.Convert.ToString(System.Console.ReadLine());

                                Console.WriteLine("Enter Your Address: ");
                                String address1 = System.Convert.ToString(System.Console.ReadLine());

								break;

							case "checkings":
								
								break;

							case "quit":

                                Console.WriteLine("You Choose to Go Back.......");
								break;

							default:
								Console.WriteLine("Invalid");
								break;

						}
						break;
                    
                    case "account":
                        Console.WriteLine();
                        Console.WriteLine("You Have Chosen Perform transactions for an account ");
                        Console.WriteLine();

                        Console.WriteLine("You have following options: \n");
                        Console.WriteLine("\t1. Deposit money in account");
                        Console.WriteLine("\t2. Withdraw money from his account ");
                        Console.WriteLine("\t3. Transfer money to another account");
                        Console.WriteLine("\t4. Display the number of transactions and balance ");
                        Console.WriteLine("\t5. Exit from the application");

                        Console.WriteLine("Enter You Option: ");
                        string input2 = System.Convert.ToString(System.Console.ReadLine());
                        break;

                    case "quit":
                        Console.WriteLine();
                        Console.WriteLine("Exit the application");
                        Console.WriteLine();
                        choice = false;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid Choice.....");
                        break;
                }
                
            }
        }
    }
}

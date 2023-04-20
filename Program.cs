using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace business_application
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\USER\\source\\repos\\business application";
            string userNames[100];
            string passwords[100];
            string feedbacks[100];
            double moneyDeposits;
            double moneyWithdraws;
            double totalmoneyDeposits;
            double totalmoneyWithdraws;
            double totalMoneys[100];
            int userCount = 0;
            int total = userCount;
            int feedbackCount = 0;


            //functions//


            //bool signIn(string userName, string password);
            //bool isValidUsername(string userName);
            //void signUpArray(string userName, string password);
            //void storeInFile(string userName, string password, double totalMoney);
            //int takeChoice();
            //void viewUsers();
            //void readDataFromFile();
            //void depositMoney(string userName, string password, double totalMoney);
            //void withdrawMoney(string userName, string password, double totalMoney);
            //void totalMoneyDeposit(double moneyDeposits);
            //void totalMoneyWithdraw(double moneyWithdraws);
            //void exitAccount();
            //void managerMenu();
            //void accountHolderInterface();
            //void displaySystem();
            //void feedback();


            //main function//


           
{
                readDataFromFile();
                displaySystem();
                bool decision;
                string userName;
                string password;
                
                double totalMoney;
                int choice = 0;

                //Console.WriteLine( "Enter your role : ");
                //cout << "ADMIN   OR ACCOUNTHOLDER " << endl;
                //cin >> role;


                


               // else if (role == "accountholder" || role == "ACCOUNTHOLDER")
               // {
                 //   while (choice != 0)
                   // {
                   //     choice = takeChoice();
                   //     if (choice == 1)
                     //   {
                       //     cout << "Enter your username: ";
                         //   cin >> userName;
                           // cout << "Enter your password: ";
                            //cin >> password;
                          //  cout << "Enter your first deposit money : ";
                            //cin >> totalMoney;
                        //    decision = isValidUsername(userName);
                         //   if (decision == true)
                            {
                                signUp(userName, password);
                                storeInFile(userName, password, totalMoney);
                                Console.WriteLine("User Created Successfully");
                            }
                            else
                            {
                                cout << "Username already exists" << endl;
                            }
                        }

                        else if (choice == 2)
                        {
                            cout << "Enter your username: ";
                            cin >> userName;
                            cout << "Enter your password: ";
                            cin >> password;
                            decision = signIn(userName, password);
                            if (decision == true)
                            {
                                cout << "Login Successful" << endl;
                                int option;
                                cout << "01. Press 1 to Deposit Money  :" << endl;
                                cout << "02. Press 2 to Withdraw Money :" << endl;
                                cout << "03. Press 3 to Exit Account   :" << endl;
                                cout << "04. Press 4 to Give Feedback  :" << endl;
                                cout << "Enter any Option : " << endl;

                                cin >> option;

                                if (option == 1)
                                {
                                    depositMoney(userName, password, totalMoney);
                                }

                                if (option == 2)
                                {
                                    withdrawMoney(userName, password, totalMoney);
                                }

                                if (option == 3)
                                {
                                    break;
                                }

                                if (option == 4)
                                {
                                    feedback();
                                }

                            }

                            else if (decision == false)
                            {
                                cout << "Invalid Credentials" << endl;
                            }
                        }
                    }
                }
            }


            //functions//

            public static void displaySystem()


            {
               Console.WriteLine("-------------------------------------------------------- ");
               Console.WriteLine("|                                                       |");
               Console.WriteLine("|        WELCOME                                        |");
               Console.WriteLine("|                   TO                                  |");
               Console.WriteLine("|                          BANK                         |");
               Console.WriteLine("|                                                       |");
               Console.WriteLine("|                                                       |");
               Console.WriteLine("-------------------------------------------------------- ");
               
            }


            void accountHolderInterface()
            {
                cout << "__________________________________________ " << endl;
                cout << "|                                          |" << endl;
                cout << "|        ACCOUNT      HOLDER               |" << endl;
                cout << "|                                          |" << endl;
                cout << "|       LOGIN        INTERFACE             |" << endl;
                cout << "|                                          |" << endl;
                cout << "|                                          |" << endl;
                cout << "|__________________________________________|" << endl;
            }


            void managerMenu()
            {
                cout << " __________________________________________ " << endl;
                cout << "|                                          |" << endl;
                cout << "|        BANK   MANAGER                    |" << endl;
                cout << "|                                          |" << endl;
                cout << "|            Menu                          |" << endl;
                cout << "|__________________________________________|" << endl;

                int choice;
                while ((choice != 0))
                {


                    cout << "   ENTER CHOICE : " << endl;
                    cout << "1. Press 1 to view Money withdrawed          :    " << endl;
                    cout << "2. Press 2 to view Money deposited           :    " << endl;
                    cout << "3. Press 3 to view Total accounts            :    " << endl;
                    cout << "4. Press 4 to view account details           :    " << endl;
                    cout << "5. Press 5 to Exit Account                   :    " << endl;

                    cin >> choice;
                    if (choice == 1)
                    {
                        totalMoneyDeposit(moneyDeposits);
                    }
                    else if (choice == 2)
                    {
                        totalMoneyWithdraw(moneyWithdraws);
                    }
                    else if (choice == 3)
                    {
                        readDataFromFile();
                    }
                    else if (choice == 4)
                    {
                        viewUsers();
                    }

                    else if (choice == 5)
                    {
                        break;
                    }

                }
            }


            void totalMoneyDeposit(double moneyDeposits)
            {
                totalmoneyDeposits = totalmoneyDeposits + moneyDeposits;
                cout << "Total money deposited : " << totalmoneyDeposits << endl;
            }


            void totalMoneyWithdraw(double moneyWithdraws)
            {
                totalmoneyWithdraws = totalmoneyWithdraws - moneyWithdraws;
                cout << "Total money withdraw : " << totalmoneyWithdraws << endl;
            }


            void depositMoney(string userName, string password, double totalMoney)
            {
                system("cls");
                cout << " __________________________________________" << endl;
                cout << "|                                          |" << endl;
                cout << "|                                          |" << endl;
                cout << "|           DEPOSIT MONEY                  |" << endl;
                cout << "|                                          |" << endl;
                cout << "|__________________________________________|" << endl;
                cout << "Enter amount you want to deposit : " << endl;
                cin >> moneyDeposits;
                totalMoney = totalMoney + moneyDeposits;
                cout << "Your total account balance is : " << endl;
                cout << totalMoney << endl;
            }


            void withdrawMoney(string userName, string password, double totalMoney)
            {
                system("cls");
                cout << " __________________________________________" << endl;
                cout << "|                                          |" << endl;
                cout << "|                                          |" << endl;
                cout << "|           WITHDRAW MONEY                 |" << endl;
                cout << "|                                          |" << endl;
                cout << "|__________________________________________|" << endl;
                cout << "Enter amount you want to withdraw : " << endl;
                cin >> moneyWithdraws;
                totalMoney = totalMoney - moneyWithdraws;
                cout << "Your total account balance is : " << endl;
                cout << totalMoney << endl;
            }


            void feedback()
            {

                cout << "Enter your feedback : " << endl;
                cin >> feedbacks[feedbackCount];
                cout << endl;
                feedbackCount++;
                cout << "Thank you for your feedback!" << endl;

            }


            void exitAccount()
            {
                int choice;
                cout << " __________________________________________" << endl;
                cout << "|                                          |" << endl;
                cout << "|                                          |" << endl;
                cout << "|           EXIT ACCOUNT                   |" << endl;
                cout << "|__________________________________________|" << endl;
                cout << "|                                          |" << endl;
                cout << "ARE YOU SURE YOU WANT TO EXIT ? YES(1) OR NO(0) " << endl;
                cin >> choice;
                for (int i = 0; i < 2;)
                {
                    if (choice == 1)
                    {
                        break;
                    }
                    if (choice == 0)
                    {
                        continue;
                    }
                }
            }


            bool signIn(string userName, string password)
            {
                bool flag = false;
                cout << "Sign in to your account : " << endl;
                cout << "________________________________" << endl;
                cout << "|                                |" << endl;
                cout << "|   SIGN IN                      |" << endl;
                cout << "|            TO                  |" << endl;
                cout << "|              YOUR              |" << endl;
                cout << "|                  ACCOUNT       |" << endl;
                cout << "|________________________________|" << endl;
                for (int idx = 0; idx < userCount; idx++)
                {
                    if (userNames[idx] == userName && passwords[idx] == password)
                    {
                        flag = true;
                        break;
                    }
                }
                return flag;
            }


            bool isValidUsername(string userName)
            {
                bool flag = true;
                for (int idx = 0; idx < userCount; idx++)
                {
                    if (userNames[idx] == userName)
                    {
                        flag = false;
                        break;
                    }
                }
                return flag;
            }


            void signUpArray(string userName, string password)
            {
                cout << "Sign up to create a new account : " << endl;
                cout << "________________________________" << endl;
                cout << "|                                |" << endl;
                cout << "|   CREATING                     |" << endl;
                cout << "|            A                   |" << endl;
                cout << "|              NEW               |" << endl;
                cout << "|                  ACCOUNT       |" << endl;
                cout << "|________________________________|" << endl;
                userNames[userCount] = userName;
                passwords[userCount] = password;
                userCount++;
                cout << "Your account number is : " << userCount;
            }


            void storeInFile(string userName, string password, double totalMoney)
            {
                fstream file;
                file.open("data.txt", ios::app);
                file << userName << endl;
                file << password << endl;
                file << userCount << endl;
                file << totalMoney << endl;
                file.close();
            }


            int takeChoice()
            {
                int choice;
                cout << endl;
                cout << "01. SignUp User" << endl;
                cout << "02. SignIn User" << endl;
                cout << "03. Exit" << endl;
                cout << "Enter your choice >  ";
                cin >> choice;
                return choice;
            }


            void viewUsers()
            {
                cout << "Usernames"
                     << "\t\t"
                     << "Passwords"
                     << "\t\t"
                     << "Account Number"
                     << "\t\t"
                     << "Money Deposited"
                     << "\t\t"
                     << "Money Deposited"
                     << endl;
                for (int idx = 0; idx < userCount; idx++)
                {
                    cout << userNames[idx]
                         << "\t\t"
                         << passwords[idx]
                         << "\t\t"
                         << idx
                         << totalmoneyDeposits
                         << "\t\t"
                         << totalmoneyWithdraws
                         << "\t\t"
                         << endl;
                }
            }


            void readDataFromFile()
            {
                string username;
                string password;

                fstream file;
                file.open("data.txt", ios::in);

                while ((getline(file, username) && getline(file, password)))
                {
                    userNames[userCount] = username;
                    passwords[userCount] = password;
                    total = userCount++;
                }
                cout << total << endl;
                file.close();
            }
        }
}

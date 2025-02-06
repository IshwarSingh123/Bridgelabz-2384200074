using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal class BankingSystem
    {
        private List<Bank> banks; // List to store available banks

        public BankingSystem()
        {
            // Initializing the list of banks
            banks = new List<Bank>
            {
                new Bank("SBI Bank"),
                new Bank("PNB Bank"),
                new Bank("CANARA Bank")
            };
        }

        public void Run()
        {
            while (true)
            {
                // Display menu options
                Console.WriteLine("\n--- Banking System ---");
                Console.WriteLine("1. Open Account");
                Console.WriteLine("2. View Balance");
                Console.WriteLine("3. Show Account Details");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "4") break; // Exit the program

                Console.WriteLine("\nAvailable Banks:");

                // Display available banks
                for (int i = 0; i < banks.Count; i++)
                    Console.WriteLine($"{i + 1}. {banks[i].bankName}");

                Console.Write("Select a bank (1/2/3): ");
                int bankChoice;
                
                // Ensure valid input for bank selection
                if (!int.TryParse(Console.ReadLine(), out bankChoice) || bankChoice < 1 || bankChoice > banks.Count)
                {
                    Console.WriteLine("Invalid bank choice. Try again.");
                    continue;
                }

                // Get the selected bank
                Bank selectedBank = banks[bankChoice - 1];

                // Perform action based on user choice
                switch (choice)
                {
                    case "1":
                        OpenAccount(selectedBank); // Call method to open an account
                        break;
                    case "2":
                        ViewBalance(selectedBank); // Call method to view balance
                        break;
                    case "3":
                        ShowAccountDetails(selectedBank); // Call method to show account details
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        private void OpenAccount(Bank bank)
        {
            // Collect customer details to open an account
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();
            Console.Write("Enter initial deposit: ");
            decimal initialDeposit;
            
            // Ensure valid input for deposit amount
            if (!decimal.TryParse(Console.ReadLine(), out initialDeposit))
            {
                Console.WriteLine("Invalid deposit amount.");
                return;
            }

            bank.OpenAccount(customerName, initialDeposit); // Call bank method to open account
        }

        private void ViewBalance(Bank bank)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            bank.ViewBalance(name); // Call bank method to view balance
        }

        private void ShowAccountDetails(Bank bank)
        {
            Console.Write("Enter your account number: ");
            int accNumber;

            // Ensure valid input for account number
            if (!int.TryParse(Console.ReadLine(), out accNumber))
            {
                Console.WriteLine("Invalid account number.");
                return;
            }

            bank.ShowAccountDetails(accNumber); // Call bank method to show account details
        }
    }
}

namespace BankProject
{
    internal class Bank
    {
        public string bankName { get; } // Bank name
        private List<Account> accounts; // List of accounts in the bank
        private int accountNumber = 1000; // Auto-incrementing account number

        public Bank(string name)
        {
            bankName = name;
            accounts = new List<Account>();
        }

        public void OpenAccount(string customerName, decimal initialDeposit)
        {
            // Create a new account and add it to the accounts list
            Account newAccount = new Account(accountNumber++, customerName, initialDeposit, this);
            accounts.Add(newAccount);
            Console.WriteLine($"Account successfully created! Account Number: {newAccount.AccountNumber}");
        }

        public void ViewBalance(string customerName)
        {
            // Find all accounts associated with the customer's name
            var customerAccounts = accounts.FindAll(a => a.CustomerName == customerName);
            if (customerAccounts.Count == 0)
            {
                Console.WriteLine("No accounts found.");
                return;
            }

            Console.WriteLine($"Accounts for {customerName}:");
            foreach (var acc in customerAccounts)
            {
                Console.WriteLine($"Account No: {acc.AccountNumber}, Balance: {acc.Balance:C}");
            }
        }

        public void ShowAccountDetails(int accountNumber)
        {
            // Find the account by its number
            var account = accounts.Find(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            // Display account details
            Console.WriteLine($"Account Details:");
            Console.WriteLine($"Bank: {bankName}");
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Customer Name: {account.CustomerName}");
            Console.WriteLine($"Balance: {account.Balance:C}");
        }
    }
}

namespace BankProject
{
    class Account
    {
        public int AccountNumber { get; } // Unique account number
        public string CustomerName { get; } // Account holder's name
        public decimal Balance { get; private set; } // Account balance
        public Bank Bank { get; } // Associated bank

        public Account(int accountNumber, string customerName, decimal balance, Bank bank)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Balance = balance;
            Bank = bank;
        }
    }
}

using System;
using System.Collections.Generic;

namespace BankProject
{
    class Program
    {
        static void Main()
        {
            // Create an instance of the banking system and run the application
            BankingSystem bankingSystem = new BankingSystem();
            bankingSystem.Run();
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Opps
//{
//    class BankAccount
//    {
//        public int accountNumber; // Public: Accessible from anywhere
//        protected string accountHolder; // Protected: Accessible in derived classes
//        private double balance; // Private: Only accessible within this class

//        // Constructor
//        public BankAccount(int accountNumber, string accountHolder, double initialBalance)
//        {
//            this.accountNumber = accountNumber;
//            this.accountHolder = accountHolder;
//            this.balance = initialBalance;
//        }

//        // Public method to get balance
//        public double GetBalance()
//        {
//            return balance;
//        }

//        // Public method to deposit money
//        public void Deposit(double amount)
//        {
//            if (amount > 0)
//            {
//                balance += amount;
//                Console.WriteLine("Deposited: $" + amount + ". New Balance: $" + balance);
//            }
//            else
//            {
//                Console.WriteLine("Invalid deposit amount.");
//            }
//        }

//        // Public method to withdraw money
//        public void Withdraw(double amount)
//        {
//            if (amount > 0 && amount <= balance)
//            {
//                balance -= amount;
//                Console.WriteLine("Withdrawn: $" + amount + ". New Balance: $" + balance);
//            }
//            else
//            {
//                Console.WriteLine("Insufficient balance or invalid withdrawal amount.");
//            }
//        }

//        // Display account details
//        public virtual void DisplayAccountDetails()
//        {
//            Console.WriteLine("Account Number: " + accountNumber + ", Account Holder: " + accountHolder + ", Balance: $" + GetBalance());
//        }
//    }

//    // Subclass demonstrating use of protected member
//    class SavingsAccount : BankAccount
//    {
//        private double interestRate;

//        // Constructor
//        public SavingsAccount(int accountNumber, string accountHolder, double initialBalance, double interestRate)
//            : base(accountNumber, accountHolder, initialBalance)
//        {
//            this.interestRate = interestRate;
//        }

//        // Method to calculate interest
//        public void ApplyInterest()
//        {
//            double interest = GetBalance() * (interestRate / 100);
//            Deposit(interest);
//            Console.WriteLine("Interest of $" + interest + " applied at " + interestRate + "% rate.");
//        }

//        // Override method to display savings account details
//        public override void DisplayAccountDetails()
//        {
//            Console.WriteLine("Savings Account - Account Number: " + accountNumber + ", Account Holder: " + accountHolder + ", Balance: $" + GetBalance() + ", Interest Rate: " + interestRate + "%");
//        }
//    }

//    // Main method to test the classes
//    class Program
//    {
//        public static void Main()
//        {
//            // Creating a BankAccount object
//            BankAccount account1 = new BankAccount(101, "Ishwar Singh", 5000);
//            account1.DisplayAccountDetails();

//            // Depositing and withdrawing money
//            Console.WriteLine("\nPerforming transactions...");
//            account1.Deposit(2000);
//            account1.Withdraw(1000);
//            account1.DisplayAccountDetails();

//            // Creating a SavingsAccount object
//            SavingsAccount savings = new SavingsAccount(201, "Vishnu Kumar", 8000, 5);
//            Console.WriteLine("\nSavings Account Details:");
//            savings.DisplayAccountDetails();

//            // Applying interest
//            Console.WriteLine("\nApplying Interest...");
//            savings.ApplyInterest();
//            savings.DisplayAccountDetails();
//        }
//    }

//}

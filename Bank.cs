using System;
public class BankAccount
{
   //static variable to store the name of the bank
   private static string bankName = "SBI";

   //static variable to count the total number of accounts 
   private static int totalAccounts = 0;

   //instance variables for account details
   private string accountHolderName;
   private readonly int accountNumber;
   private double accountBalance;

   //to get bank name 
   public string GetBankName()
   {
       return bankName;
   }

   //to get account holder name 
   public string GetAccountHolderName()
   {
       return accountHolderName;
   }

   //to get account number
   public int GetAccountNumber()
   {
       return accountNumber;
   }

   //to get account balance
   public double GetAccountBalance()
   {
       return accountBalance;
   }

   //constructor to initialize account details
   public BankAccount(string accountHolderName, int accountNumber, double accountBalance)
   {
       this.accountHolderName = accountHolderName;
       this.accountNumber = accountNumber;
       this.accountBalance = accountBalance;
       totalAccounts++;
   }

   //method to get the total number of accounts
   public static void GetTotalAccounts()
   {
       Console.WriteLine("Total Accounts are: " + totalAccounts);
   }

   //method to display account details
   public void DisplayAccountDetails()
   {
       if (this is BankAccount)
       {
           Console.WriteLine("Bank Name: {0}\nAccount Holder: {1}\nAccount Number: {2}\n", GetBankName(), GetAccountHolderName(), GetAccountNumber(), GetAccountBalance());
       }
       else
           Console.WriteLine("Invalid bank account!");
   }
}

class Program1
{
   static void Main(string[] args)
   {
       //creating first bank account
       BankAccount account1 = new BankAccount("Ashish", 123456, 2450);
       //displaying account details using 'DisplayAccountDetails()' method
       account1.DisplayAccountDetails();

       //creating bank account and displaying details using 'DisplayAccountDetails' method
       BankAccount account2 = new BankAccount("Ishwar", 764859, 5500);
       account2.DisplayAccountDetails();

       //displaying total accounts
       BankAccount.GetTotalAccounts();
   }
}
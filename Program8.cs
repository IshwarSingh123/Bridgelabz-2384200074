//using System;

//class BankAccount
//{
//    public int AccountNumber { get; set; }
//    public double Balance { get; set; }

//    public BankAccount(int accountNumber, double balance)
//    {
//        AccountNumber = accountNumber;
//        Balance = balance;
//    }

//    public virtual void DisplayAccountType()
//    {
//        Console.WriteLine("General Bank Account");
//    }
//}

//class SavingsAccount : BankAccount
//{
//    public double InterestRate { get; set; }

//    public SavingsAccount(int accountNumber, double balance, double interestRate)
//        : base(accountNumber, balance)
//    {
//        InterestRate = interestRate;
//    }

//    public override void DisplayAccountType()
//    {
//        Console.WriteLine("Savings Account");
//    }
//}

//class CheckingAccount : BankAccount
//{
//    public double WithdrawalLimit { get; set; }

//    public CheckingAccount(int accountNumber, double balance, double withdrawalLimit)
//        : base(accountNumber, balance)
//    {
//        WithdrawalLimit = withdrawalLimit;
//    }

//    public override void DisplayAccountType()
//    {
//        Console.WriteLine("Checking Account");
//    }
//}

//class FixedDepositAccount : BankAccount
//{
//    public int DepositTerm { get; set; } // in months

//    public FixedDepositAccount(int accountNumber, double balance, int depositTerm)
//        : base(accountNumber, balance)
//    {
//        DepositTerm = depositTerm;
//    }

//    public override void DisplayAccountType()
//    {
//        Console.WriteLine("Fixed Deposit Account");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount savings = new SavingsAccount(1001, 5000.75, 3.5);
//        savings.DisplayAccountType();

//        BankAccount checking = new CheckingAccount(1002, 2500.50, 1000);
//        checking.DisplayAccountType();

//        BankAccount fixedDeposit = new FixedDepositAccount(1003, 10000.00, 12);
//        fixedDeposit.DisplayAccountType();
//    }
//}

// test bank program
Console.WriteLine("Welcome to Bank of Boca Code!");

BankAccount account = new BankAccount();
account.AccountNumber= "12345";

account.MakeDeposit(100);

BankAccount account2 = new SavingsAccount(500);

try {
decimal newBalance = account2.MakeDepositGetBalance(-1);
} catch(Exception ex) {
    Console.WriteLine($"We got an error when running MakeDepositGetBalance(-1)");
}

Console.WriteLine($"The Balance of account is {account.Balance}");
Console.WriteLine($"The Balance of account is {account.AccountNumber}");

Console.WriteLine($"The Balance of account2 is {account2.Balance}");

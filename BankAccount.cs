
//this is a class similar to typescript 
// public is utilized as export
public class BankAccount {
    public string AccountNumber{get;set;}

    public decimal Balance {get;set;} = 0;

    public BankAccount() {
        AccountNumber = "";
        Balance = 100;
    }//this is how we start a new bankaccount // constructors

    public BankAccount (decimal newBalance) {
        AccountNumber = "";
        Balance= newBalance;
    }

    // public void MakeDeposit(decimal amount) { //void means that it will not return a value
    //     Balance += amount;
    // }

    //handling validation 
    public void MakeDeposit (decimal amount) {
        if (amount <= 0 ){
            throw new Exception ("Doh!");
        }
        Balance += amount;
    }

    public decimal MakeDepositGetBalance(decimal amount) { //this allows for it to return
        Balance += amount;
        return Balance;
    }

    // same thing as above
    // public decimal MakeDepositGetBalance(decimal amount) { //this allows for it to return
    //     MakeDeposit;
    //     return Balance;
    // }

}

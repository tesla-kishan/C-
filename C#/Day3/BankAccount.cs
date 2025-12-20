class BankAccount
{
    public int AccNumber;
    private double Balance=0;
    public void Deposit(double amount)
    {
        Balance+=amount;
        Console.WriteLine($"Deposit was successful.Your current balance is {Balance}");
    }
    public void GetBalance()
    {
        Console.WriteLine(Balance);
    }
}


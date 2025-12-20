class Program
{
    public static void Main(string[] args)
    {
        BankAccount acc1 = new BankAccount();
        acc1.AccNumber = 12345;
        Console.WriteLine("Account Number: " + acc1.AccNumber);
        // BankAccount B1 = new BankAccount();
        // B1.deposit(50000);
        // B1.deposit(40000);

        acc1.Deposit(50000);
        acc1.GetBalance();
        
    }
}
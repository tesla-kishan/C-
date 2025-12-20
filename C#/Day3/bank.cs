using System;
class Bank
{
    private double balance;
    public void deposit(double amount)
    {
        balance += amount;
    }
    public void display()
    {
        Console.WriteLine(balance);
    }

}

class help
{
    static void Main()
    {
        Bank bank = new Bank();
        bank.deposit(1000);
        bank.display();
    }
}
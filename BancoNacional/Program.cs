public class BankAccount
{
    private long numAccount;
    private double balance;
    public long NumAccount {get => numAccount; private set => numAccount = value;}
    public double Balance {get => balance; private set => balance = value;}

    public double BalanceAccount()
    {
        return balance;
    }
    public double Deposit(double ammount)
    {
        this.Balance = balance + ammount; 
        return balance;
    }
    public double WithDraw(double ammount)
    {
        if(balance - ammount > 0)
        {
            this.Balance = balance - ammount;
        }
        else
        {
            System.Console.WriteLine("Inserte una cantidad correcta");
        }
        return balance;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        BankAccount b1 = new BankAccount();
        System.Console.WriteLine(b1.Balance);
    }
}
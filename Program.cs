namespace CSharpOOPEncapsulation;


public class BankAccount
{
    private decimal _balance;

    // README reference site explained this.
    public decimal Balance
    {
        get { return _balance; }
        private set 
        {
            if ( value >= 0 )
            {
                _balance = value;
            }
            else
            {
                Console.WriteLine("Balance cannot be negative.");
                //throw new ArgumentException("Balance cannot be negative.");
            }
        }
    }

    public BankAccount(decimal balance)
    {
        Balance = balance;
    }

    public void Deposit(decimal amount) 
    {
        if (_balance < 0)
        {
            Console.WriteLine("Invalid deposit amount.");
            return;
        }

        // set here will go into the "private set" and will be checked.
        Balance += amount;
    }

    public void Withdraw(decimal amount) 
    {
        if (amount < 0)
        {
            Console.WriteLine("Invalid withdrawal amount.");
            return;
        }

        if (amount > Balance)
        {
            Console.WriteLine($"Balance is not sufficient to withdraw");
            return;
        }

        Balance -= amount;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        BankAccount bankAccount = new BankAccount(100);

        bankAccount.Deposit(100);
        bankAccount.Withdraw(20);

        Console.WriteLine(bankAccount.Balance);
    }
}

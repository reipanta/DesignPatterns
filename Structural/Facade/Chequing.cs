namespace DesignPatterns.Structural.Facade;

public class Chequing : IAccount
{
    public Chequing(decimal amount)
    {
        
    }
    public void Deposit(decimal amount)
    {
        throw new NotImplementedException();
    }

    public void Withdraw(decimal amount)
    {
        throw new NotImplementedException();
    }

    public void Transfer(decimal amount)
    {
        throw new NotImplementedException();
    }
}
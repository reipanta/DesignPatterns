namespace DesignPatterns.Structural.Facade;

public interface IAccount
{
    public void Deposit(decimal amount);
    public void Withdraw(decimal amount);
    public void Transfer(decimal amount);
}


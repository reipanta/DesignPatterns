namespace DesignPatterns.Structural.Facade;

public class BankService
{
    private Dictionary<int, IAccount> _bankAccounts;

    public BankService()
    {
        this._bankAccounts = new Dictionary<int, IAccount>();
    }

    public int CreateNewAccount(String type, decimal initAmount)
    {
        IAccount newAccount = null;

        switch (type)
        {
            case "chequing":
                newAccount = new Chequing(initAmount);
                break;
            case "saving":
                newAccount = new Saving(initAmount);
                break;
            case "investment":
                newAccount = new Investment(initAmount);
                break;
            default:
                new System.NullReferenceException("Invalid account type");
                break;
        }
        
        /*if (newAccount != null) {
            this.bankAccounts.put(newAccount.getAccountNumber(),
                newAccount);
            return newAccount.getAccountNumber();
        }*/
        return 0;
    }
}
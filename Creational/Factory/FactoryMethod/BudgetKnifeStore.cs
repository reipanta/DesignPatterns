namespace DesignPatterns.Creational.Factory.FactoryMethod;

public class BudgetKnifeStore : KnifeStore
{
    public override Knife CreateKnife(string knifeType)
    {
        if (knifeType == "steak")
        {
            return new BudgetSteakKnife();
        }
        else if (knifeType == "chefs")
        {
            return new BudgetChefsKnife();
        } 
        
        //.. more types
        else 
            return null;
    }
}



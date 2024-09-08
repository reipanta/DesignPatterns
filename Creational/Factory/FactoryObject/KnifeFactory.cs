namespace DesignPatterns.Creational.Factory.FactoryObject;

public class KnifeFactory
{
    public Knife CreateKnife(String knifeType)
    {
        Knife knife = null;
        
        if (knifeType == "QualityKnife")
        {
            knife = new QualityKnife();
        }
        else if (knifeType == "BudgetKnife")
        {
            knife = new BudgetKnife();
        }
        
        return knife;
    }
}
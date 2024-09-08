namespace DesignPatterns.Creational.Factory.FactoryMethod;

public abstract class KnifeStore
{
    public Knife OrderKnife(String knifeType)
    {
        Knife knife;
        
        // now creating a knife is a method in the class
        knife = CreateKnife(knifeType);
        
        knife.Sharpen();
        knife.Polish();
        knife.Package();
        
        return knife;
    }

    public abstract Knife CreateKnife(string knifeType);
}


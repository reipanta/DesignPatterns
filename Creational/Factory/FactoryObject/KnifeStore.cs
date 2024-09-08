namespace DesignPatterns.Creational.Factory.FactoryObject;

public class KnifeStore
{
    private KnifeFactory factory;

    public KnifeStore(KnifeFactory factory)
    {
        this.factory = factory;
    }

    public Knife OrderKnife(String knifeType)
    {
        Knife knife;

        knife = factory.CreateKnife(knifeType);
        
        knife.Sharpen();
        knife.Polish();
        knife.Package();
       
        return knife;
    }
}


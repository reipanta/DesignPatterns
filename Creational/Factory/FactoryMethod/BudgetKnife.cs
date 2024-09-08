namespace DesignPatterns.Creational.Factory.FactoryMethod;

public class BudgetKnife : Knife
{
    public override string KnifeType { get; } = "BudgetKnife";

    public override void Polish()
    {
        throw new NotImplementedException();
    }

    public override void Sharpen()
    {
        throw new NotImplementedException();
    }

    public override void Package()
    {
        throw new NotImplementedException();
    }
}
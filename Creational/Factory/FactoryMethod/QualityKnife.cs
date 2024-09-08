namespace DesignPatterns.Creational.Factory.FactoryMethod;

public class QualityKnife : Knife
{
    public override string KnifeType { get; } = "QualityKnife";

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
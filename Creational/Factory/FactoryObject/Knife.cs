namespace DesignPatterns.Creational.Factory.FactoryObject;

public abstract class Knife
{
    public abstract String KnifeType { get; }

    public abstract void Polish();
    public abstract void Sharpen();
    public abstract void Package();
}
namespace AbstractFactoryImplementation;

// Concrete Factory A
public class ConcreteFactoryA : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }
    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB1();
    }

}

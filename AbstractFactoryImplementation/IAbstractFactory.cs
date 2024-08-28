namespace AbstractFactoryImplementation;

// Abstract Factory interface
public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}

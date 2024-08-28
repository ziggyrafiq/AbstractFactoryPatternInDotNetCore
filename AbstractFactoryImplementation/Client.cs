namespace AbstractFactoryImplementation;

public class Client
{
    private readonly IAbstractProductA _abstractProductA;
    private readonly IAbstractProductB _abstractProductB;

    public Client(IAbstractFactory factory)
    {
        _abstractProductA = factory.CreateProductA();
        _abstractProductB = factory.CreateProductB();
    }

    public string ClientCode()
    {
        var result = $"Client uses {_abstractProductA.UsefulFunctionA()} and {_abstractProductB.UsefulFunctionB()}";
        return result;
    }
}


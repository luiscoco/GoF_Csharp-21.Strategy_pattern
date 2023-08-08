using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 4: Use the context class to switch between strategies
        Context context;

        context = new Context(new ConcreteStrategyA());
        context.ExecuteStrategy();

        context = new Context(new ConcreteStrategyB());
        context.ExecuteStrategy();
    }
}

// Step 1: Define a family of algorithms using an interface
public interface IStrategy
{
    void Execute();
}

// Step 2: Encapsulate each algorithm in separate classes
public class ConcreteStrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executing Strategy A");
    }
}

public class ConcreteStrategyB : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executing Strategy B");
    }
}

// Step 3: Create a context class that uses the strategy interface
public class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        _strategy.Execute();
    }
}


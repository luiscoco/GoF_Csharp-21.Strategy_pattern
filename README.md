# GoF_Csharp-21.Strategy_pattern

The Strategy Pattern is a design pattern in object-oriented programming that allows you to define a family of algorithms, encapsulate each algorithm in a separate class, and make them interchangeable at runtime. This pattern promotes the concept of "composition over inheritance" by favoring composition (using objects that implement certain behaviors) over using inheritance to achieve different variations of behavior.

Here's a simple explanation of the Strategy Pattern:

Define a family of algorithms: Identify a set of related algorithms or behaviors that can be used interchangeably.

Encapsulate each algorithm: Create separate classes for each algorithm, encapsulating their implementation details.

Make them interchangeable: Define an interface that all algorithm classes must implement. This interface ensures that different algorithm classes can be used interchangeably.

Use a context class: Create a context class that contains a reference to the interface. This class can switch between different algorithms dynamically.

```csharp
using System;

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
```

## How to setup Github actions

![Csharp Github actions](https://github.com/luiscoco/GoF_Csharp-16.Iterator_pattern/assets/32194879/1263a83b-d11c-4a48-ad5c-c22eecd42836)








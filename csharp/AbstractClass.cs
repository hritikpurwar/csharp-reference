namespace csharp;

public abstract class AbstractClass
{
    public abstract void Print();
}

public class NewClass : AbstractClass
{
    public override void Print()
    {
        Console.WriteLine("print method");
    }
}
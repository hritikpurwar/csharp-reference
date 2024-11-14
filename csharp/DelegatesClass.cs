namespace csharp;

public class DelegatesClass
{
    private static void Hello(string strMessage)
    {
        Console.WriteLine($"Hello {strMessage}");
    }

    public void Call()
    {
        HelloFunctionDelegate del = new(Hello);
        del("World");
    }
}

public delegate void HelloFunctionDelegate(string message);
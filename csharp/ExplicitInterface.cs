namespace csharp;

public interface I1
{
    void InterfaceMethod();
}

public interface I2
{
    void InterfaceMethod();
}
public class Implements : I1, I2
{
    void I1.InterfaceMethod()
    {
        Console.WriteLine("I1 interface method");
    }

    void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 interface method");    
    }
}
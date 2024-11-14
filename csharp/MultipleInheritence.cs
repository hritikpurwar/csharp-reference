namespace csharp;

public interface IA
{
    void AMethod();
}

public class A : IA
{
    public void AMethod()
    {
        Console.WriteLine("A");
    }
}

public interface IB
{
    void BMethod();
}

public class B: IB
{
    public void BMethod()
    {
        Console.WriteLine("B");
    }
}

public class AB: IA, IB
{
    private A a = new();
    private B b = new();

    public void AMethod()
    {
        a.AMethod();
    }

    public void BMethod()
    {
        b.BMethod();
    }
}
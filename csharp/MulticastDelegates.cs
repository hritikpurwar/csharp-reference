namespace csharp;

public delegate void SampleDelegate();

public delegate int ReturningDelegate();

public class MulticastDelegates
{
    public static void SampleMethodOne()
    {
        Console.WriteLine("SampleMethodOne Invoked");
    }

    public static void SampleMethodTwo()
    {
        Console.WriteLine("SampleMethodTwo Invoked");
    }

    public static void SampleMethodThree()
    {
        Console.WriteLine("SampleMethodThree Invoked");
    }

    public static int ReturningMethodOne()
    {
        Console.WriteLine("ReturningMethodOne invoked");
        return 1;
    }

    public static int ReturningMethodTwo()
    {
        Console.WriteLine("ReturningMethodTwo invoked");
        return 2;
    }
}
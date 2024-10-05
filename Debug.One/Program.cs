internal class Program
{
    private static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 0;

        Console.WriteLine("Program startat.");
        int result = DivideNumbers(num1, num2);

        Console.WriteLine($"Resultatet av divisionen är: {result}");

    }
    private static int DivideNumbers(int a, int b)
    {
        Console.WriteLine($"Försöker dividera {a} med {b}");
        return a / b;
    }
}
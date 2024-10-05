using System;

namespace Debug.Two;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program startat.");

        Calculator calculator = new Calculator();
        Logger logger = new Logger();

        int num1 = 20;
        int num2 = 5;

        logger.Log($"Försöker addera {num1} och {num2}");
        int sum = calculator.Add(num1, num2);
        logger.Log($"Summan är: {sum}");

        logger.Log($"Försöker dividera {num1} med {num2}");
        int divisionResult = calculator.Divide(num1, num2);
        logger.Log($"Resultatet av divisionen är: {divisionResult}");

        // Introducera en bugg med felaktiga värden
        logger.Log($"Försöker dividera {num1} med 0 (felaktig operation).");
        int faultyDivisionResult = calculator.Divide(num1, 0); // Bug här!
        logger.Log($"Felaktigt divisionsresultat: {faultyDivisionResult}");
    }
}
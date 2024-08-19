using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе числ:");
            int b = int.Parse(Console.ReadLine());

            int result = calculator.Add(a, b);
            Console.WriteLine($"Результат: {result}");
        }
    }
}

using System;

namespace SumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть перше число:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Введіть друге число:");
            string input2 = Console.ReadLine();

            try
            {
                double number1 = Convert.ToDouble(input1);
                double number2 = Convert.ToDouble(input2);

                double sum = number1 + number2;

                Console.WriteLine($"Сума {number1} і {number2} дорівнює {sum}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Будь ласка, введіть коректні числові значення.");
            }

            Console.WriteLine("Натисніть будь-яку клавішу, щоб закрити програму.");
            Console.ReadKey();
        }
    }
}
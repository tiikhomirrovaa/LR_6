using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Приветственное сообщение
            Console.WriteLine("Добро пожаловать в простой калькулятор!");
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор (+, -, *, /):");
            char operation = Console.ReadLine()[0];

            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Неправильный оператор");
                    break;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}

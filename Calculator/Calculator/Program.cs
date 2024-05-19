using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простой консольный калькулятор");

            try
            {
                // Ввод первого числа
                Console.WriteLine("Введите первое число:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                // Ввод оператора
                Console.WriteLine("Введите оператор (+, -, *, /):");
                char operation = Console.ReadLine()[0];

                // Ввод второго числа
                Console.WriteLine("Введите второе число:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Вычисление результата в зависимости от оператора
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

                // Вывод результата
                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите корректное число.");
            }
        }
    }
}

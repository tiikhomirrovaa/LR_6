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
            // Запрос на завершение работы программы
            Console.WriteLine("Хотите завершить работу программы? (Y / N)");
            char choice = Char.ToUpper(Console.ReadKey().KeyChar);

            // Проверка выбора пользователя
            if (choice == 'Y')
            {
                Console.WriteLine("\nРабота программы завершена.");
            }
            else if (choice == 'N')
            {
                Console.WriteLine("\nПрограмма продолжает работу.");
                // Возможно, здесь вы хотите вернуться к калькулятору или выполнить другие действия.
            }
            else
            {
                Console.WriteLine("\nНеверный ввод. Программа продолжает работу.");
                // Возможно, здесь вы хотите снова задать вопрос или выполнить другие действия.
            }
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Калькулятор перевода чисел между системами исчисления");
            Console.WriteLine("Выберите направление перевода:");
            Console.WriteLine("1. Из десятичной в двоичную");
            Console.WriteLine("2. Из десятичной в восьмеричную");
            Console.WriteLine("3. Из десятичной в шестнадцатеричную");
            Console.WriteLine("4. Из двоичной в десятичную");
            Console.WriteLine("5. Из восьмеричной в десятичную");
            Console.WriteLine("6. Из шестнадцатеричной в десятичную");
            Console.WriteLine("0. Выход");
            Console.Write("Ваш выбор: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Неправильный ввод, попробуйте снова.");
                Console.ReadLine();
                continue;
            }

            if (choice == 0)
            {
                break;
            }

            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case 1:
                        int decimalNumber = int.Parse(input);
                        Console.WriteLine($"Двоичное представление: {Convert.ToString(decimalNumber, 2)}");
                        break;
                    case 2:
                        decimalNumber = int.Parse(input);
                        Console.WriteLine($"Восьмеричное представление: {Convert.ToString(decimalNumber, 8)}");
                        break;
                    case 3:
                        decimalNumber = int.Parse(input);
                        Console.WriteLine($"Шестнадцатеричное представление: {Convert.ToString(decimalNumber, 16)}");
                        break;
                    case 4:
                        int binaryNumber = Convert.ToInt32(input, 2);
                        Console.WriteLine($"Десятичное представление: {binaryNumber}");
                        break;
                    case 5:
                        int octalNumber = Convert.ToInt32(input, 8);
                        Console.WriteLine($"Десятичное представление: {octalNumber}");
                        break;
                    case 6:
                        int hexNumber = Convert.ToInt32(input, 16);
                        Console.WriteLine($"Десятичное представление: {hexNumber}");
                        break;
                    default:
                        Console.WriteLine("Неправильный выбор, попробуйте снова.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неправильный формат числа.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Число выходит за пределы допустимого диапазона.");
            }

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
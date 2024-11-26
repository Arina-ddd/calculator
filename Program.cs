using System;
using System.Collections.Generic;

class Calculator
{
    // Список для хранения истории вычислений
    static List<string> history = new List<string>();

    // Базовые арифметические операции
    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("деление на ноль.");
        return a / b;
    }

    // Расширенные математические функции
    static double Power(double baseNum, double exponent) => Math.Pow(baseNum, exponent);
    static double Sqrt(double number)
    {
        if (number < 0)
            throw new InvalidOperationException("извлечение квадратного корня из отрицательного числа.");
        return Math.Sqrt(number);
    }

    static double Sin(double angle) => Math.Sin(angle);
    static double Cos(double angle) => Math.Cos(angle);
    static double Tan(double angle) => Math.Tan(angle);
    static double Asin(double value) => Math.Asin(value);
    static double Acos(double value) => Math.Acos(value);
    static double Atan(double value) => Math.Atan(value);
    static double Cot(double angle) => 1 / Math.Tan(angle);
    static double Acot(double value) => Math.PI / 2 - Math.Atan(value);

    // Метод для вывода меню
    static void PrintMenu()
    {
        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1. Сложение (+)");
        Console.WriteLine("2. Вычитание (-)");
        Console.WriteLine("3. Умножение (*)");
        Console.WriteLine("4. Деление (/)");
        Console.WriteLine("5. Возведение в степень (x^y)");
        Console.WriteLine("6. Извлечение квадратного корня (√x)");
        Console.WriteLine("7. Синус (sin)");
        Console.WriteLine("8. Косинус (cos)");
        Console.WriteLine("9. Тангенс (tan)");
        Console.WriteLine("10. Арксинус (asin)");
        Console.WriteLine("11. Арккосинус (acos)");
        Console.WriteLine("12. Арктангенс (atan)");
        Console.WriteLine("13. Котангенс (cot)");
        Console.WriteLine("14. Арккотангенс (acot)");
        Console.WriteLine("15. Показать историю");
        Console.WriteLine("16. Выход");
        Console.Write("Введите номер операции: ");
    }

    // Метод для добавления записи в историю
    static void AddToHistory(string operation)
    {
        history.Add(operation);
    }

    // Метод для отображения истории
    static void ShowHistory()
    {
        Console.WriteLine("История вычислений:");
        if (history.Count == 0)
        {
            Console.WriteLine("История пуста.");
        }
        else
        {
            foreach (var item in history)
            {
                Console.WriteLine(item);
            }
        }
    }

    // Метод для работы с калькулятором
    static void RunCalculator()
    {
        while (true)
        {
            PrintMenu();
            string choice = Console.ReadLine();
            double num1, num2;
            double result;
            string operation;

            try
            {
                switch (choice)
                {
                    case "1":
                        Console.Write("Введите первое число: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = Add(num1, num2);
                        operation = $"{num1} + {num2} = {result}";
                        AddToHistory(operation);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "2":
                        Console.Write("Введите первое число: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = Subtract(num1, num2);
                        operation = $"{num1} - {num2} = {result}";
                        AddToHistory(operation);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "3":
                        Console.Write("Введите первое число: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = Multiply(num1, num2);
                        operation = $"{num1} * {num2} = {result}";
                        AddToHistory(operation);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "4":
                        Console.Write("Введите первое число: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = Divide(num1, num2);
                        operation = $"{num1} / {num2} = {result}";
                        AddToHistory(operation);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "5":
                        Console.Write("Введите основание (x): ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите показатель степени (y): ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = Power(num1, num2);
                        operation = $"{num1} ^ {num2} = {result}";
                        AddToHistory(operation);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "6":
                        Console.Write("Введите число для извлечения квадратного корня: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = Sqrt(num1);
                        operation = $"√{num1} = {result}";
                        AddToHistory(operation);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "7":
                        Console.Write("Введите угол в радианах для вычисления синуса: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = Sin(num1);
                        operation = $"sin({num1}) = {result}";
                        AddToHistory(operation);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "8":
                        Console.Write("Введите угол в радианах для вычисления косинуса: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = Cos(num1);
                        operation = $"cos({num1}) = {result}";
                        AddToHistory(operation);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "9":
                        Console.Write("Введите угол в радианах для вычисления тангенса: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = Tan(num1);
                        operation = $"tan({num1}) = {result}";
                        AddToHistory(operation);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "10":
                        Console.Write("Введите число для вычисления арксинуса: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = Asin(num1);
                        operation = $"asin({num1}) = {result}";
                        AddToHistory(operation);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "11":
                        Console.Write("Введите число для вычисления арккосинуса: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = Acos(num1);
                        operation = $"acos({num1}) = {result}";
                        AddToHistory(operation);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "12":
                        Console.Write("Введите число для вычисления арктангенса: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = Atan(num1);
                        operation = $"atan({num1}) = {result}";
                        AddToHistory(operation);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "13":
                        Console.Write("Введите угол в радианах для вычисления котангенса: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = Cot(num1);
                        operation = $"cot({num1}) = {result}";
                        AddToHistory(operation);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "14":
                        Console.Write("Введите число для вычисления арккотангенса: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = Acot(num1);
                        operation = $"acot({num1}) = {result}";
                        AddToHistory(operation);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "15":
                        ShowHistory();
                        break;

                    case "16":
                        Console.WriteLine("Выход из программы...");
                        return;

                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите корректную операцию.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void Main()
    {
        Console.WriteLine("Добро пожаловать в калькулятор!");
        RunCalculator();
    }
}

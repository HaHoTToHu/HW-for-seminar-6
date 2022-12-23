/*Задача 41: Пользователь вводит с 
клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

// Console.WriteLine("Введите количество чисел: ");
// int digit = Convert.ToInt32(Console.ReadLine());
// MoreThanZero(digit);

// void MoreThanZero(int num)
// {
//     int count = 0;

//     for (int i = 0; i < digit; i++)
//     {
//         Console.WriteLine("Введите число: ");
//         int numbers = Convert.ToInt32(Console.ReadLine());

//         if(numbers > 0)
//         {
//              count += 1;
//         }
//     } 
//     Console.Write($"Чисел, больше, чем ноль: {count}");

// }

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/

// void TwoLines(double b1, double k1, double b2, double k2)
// {
//     double x = Math.Round((-(b1 - b2) / (k1 - k2)), 2);
//     double y = Math.Round((k1 * x + b1), 2);

//     Console.WriteLine($"Точка пересечения двух прямых равна: ({x};{y})");
// }

// Console.Write("Введите число b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// TwoLines(b1, k1, b2, k2);
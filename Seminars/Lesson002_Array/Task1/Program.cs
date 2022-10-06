/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8 */

Console.Clear();

System.Console.Write("Введите число: ");
// int random = new Random().Next(100, 10000000); // Решение через заданный интервал
int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(number);
int result = number % 10;

System.Console.Write($"{result} - последняя цифра числа {number}");

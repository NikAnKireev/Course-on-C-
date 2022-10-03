/* Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
Например:
4-> 16
3 -> 9
7 -> 49 */

using System;
Console.Clear();

Console.WriteLine("Введите число:");
int number1 = Convert.ToInt32 (Console.ReadLine());

int square= number1 * number1;

Console.WriteLine($"{number1} -> {square}");
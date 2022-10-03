/* Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
все чётные числа от 1 до N. */

using System;
Console.Clear();

Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count <= numberN)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count++;
}

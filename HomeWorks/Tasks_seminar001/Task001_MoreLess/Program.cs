﻿using System;
Console.Clear();

/* Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее. */

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) Console.WriteLine($"{number1} > {number2}");
else
{
if(number1 == number2) Console.WriteLine($"{number1} = {number2}");
else
{
  Console.WriteLine($"{number2} > {number1}");
}
}
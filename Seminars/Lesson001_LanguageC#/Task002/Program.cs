// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3> Среда
// 5 -> Пятница

// Решение через массив.
/*using System;
Console.Clear();

Console.Write("Введите число дня недели: ");
int weeks = Convert.ToInt32(Console.ReadLine());
string [] arrayDay = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };

if (weeks < 1 || weeks > 7)
{
    Console.WriteLine("Такого дня недели не существует.");
}
else
{
    Console.Write(arrayDay[weeks - 1]);
} */

//Решение через if
/*using System;
Console.Clear();

Console.Write("Введите число дня недели: ");
int weeks = Convert.ToInt32(Console.ReadLine());

if (weeks == 1)
{
    Console.WriteLine("Понедельник");
}
if (weeks == 2)
{
    Console.WriteLine("Вторник");
}
if (weeks == 3)
{
    Console.WriteLine("Среда");
}
if (weeks == 4)
{
    Console.WriteLine("Четверг");
}
if (weeks == 5)
{
    Console.WriteLine("Пятница");
}
if (weeks == 6)
{
    Console.WriteLine("Суббота");
}
if (weeks == 7)
{
    Console.WriteLine("Воскресение");
}
if (weeks < 1 || weeks > 7)
{
    Console.WriteLine("Такого дня недели не существует.");
} */

// Решение через switch/break
using System;
Console.Clear();

Console.Write("Введите число дня недели: ");
int weeks = Convert.ToInt32(Console.ReadLine());

switch (weeks)
{
  case 1: Console.WriteLine("Понедельник");
  break;
  case 2: Console.WriteLine("Вторник");
  break;
  case 3: Console.WriteLine("Среда");
  break;
  case 4: Console.WriteLine("Четверг");
  break;
  case 5: Console.WriteLine("Пятница");
  break;
  case 6: Console.WriteLine("Суббота");
  break;
  case 7: Console.WriteLine("Воскресение");
  break;
}

if (weeks < 1 || weeks > 7)
{
    Console.WriteLine("Такого дня недели не существует.");
}
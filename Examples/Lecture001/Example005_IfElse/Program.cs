using System;

Console.WriteLine("Введите ваше имя:");
string username = Console.ReadLine();

if (username.ToLower() == "никита")
{
    Console.WriteLine("Рады видет вас снова, Никита!");
}
else
{
    Console.Write("Здравствуйте, ");
    Console.Write(username);
}
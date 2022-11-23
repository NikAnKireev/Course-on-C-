/* Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Использовать рекурсию.
453 -> 12
45 -> 9 */

Console.Clear();

int Prompt(string message)
{
    Console.Write(message + " > ");
    return int.Parse(Console.ReadLine());
}

int PrintNumbers(int number)
{
    if (number <= 0)
    {
        return 0;
    }
    return number % 10 + PrintNumbers(number / 10);
}

int number = Prompt("Введите число");
int sum = PrintNumbers(number);
Console.WriteLine($"{number} > {sum}");
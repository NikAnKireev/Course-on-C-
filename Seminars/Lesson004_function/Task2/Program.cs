/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

Console.Clear();

int InputNumber(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

int Count(int number)
{
    int result = 0;
    while (number > 0)
    {
        number = number / 10;
        result++;
    }
    return result;
}

int number = InputNumber("Введите число -> ");
int result = Count(number);
System.Console.WriteLine($"{result}");
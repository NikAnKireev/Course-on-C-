/* ывести следующий ряд последовательности:

1, 2, 2, 3, 3, 3,..., 10 */

Console.Clear();

int InputNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintCountNumber(int number)
{
    for (int i = 0; i <= number; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write($"{i}\t ");
    }
}
}

int number = InputNumber("Введите число: ");
PrintCountNumber(number);
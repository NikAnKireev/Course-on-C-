/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
Функция должна на вход принимать число, а выдавать сумму его цифр

452 -> 11

82 -> 10

9012 -> 12 */

Console.Clear();

int[] ElementsCount(string messag) // Вместо команды new int [count]
{
    System.Console.Write(messag);
    int number = int.Parse(Console.ReadLine());
    int[] myArray = new int[number];
    return myArray;
}

void FillArray(int[] values)
{
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.Write("-> ");
}

void SumNumbers(int[] array)
{
    int value = array[0];
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        sum = value + array[i];
        value = sum;
    }
    System.Console.WriteLine(value);
}

int[] array = ElementsCount("Введите количество элемента массива: ");
FillArray(array);
PrintArray(array);
SumNumbers(array);
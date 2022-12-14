/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4 */

Console.Clear();

int InputNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] RandomMatrixFill(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int SearchNumberInMatrix(int index1, int index2, int[,] array)
{
    return array[index1, index2];
}

int firstNumber = InputNumber("Задайте количество строк: ");
int secondNumber = InputNumber("Задайте количество столбцов: ");

Console.WriteLine();

int[,] myMatrix = RandomMatrixFill(firstNumber, secondNumber);
PrintMatrix(myMatrix);

Console.WriteLine("\nИНДЕКСЫ НАЧИНАЮТСЯ С 0!");

int row = InputNumber("\nВведите искомый индекс строк: ");
int column = InputNumber("Введите искомый индекс столбцов: ");

if (row < 0 || row > myMatrix.GetLength(0) - 1 || column < 0 || column > myMatrix.GetLength(0) - 1)
{
    Console.WriteLine($"\n[{row}, {column}] -> Числа по заданному индексу не существует!");
}
else
{
    Console.Write($"[{row}, {column}] -> ");
    int result = SearchNumberInMatrix(row, column, myMatrix);
    Console.WriteLine(result);
}
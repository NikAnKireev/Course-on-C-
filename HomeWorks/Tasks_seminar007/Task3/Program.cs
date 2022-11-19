/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

double[] ArithmeticAverage(int[,] matrix)
{
    double[] average = new double[matrix.GetLongLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        average[i] = 0;

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            average[i] += matrix[j, i];
        }
        average[i] /= matrix.GetLength(0);
    }
    return average;
}

void PrintArray(double[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item:f1}\t");
    }
}

int firstNumber = InputNumber("Задайте количество строк: ");
int secondNumber = InputNumber("Задайте количество столбцов: ");

Console.WriteLine();

int[,] myMatrix = RandomMatrixFill(firstNumber, secondNumber);
PrintMatrix(myMatrix);
Console.WriteLine("\nСреднеарифметическое столбцов:");
PrintArray(ArithmeticAverage(myMatrix));
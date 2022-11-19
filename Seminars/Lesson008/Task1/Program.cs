/* Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. */

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
            array[i, j] = random.Next(-10, 10);
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

int[,] ChangeMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLongLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
    return matrix;
}

int row = InputNumber("Введите количество строк: ");
int column = InputNumber("Введите количество столбцов: ");

int[,] myArray = RandomMatrixFill(row, column);
PrintMatrix(myArray);
System.Console.WriteLine();
PrintMatrix(ChangeMatrix(myArray));
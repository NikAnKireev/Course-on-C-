/*  Задайте двумерный массив. Найдите сумму элементов главной диагонали.
Например, задан массив:
1   4   7
5   9   2
8   4   2
Сумма элементов главной диагонали: 1+9+2 = 12 */

Console.Clear();

int[,] RandomMatrixFill(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 6);
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

int SumDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, i];
    }
    return sum;
}
int[,] array = RandomMatrixFill(5, 5);
PrintMatrix(array);
Console.Write("\nСумма по диагонали: ");
Console.WriteLine(SumDiagonal(array));

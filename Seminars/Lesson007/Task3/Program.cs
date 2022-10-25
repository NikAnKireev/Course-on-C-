/* Задача 2: Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты

1 4 7 2
5 9 2 3
8 4 2 4

вот так:

1 4 7 2
5 81 2 9
8 4 2 4 */

Console.Clear();

double[,] CreateArray(int lenRows, int lenColumns)
{
    double[,] array = new double[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-6, 6);
        }
    }
    return array;
}

void PrintArray(double[,] array)
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

double[,] EvalationInSquare(double[,] array)
{
    {
        for (int i = 1; i < array.GetLength(0); i += 2)
        {
            for (int j = 1; j < array.GetLength(1); j += 2)
            {
                array[i, j] = Math.Pow(array[i, j], 2);
            }
        }
    }
    Console.WriteLine();
    return array;
}

double[,] array = CreateArray(3, 4);
PrintArray(array);
double[,] newArray = EvalationInSquare(array);
PrintArray(newArray);
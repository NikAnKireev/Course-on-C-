/* Найти минимальное число в двумерной матрице */

Console.Clear();

int[,] CreateArray(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-3, 6);
        }
    }
    return array;
}

void PrintArray(int[,] array)
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

int Min(int[,] array)
{
    int min = array[0, 0]; // Присваеваем минимальное значение в переменную
    foreach (int item in array) // item - искомое значение в масиве начиная с первого элемента в массиве
    {
        if (item < min)
        {
            min = item;
        }
    }
    return min;
}

int[,] array = CreateArray(3, 4);
PrintArray(array);
int min = Min(array);
Console.Write($"\nМинимальное значение в массиве: {min}\n");
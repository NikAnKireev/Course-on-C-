/* адача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

Console.Clear();

int[,] CreateArray(int lenRows, int lenColumns)
{
int[,] array = new int[lenRows, lenColumns];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = random.Next(-5, 6);
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

int[,] array = CreateArray(3, 4);
PrintArray(array);
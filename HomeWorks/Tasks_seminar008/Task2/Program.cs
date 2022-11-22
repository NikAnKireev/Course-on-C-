/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

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

bool CheckingMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1)) return false;
    else return true;
}

int ElementSum(int[,] matrix, int index)
{
    int sum = matrix[index, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sum += matrix[index, j];
    }
    return sum;
}

void SearchMinSum(int[,] array)
{
    int row = 0;
    int min = ElementSum(array, 0);

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int max = ElementSum(array, i);
        if (min > max)
        {
            min = max;
            row = i;
        }
    }
    Console.WriteLine($"\n{row + 1} - строкa с наименьшей суммой ({min}) элементов ");
}

int[,] myMatrix = RandomMatrixFill(4, 3);
PrintMatrix(myMatrix);
Console.WriteLine();


if (CheckingMatrix(myMatrix))
{
    SearchMinSum(myMatrix);
}
else
{
    Console.WriteLine("Матрица не прямоугольная!");
}
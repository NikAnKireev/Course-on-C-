/* Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя. */

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

bool ValidateMatrix(int[,] arrayMatrix)
{
    if (arrayMatrix.GetLongLength(0) == arrayMatrix.GetLength(1)) return true;
    return false;
}

int[,] TranponateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLongLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
    return matrix;
}

int row = InputNumber("Введите количество строк: ");
int column = InputNumber("Введите количество столбцов: ");

int[,] myArray = RandomMatrixFill(row, column);
PrintMatrix(myArray);
Console.WriteLine();

if (ValidateMatrix(myArray))
{
    PrintMatrix(TranponateMatrix(myArray));
}
else
{
    Console.WriteLine("Матрица не квадратная!");
}
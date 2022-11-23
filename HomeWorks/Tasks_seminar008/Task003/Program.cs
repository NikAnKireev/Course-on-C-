/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц */

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

bool CheckingMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0)) return false;
    else return true;
}

int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix)
{
    int[,] resultMatrix = new int[firstMartrix.GetLength(0), secondMartrix.GetLength(1)];

    for (int i = 0; i < firstMartrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMartrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < secondMartrix.GetLength(0); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}

int[,] firstMatrix = RandomMatrixFill(3, 5);
int[,] secondMatrix = RandomMatrixFill(5, 5);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();

if (CheckingMatrix(firstMatrix, secondMatrix))
{
    int[,] resultMatrix = MultiplyMatrix(firstMatrix, secondMatrix);
    PrintMatrix(resultMatrix);
}
else
{
    Console.WriteLine("Матрицы не равны, невозможно перемножить!");
}
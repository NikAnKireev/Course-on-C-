/* Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7 */

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
            array[i, j] = random.Next(1, 10);
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

(int, int) SearchMinimum(int[,] theMatrix)
{
    int indRow = 0;
    int indColumn = 0;

    for (int i = 0; i < theMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < theMatrix.GetLength(1); j++)
        {
            if (theMatrix[i, j] < theMatrix[indRow, indColumn])
            {
                indRow = i;
                indColumn = j;
            }
        }
    }
    return (indRow, indColumn);
}

int[,] DeliteRowColumn(int[,] maitrix)
{
    int[,] result = new int[maitrix.GetLength(0) - 1, maitrix.GetLength(1) - 1];
    (int minRow, int minColumn) = SearchMinimum(maitrix);
    int a = 0;
    int b = 0;

    for (int i = 0; i < maitrix.GetLength(0); i++)
    {
        if (i != minRow)
        {
            b = 0;
            for (int j = 0; j < maitrix.GetLength(1); j++)
            {

                if (i == minRow || j == minColumn)
                {

                }
                else
                {
                    result[a, b] = maitrix[i, j];
                    b++;
                }
            }
            a++;
        }
    }
    return result;
}

int row = InputNumber("Введите количество строк: ");
int column = InputNumber("Введите количество столбцов: ");

int[,] myMatrix = RandomMatrixFill(row, column);
PrintMatrix(myMatrix);
Console.WriteLine();
Console.WriteLine(SearchMinimum(myMatrix) + " -> Индекс минимального значения.");

Console.WriteLine();
PrintMatrix(DeliteRowColumn(myMatrix));
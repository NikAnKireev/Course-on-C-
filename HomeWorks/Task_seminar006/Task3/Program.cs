/* Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

1 2 3
3 4 5
3+5=8, 1+2+3=6, 8-6=2 */

Console.Clear();

int[,] InputMatrix(string row, string column)
{
    Console.Write(row);
    int countRow = int.Parse(Console.ReadLine());

    Console.Write(column);
    int countColumn = int.Parse(Console.ReadLine());

    int[,] array = new int[countRow, countColumn];
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void PrintMatrix(int[,] array)
{
    Console.WriteLine("\nВывод массива: ");

    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++) // метод для получения длины одномерного массива
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-9, 10);
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] MaxNumberRow(int[,] array)
{
    int maxNumber = 0;
    int[] newArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > maxNumber)
            {
                maxNumber = array[i, j];
            }
        }
        newArray[i] = maxNumber;
        maxNumber = 0;
    }
    return newArray;
}

int[] MinNumberColumn(int[,] array)
{
    int max = Sum(MaxNumberRow(array));
    int minNumber = max;
    int[] newArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (array[j, i] < minNumber)
            {
                minNumber = array[j, i];
            }
        }
        newArray[i] = minNumber;
        minNumber = max;
    }
    return newArray;
}

int Sum(int[] value)
{
    int result = 0;

    for (int i = 0; i < value.Length; i++)
    {
        result = result + value[i];
    }
    return result;
}

int Subduction(int arg1, int arg2)
{
    int decision = arg1 - arg2;
    Console.Write(decision);
    return decision;
}

int[,] myArray = InputMatrix("\nВведите количество строк: ", "\nВведите количество столбцов: ");
PrintMatrix(myArray);
Console.Write("\nМаксимальные числа в строках: ");
PrintArray(MaxNumberRow(myArray));
Console.Write("Минимальные числа в столбцах: ");
PrintArray(MinNumberColumn(myArray));
Console.Write("\nСумма чисел: ");
Subduction(Sum(MaxNumberRow(myArray)), Sum(MinNumberColumn(myArray)));
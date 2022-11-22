/* Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных. Значения элементов массива 0..9 */

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
            array[i, j] = random.Next(0, 9);
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

int[] Dictionary(int[,] matrix)
{
    int[] dict = new int[10];

    foreach (var item in matrix)
    {
        dict[item]++;
    }
    return dict;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}

int row = InputNumber("Введите количество строк: ");
int column = InputNumber("Введите количество столбцов: ");

int[,] myMatrix = RandomMatrixFill(row, column);
PrintMatrix(myMatrix);
Console.WriteLine();

int[] number = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
PrintArray(number);

Console.WriteLine();

int[] dict = Dictionary(myMatrix);
PrintArray(dict);
/* Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали, 
или напишите, что такого элемента нет.
Например, такой массив:
1 4 7 2
5 9 2 3
8 4 2 4

Введенный элемент 2, результат: [1, 4]

Введенный элемент 6, результат: такого элемента нет. */

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

(int, int) CoordinateMatrix(int number, int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                return (i, j); // функция возвращает два значения
            }
        }
    }
    return (-1, -1); // если не сработает первый return
}

int[,] myArray = RandomMatrixFill(3, 4);
PrintMatrix(myArray);
int number = InputNumber("\nВведите искомое число: ");
(int line, int column) = CoordinateMatrix(number, myArray);

if (line == -1)
{
    Console.WriteLine("Такого числа нет.");
}
else
{
    Console.WriteLine($"Координаты искомого числа: [{line + 1},{column + 1}]");
}
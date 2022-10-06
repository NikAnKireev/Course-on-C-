Console.Clear();

void FillArray(int[] collection) // Метод заполнения массива
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // Метод печати массива 

{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");

        position++;
    }
}

int IndexOf(int[] collection, int find) // Метод поиска числа по индексу из массива и сравнение с заданным числом
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Искуственный прием, если нужного элемента нет, ставим -1
    while (index < count)
    {
        if (collection[index] == find)
        {
          position = index;
          break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // Создай массив, в котором будет 10 элементов(new int [количество элементов])

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
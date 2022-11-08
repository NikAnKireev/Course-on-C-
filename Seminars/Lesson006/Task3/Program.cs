/* Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

Console.Clear();

int InputNumber(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] Binarny(int number)
{
    int[] array = new int[10];
    int count = array.Length - 1;
    while (number > 0)
    { 
        array[count] = number % 2;
        number /= 2;
        count --;
    } 
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int a = InputNumber("Введите число: ");
PrintArray(Binarny(a));

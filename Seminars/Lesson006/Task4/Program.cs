/*Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

Console.Clear();

int InputNumber(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] Fibonachi(int len)
{
    int[] array = new int[len];
    int temp1 = 0;
    int temp2 = 1;
    for (int i = 2; i < array.Length - 1; i++)
    {
        array[i] = temp1;
        sum = temp1 + temp2;

    }
}

// int tmp1 = 0;
// int tmp2 = 1;

// while(count  > 0)
// {
//    int tmp = tmp1 + tmp2;
//    System.Console.WriteLine($"{tmp1}");
//    tmp1 = tmp2;
//    tmp2 = tmp;
//    count--;
// }

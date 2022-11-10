// Поиск максимума из введенных чисел с помощью массива

Console.Clear();
int Max(int arg1, int arg2, int arg3) // Функция в которую чтото можно положить и чтото вернуть.
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;

}

//               0   1   2   3   4   5   6   7   8    № index
int[] array = { 51, 72, 13, 64, 475, 26, 67, 98, 19 };

// array[0] = 12;  Обращаемся к массиву и записываем в него значение по указанному индексу

// Console.WriteLine(array[4]);  Вызываем элемент массива по его индексу

// int max1 = Max(a1, b1, c1); // Положили в функию значения a1, b1, c1
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1,max2, max3);
// Или можем заменить одной строкой

// int lenght = array.Length;

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(result);
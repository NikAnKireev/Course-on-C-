// Поиск максимума из введенных чисел

int Max(int arg1, int arg2, int arg3) // Функция в которую чтото можно положить и чтото вернуть.
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;

}
int a1 = 115;
int b1 = 16;
int c1 = 98;
int a2 = 71;
int b2 = 85;
int c2 = 37;
int a3 = 44;
int b3 = 8569;
int c3 = 6;

// int max1 = Max(a1, b1, c1); // Положили в функию значения a1, b1, c1
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1,max2, max3);
// Или можем заменить одной строкой

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);


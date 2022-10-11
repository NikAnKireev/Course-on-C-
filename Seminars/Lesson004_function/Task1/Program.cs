/*Задача 1: Напишите программу, которая принимает на вход число (А) и 
выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

Console.Clear();

// Ввод числа по приглашению
int InputNumber(string message)
{
    System.Console.Write(message);                              // Вывод приглашения
    string str = Console.ReadLine();                            // Читаем строку с консоли
    return int.Parse(str);                                      // преобразуем строку в число
}

// Сумма чисел от 1 до number
int SumNumbers(int number)
{
    int sum = 0;                           // тут накапливаем сумму
    for (int i = 1; i <= number; i++)      // Цикл от 1 до number
    {
        sum = sum + i; // сумируем
    }
    return sum; //возврат суммы из метода
}

// Проверка на правильность ввода
bool ValidateNumber(int number)
{
    if (number < 1)
    {
        System.Console.WriteLine("Число меньше единицы!");
        return false;
    }
    return true;
}

int n = InputNumber("Введите число -> ");

if (ValidateNumber(n))
{
    int result = SumNumbers(n);
    System.Console.WriteLine($"Сумма чисел от 1 до {n} равна {result}");
}
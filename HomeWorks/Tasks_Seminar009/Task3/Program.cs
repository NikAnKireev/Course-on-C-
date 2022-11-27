/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */

int Prompt(string message)
{
    Console.Write(message + " > ");
    return int.Parse(Console.ReadLine());
}

int Akkerman(int valueM, int valueN)
{
    if (valueM == 0) return valueN + 1;
    if (valueM > 0 && valueN == 0) return Akkerman(valueM - 1, 1);
    else return Akkerman(valueM - 1, Akkerman(valueM, valueN - 1));
}
int m = Prompt("Введите число M");
int n = Prompt("Введите число N");
Console.WriteLine();
Console.WriteLine($"M = {m}, N = {n} -> A(m,n) = {Akkerman(m, n)}");
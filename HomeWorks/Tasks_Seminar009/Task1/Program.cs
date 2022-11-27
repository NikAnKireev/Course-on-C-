/* Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */

Console.Clear();

int Prompt(string message)
{
    Console.Write(message + " > ");
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int numberM, int numberN)
{
    if (numberN < numberM)
    {
        return;
    }
    PrintNumbers(numberM, numberN - 1);
    if (numberN % 2 == 0) Console.Write(numberN + " ");
}

int numbM = Prompt("Введите число M");
int numbN = Prompt("Введите число N");
PrintNumbers(numbM, numbN);
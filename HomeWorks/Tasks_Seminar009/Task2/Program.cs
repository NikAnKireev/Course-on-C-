/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30 */

Console.Clear();

int Prompt(string message)
{
    Console.Write(message + " > ");
    return int.Parse(Console.ReadLine());
}

int SumNumbers(int numberM, int numberN)
{
    int sum = numberM;
    if (numberN == numberM)
    {
        return 0;
    }
    else
    {
        numberM++;
        sum = numberM + SumNumbers(numberM, numberN);
        return sum;
    }
}
void PrintSumNumber(int valueM, int valueN)
{
    Console.Write(SumNumbers(valueM - 1, valueN));
}

int numbM = Prompt("Введите число M");
int numbN = Prompt("Введите число N");
PrintSumNumber(numbM, numbN);
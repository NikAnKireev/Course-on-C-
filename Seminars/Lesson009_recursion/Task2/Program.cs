/* Задайте значения M и N. Напишите программу, которая рекурсивно выведет 
все натуральные числа в промежутке от M до N.

M = 1; N = 5 -> "1, 2, 3, 4, 5"

M = 4; N = 8 -> "4, 5, 6, 7, 8" */

Console.Clear();

int Prompt(string message)
{
    Console.Write(message + " > ");
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int firstNumber, int secondNumber)
{
    if (secondNumber <= firstNumber - 1)
    {
        return;
    }
    PrintNumbers(firstNumber, secondNumber - 1);
    Console.Write(secondNumber + " ");
}

int numberM = Prompt("Введите число M");
int numberN = Prompt("Введите число N");

PrintNumbers(numberM, numberN);
/* Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.

A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

Console.Clear();

int Prompt(string message)
{
    Console.Write(message + " > ");
    return int.Parse(Console.ReadLine());
}

double Power(int firstNumber, int secondNumber)
{
    if (secondNumber <= 0)
    {
        return 1;
    }
    return firstNumber * Power(firstNumber, secondNumber - 1);
}

int numberA = Prompt("Введите число A");
int numberB = Prompt("Введите число B");

double result = Power(numberA, numberB);
Console.WriteLine(result);
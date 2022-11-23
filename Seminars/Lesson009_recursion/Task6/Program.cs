/* Проверка на простое число: 
N = 13 -> "Это простое число"
N = 12 -> “Это не простое число” */

Console.Clear();

int Prompt(string message)
{
    Console.Write(message + " > ");
    return int.Parse(Console.ReadLine());
}

bool Power(int number, int numberTwo)
{
    if (numberTwo <= 1)
    {
        return true;
    }
    return (number % numberTwo != 0) && (Power(number, numberTwo - 1));
}

int number = Prompt("Введите число N");
bool result = Power(number, number - 1);
Console.WriteLine();

if (result)
{
    Console.WriteLine($"N = {number} > Это простое число!");
}
else
{
    Console.WriteLine($"N = {number} > Это не простое число!");
}
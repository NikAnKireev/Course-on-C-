/*  Определите, является ли число степенью двойки:
N = 16 -> "Является степень двойки"
N = 12 -> “Не является степенью двойки” */

Console.Clear();

int Prompt(string message)
{
    Console.Write(message + " > ");
    return int.Parse(Console.ReadLine());
}

bool Power(int number)
{
    if (number <= 2)
    {
        return true;
    }
    return (number % 2 == 0) && (Power(number / 2));
}

int numberN = Prompt("Введите число N");
bool result = Power(numberN);
Console.WriteLine();

if (result)
{
    Console.WriteLine($"N = {numberN} > Является степенью двойки!");
}
else
{
    Console.WriteLine($"N = {numberN} > Не является степенью двойки!");
}
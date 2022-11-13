// Вычеслить факториал (N!) при помощи метода и рекурсии.

Console.Clear();

double Factorial(int number)
{
    // 1! = 1
    // 0! = 1
    if (number == 1 || number == 0) return 1;
    else return number * Factorial(number - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {(Factorial(i))}");
}


// Числа фибоначи 1 1 2 3 5 8 13 21

Console.Clear();

// f(1) = 1
// f(2) = 1 
// F(n) = f(n-1) + f(n-2)

int Fibonucci(int number)
{
    if (number == 1 || number == 2) return 1;
    else return Fibonucci(number - 1) + Fibonucci(number - 2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonucci(i));
}
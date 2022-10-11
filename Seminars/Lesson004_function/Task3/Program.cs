/* Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120 */

Console.Clear();
int InputNumber(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

int MultiplyNumbers(int number)
{
    int multiply = 1;                           
    for (int i = 1; i <= number; i++)      
    {
        multiply = multiply * i; 
    }
    return multiply; 
}

int number = InputNumber("Введите число -> ");
int result = MultiplyNumbers(number);
System.Console.WriteLine($"Факториал числа {number} -> {result}");
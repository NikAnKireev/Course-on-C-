/* Напишите программу, которая принимает на вход число 
(N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Prompt("Введите число: ");

for (int i = 1; i <= number; i++)
{
    System.Console.WriteLine(Math.Pow(i, 2));
}
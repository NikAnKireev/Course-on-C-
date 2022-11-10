Console.Clear();

// Вид 1 ничего не принимает и не возвращает
void Method1()
{
    Console.WriteLine("Автор");
}

Method1(); //вызов метода

//Вид 2 что-то принимает, но не возвращает
void Method2(string masage)
{
    Console.WriteLine(masage);
}

Method2("Текст сообщения"); //Вызов метода

void Method21(string masage, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(masage);
        i++;
    }
}

Method21("Текст", 4); //Вызов метода

//ctrl+C выход из бесконечного цикла

//Вид 3 что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year; // вызов текущей даты
}

int year = Method3(); //передаем метод в переменную year
Console.WriteLine(year); // выводим метод в консоль

//Вид 4 что-то принимет и возвращает

string Method4(int count, string text)
{
    string result = String.Empty; // пустая строка или ""
    for (int i = 0; i < count; i++) // цикл for вместо while позволяет задать условие и счетчик в одной строке
    {
        result = result + text;
    }
    return result; // возвращает переменную result
}

string res = Method4(10, "z");
Console.WriteLine(res);
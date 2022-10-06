Console.Clear();

int[] array = { 51, 72, 13, 4, 475, 4, 67, 98, 19 };

int n = array.Length; // команда Lenght передает длину массива
int find = 4;
int index = 0;
while (index < n)
{
    if (array[index] == find)  // Если индекс массива "array" совпадает с переменной "find"
        {
            Console.WriteLine(index);
            break; // Если попадаются два одиноковых элемента можно прервать командой "break"
        }
        index++;

}
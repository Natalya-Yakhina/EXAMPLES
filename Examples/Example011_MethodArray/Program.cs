// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find

int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};
int n = array.Length; // сколько конкретных элементов в нем содержитсяб возвращает длинну и количество элементов массива
int find = 18;
int index = 0;

while (index < n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break; // прерви, если несколько одинаковых значений
    }
    index++; // index = index + 1
}
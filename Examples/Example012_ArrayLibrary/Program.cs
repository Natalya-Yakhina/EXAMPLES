// See https://aka.ms/new-console-template for more information
// void metod - ничего не возвращает 

void FillArray(int[] collection)
{
    int length = collection.Length; // получить длинну массива
    int index = 0;
    while (index < length) // пока индекс меньше размера массива
    {
        collection[index] = new Random().Next(1, 10); // положить новое число из диапозона
        index++;
    }
}

void PrintArray(int[] col) // будет печатать массив
{
    int count = col.Length; //количество элементов
    int position = 0; // обозначение позиции
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// описание с помощью метода
int indexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если элемента нет, будет возвращать -1

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создай новый массив в котором будет 10 элементов

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = indexOff(array, 444);
Console.WriteLine(pos);
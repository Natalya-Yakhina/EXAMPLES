// 
//
// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиии
// 3. Повторять пока есть не отсортированные элементы

int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// вывод массива на экран
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++) // пробегаем по всем элементам и показываем на экране
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
// упорядочивание массива
void SellectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++) // искуственно отнять, т.к. при поиске минимального приавляем 1
    {
        int minPosition = i;
        
        // ищем минимальный элемент
        for (int j = i + 1; j < array.Length; j++)
        {
            // здесь ищем мин элемент
            if(array[j] < array[minPosition]) minPosition = j;
        }
        
        
        int temporary = array[i];
        array[i] = array[minPosition]; // обмен двух переменных местами
        array[minPosition] = temporary;
    }
}

PrintArray(array);
SellectionSort(array);


PrintArray(array);


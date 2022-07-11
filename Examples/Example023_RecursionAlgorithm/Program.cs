//
// string[,] table = new string[2,5];
// String.Empty // инициализация строк
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]
//

// table[1, 2] = "слово!"; //обратиться к строчке [индекст строки, индекс столбца]

// for(int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


int[,] matrix = new int[3, 4];
// метод печати и заполнения числами матрицу

void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++) // номер строки 0 - количество строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // номер столбца 
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// метод заполнения матрицы слуайными числами

void FllArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10); // [1;10)
        }
    }
}

PrintArray(matrix);
FllArray(matrix);
Console.WriteLine();
PrintArray(matrix);

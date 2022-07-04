// Цикл for - собирает все

string Method4(int count, string text) // строку С компоновать count раз
{
    string result = String.Empty; // String.Empty - пустая строка
    
    for(int i = 0; i < count; i++ ) // инициализация счетчика ; проверка условия ; счетчик
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
//Console.WriteLine(res);

// Цикл в цикле
// пример таблица умножения

for(int i = 1; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}"); // интерполяция строк
    }
    Console.WriteLine(); // переход на новую строку
}

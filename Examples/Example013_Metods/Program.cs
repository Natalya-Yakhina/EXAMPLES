// void - ничего не возвращает или возвращает пустоту

// Вид 1 
// ничего не принимают, ничего не возвращают

void Method1() // нет аргументов, может что-то показывать на экран
{
    Console.WriteLine("Автор...");
}
// как вызываются методы
Method1();


// Вид 2
// что-то принимают, ничего не возвращают

void Method2(string msg) // ничего не возвращают, но могут принимать аргументы
{
    Console.WriteLine(msg); // можно указывать операторы и использовать
}
Method2("Текст сообщения");
// элементы именновые, когда явно указано какому аргументу какое значение мы хотим указать
// именнованные элементы не обязаельно писать по порядку
Method2(msg: "Текст сообщения"); // ЯВНОЕ УКАЗЫВАНИЕ, нужно, если метод принимает определенное количество элементов

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++; // инкримент - увеличение на 1
                 //декремент - уменьшение на 1
    }
}
Method21(msg: "Текст", 4);
Method21(count: 4, msg:"Новый текст");


// Вид 3 
// что-то возвращают, но ничего не принимают
// если метод возвращает, обязательно указать тип данных, к.й. ожидаем

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// Вид 4 
// что-то принимают и что-то возвращают

string Method4(int count, string text) // строку С компоновать count раз
{
    int i = 0;
    string result = String.Empty; // String.Empty - пустая строка

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);
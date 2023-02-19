Console.Clear();

// Вид 1 - Не принимают и не возвращают
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1(); // Вызыв метода

// Вид 2 / Принимают и не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++; // Инкременты и декременты
    }    
}
Method21("Текст", 4);
Method21(count: 4, msg: "Новый текст"); // CTRL + C исправить сазицливание

// Вид 3 - Не принимают и возвращают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4 - Принимают и возвращают
string Method4(int count, string text) // Через Rename Symbol можно сменить все классы
{
    int i = 0;
    string result = String.Empty; // Или ""; значит пустая строка
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);

string Method41(int count, string text) // Через for
{
    string result = String.Empty;
    for (int j = 0; j < count; j++)
    {
        result = result + text;        
    }
    return result;
}
string resu = Method41(10, "z");
Console.WriteLine(resu);
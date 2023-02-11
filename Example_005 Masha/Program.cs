Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha") // ToLower - Все символы строки переводит в нижний регистр
{
    Console.WriteLine("Ура, это же MASHA!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
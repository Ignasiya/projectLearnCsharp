/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 */

Console.Clear();
Console.WriteLine($"Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе");

int Input(string text) // Метод ввода нужного числа
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    while (num == 0){
        Console.WriteLine($"Cумма цифр числа {num} равна 0");
        Console.Write(text);
        num = int.Parse(Console.ReadLine());
    }
    return num;
}

int SumNum(int num) // Метод алгоритма суммы цифр
{
    int result = 0;
    if (num < 0) num *= -1;
    while (num > 0){
        result = result + num % 10;
        num /= 10; 
    }    
    return result;
}

int num = Input($"Введите число: ");
int result = SumNum(num);
Console.WriteLine($"Сумма цифр числа {num} будет равна {result}");
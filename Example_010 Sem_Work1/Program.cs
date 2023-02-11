/* 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет */

Console.Clear();
Console.WriteLine("Введите число, квадрат: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine($"{Math.Pow(numberB, 2) == numberA}"); // для уточнения на True или False
if (Math.Pow(numberB, 2) == numberA)
{
    Console.WriteLine($"Квадрат числа {numberB} равен числу {numberA}");
}
else 
{
    Console.WriteLine($"Квадрат числа {numberB} не равен числу {numberA}");
}
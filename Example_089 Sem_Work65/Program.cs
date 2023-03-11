// **Задача 65:**Задайте значения M и N.
//  Напишите программу, которая выведет все
//   натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

using System;
using static System.Console;

Clear();
Write("Введите значение M: ");
int a = int.Parse(ReadLine());
Write("Введите значение N: ");
int b = int.Parse(ReadLine());

string NumberFor(int a, int b)
{
    if (a <= b) return $"{a} " + NumberFor(a + 1, b);
    else return String.Empty;
}

WriteLine($"Все числа в промежутке от {a} до {b} -> {NumberFor(a, b)}");
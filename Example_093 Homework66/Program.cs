/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

using System;
using static System.Console;

Clear();
Write("Введите значение M: ");
int a = int.Parse(ReadLine());
Write("Введите значение N: ");
int b = int.Parse(ReadLine());

int NumberFor(int a, int b)
{
    return a == b ? a : b + NumberFor(a, b - 1);
}

WriteLine($"Сумма натуральных чисел в промежутке от {a} до {b} -> {NumberFor(a, b)}");
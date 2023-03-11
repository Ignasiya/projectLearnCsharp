/***Задача 67:**Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.

453 -> 12
45 -> 9*/

using System;
using static System.Console;

Clear();
Write("Введите значение: ");
int num = int.Parse(ReadLine());

int SumNumber(int num)
{
    if (num > 0) return num % 10 + SumNumber(num / 10);
    else return 0;
}

WriteLine($"Сумма цифр числа {num} -> {SumNumber(num)}");
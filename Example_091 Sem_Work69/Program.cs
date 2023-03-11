// **Задача 69:**Напишите программу,
//  которая на вход принимает два числа A и B,
//   и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8

using System;
using static System.Console;

Clear();
Write("Введите значение A: ");
int a = int.Parse(ReadLine());
Write("Введите значение B: ");
int b = int.Parse(ReadLine());

int PowNumber(int a, int b)
{
    return b == 0 ? 1 : PowNumber(a, b - 1) * a; // терминарный оператор
}

WriteLine($"Число А = {a} в целую степень B {b} -> {PowNumber(a, b)}");
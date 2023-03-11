/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

using System;
using static System.Console;

Clear();
Write("Введите значение M: ");
int m = int.Parse(ReadLine());
Write("Введите значение N: ");
int n = int.Parse(ReadLine());

int FunctionAkkermana(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0)) return FunctionAkkermana (m - 1, 1);
    else return FunctionAkkermana(m - 1, FunctionAkkermana(m, n - 1));
}

WriteLine($"Вычисление функции Аккермана числа {m} и {n} -> {FunctionAkkermana(m, n)}");
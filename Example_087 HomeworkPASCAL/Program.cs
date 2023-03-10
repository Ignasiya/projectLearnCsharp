/* Треугольник ПАСКАЛЯ */

using System;
using static System.Console;

Clear();
TrianglePascal($"Введите количество строк треугольника PASCAL и нажмите Enter: ");

void TrianglePascal(string text)
{
    Write(text);
    int num = int.Parse(Console.ReadLine());
    for (int i = 0; i < num; i++)
    {
        for (int j = num; j > i; j--)
        {
            Write(" ");
        }
        int value = 1;
        for (int j = 0; j <= i; j++)
        {
            Write(value + " ");
            value = value * (i - j) / (j + 1);
        }
        WriteLine();
    }
}

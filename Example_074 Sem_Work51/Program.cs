// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

using System;
using static System.Console;

Clear();
Write("Введите количество строк: ");
int num1 = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int num2 = int.Parse(ReadLine());

int[,] result = GetArray(num1, num2, 1, 10);
PrintArray(result);
int sum = Summ(result);
Write($"Сумма элементов главной диагонали: {sum}");

int Summ (int[,] result)
{
    int sum = 0; //                                       вопрос,  если true           если false
    int minSize = result.GetLength(0) < result.GetLength(1) ? result.GetLength(0) : result.GetLength(1);
    //int minSize = result.GetLength(0);
    //if (minSize > result.GetLength(1)) minSize = result.GetLength(1);
    for (int i = 0; i < minSize; i++)
    {
        sum += result[i, i];
    }
    return sum;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}
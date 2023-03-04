// **Задача 49:** Задайте двумерный массив.
//  Найдите элементы, у которых оба индекса чётные,
//   и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 2 3 4

// Новый массив будет выглядеть вот так:

// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4
// 1 **4** 3 **16**

using System;
using static System.Console;

Clear();
Write("Введите количество строк: ");
int num1 = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int num2 = int.Parse(ReadLine());

int[,] result = GetArray(num1, num2, 1, 10);
PrintArray(result);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
            if(i % 2 == 1 && j % 2 == 1) result[i, j] *= result[i, j];
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
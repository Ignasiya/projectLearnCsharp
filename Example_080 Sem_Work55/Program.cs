// **Задача 55:**Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// В итоге получается вот такой массив:

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

using System;
using static System.Console;

Clear();
Write("Введите количество строк: ");
int num1 = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int num2 = int.Parse(ReadLine());

int[,] result = GetArray(num1, num2, 1, 100);
PrintArray(result);
WriteLine();
int[,] resultTurn = new int[result.GetLength(0), result.GetLength(1)]; // Проверка на равенство размеров массива
if (result.GetLength(0) == result.GetLength(1))
{
    resultTurn = TurnArray(result, resultTurn);
    PrintArray(resultTurn);    
}
else WriteLine($"Выполнить замену не возможно");


int[,] TurnArray(int[,] array, int[,] temp)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++){
            for (int j = 0; j < array.GetLength(1); j++){
                temp[i, j] = array[j, i];
            }
        }
    }
    return temp;
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
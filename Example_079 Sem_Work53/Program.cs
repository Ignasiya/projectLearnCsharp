/*Задача 53:** Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

8 4 2 4
5 9 2 3
1 4 7 2 */

using System;
using static System.Console;

Clear();
Write("Введите количество строк: ");
int num1 = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int num2 = int.Parse(ReadLine());

int[,] result = GetArray(num1, num2, 1, 9);
PrintArray(result);
WriteLine();
TurnArray(result);
PrintArray(result);

void TurnArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++){
        int temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++){
        for (int j = 0; j < inArray.GetLength(1); j++){
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}
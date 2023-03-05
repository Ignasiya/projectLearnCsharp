/* *Задача 58:** Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18 */

using System;
using static System.Console;

Clear();
Write("Введите количество строк: ");
int num1 = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int num2 = int.Parse(ReadLine());

int[,] array1 = GetArray(num1, num2, 1, 9);
PrintArray(array1);
WriteLine();
int[,] array2 = GetArray(num1, num2, 1, 9);
PrintArray(array2);

WriteLine($"Произведение двух матриц: ");
int[,] result = new int[num1, num2];
DivArray(result, array1, array2);
PrintArray(result);

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

void DivArray(int[,] result, int[,] array1, int[,] array2)
{    
    for (int i = 0; i < array1.GetLength(0); i++){
        for (int j = 0; j < array2.GetLength(1); j++){
            for (int k = 0; k < array2.GetLength(0); k++){
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
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
/**Задача 54:** Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

7 4 2 1
9 5 3 2
8 4 4 2 */

using System;
using static System.Console;

Clear();
Write("Введите количество строк: ");
int num1 = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int num2 = int.Parse(ReadLine());

int[,] result = GetArray(num1, num2, 1, 9);
PrintArray(result);
WriteLine($"В итоге получается вот такой массив: ");
TurnArray(result);
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

void TurnArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++){
        for (int j = 0; j < result.GetLength(1) - 1; j++){
            for (int k = 1; k < result.GetLength(1) - j; k++){
                if(result[i, j] < result[i, j + k])
                {
                    int temp = result[i, j];
                    result[i, j] = result[i, j + k];
                    result[i, j + k] = temp;
                }
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
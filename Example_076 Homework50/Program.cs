/**Задача 50.** Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

using System;
using static System.Console;

Clear();
Write("Введите количество строк: ");
int num1 = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int num2 = int.Parse(ReadLine());

int[,] result = GetArray(num1, num2, 1, 100);
PrintArray(result);
FindElementArray(result, "Введите координаты элемента массива (строка, столбец) через пробел: ");

void FindElementArray(int[,] array, string text)
{
    Write(text);
    int[] findCoord = ReadLine().Split(" ").Select(int.Parse).ToArray();;
    if (findCoord[0] <= array.GetLength(0) && findCoord[1] <= array.GetLength(1)){
        int element = array[findCoord[0] - 1, findCoord[1] - 1];
        WriteLine($"Значение элемента {element}");
    }else WriteLine($"Такого числа в массиве нет");

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
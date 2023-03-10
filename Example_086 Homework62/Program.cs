/* *Задача 62**. Напишите программу, которая заполнит спирально массив 4 на 4.Например, 
на выходе получается вот такой массив:

01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

using System;
using static System.Console;

Clear();
int[,] array = new int[6, 6];
int[] digit = GetArray(array);
FillArray(array, digit);
PrintArray(array);

void FillArray(int[,] array, int[] digit)
{
    int index = 0;
    int j = 0;
    int size = 0;
    for (int i = 0; i < array.GetLength(0) / 2; i++)
    {
        for (j = size; j < array.GetLength(1) - size; j++)
        {
            array[i, j] = digit[index];
            index++;
            Write($"{i}, {j}; ");
        }
        WriteLine();
        i++; 
        j--;
        for (; i < array.GetLength(0) - size; i++)
        {
            array[i, j] = digit[index];
            index++;
            Write($"{i}, {j}; ");
        } 
        i-=2;
        WriteLine();
        for (; i > 0; i--)
        {
            array[j, i] = digit[index];
            index++;
            Write($"{j}, {i}; ");
        }
        i += size;
        j -= size;
        WriteLine();
        for (; j > size * 2 - i; j--)
        {
            array[j, i] = digit[index];
            index++;
            Write($"{j}, {i}; ");
        }
        WriteLine();
        WriteLine();
        if (index == digit.Length) break;
        size++;
    }
}

int[] GetArray(int[,] array)
{
    int[] arr = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = i + 1;
    }
    return arr;
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

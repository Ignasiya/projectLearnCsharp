/* *Задача 62**. Напишите программу, которая заполнит спирально массив 4 на 4.Например, 
на выходе получается вот такой массив:

01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

using System;
using static System.Console;

Clear();
int[,] array = InputData($"Введите размеры двухмерного массива через пробел и нажмите Enter: ");
FillArray(array);
PrintArray(array);

int[,] InputData(string text)
{
    Write(text);
    int[] size = ReadLine().Split(" ").Select(int.Parse).ToArray();
    int[,] array = new int[size[0] ,size[1]];
    return array;
}

void FillArray(int[,] array)
{
    int minCycle = array.GetLength(0);
    if (minCycle > array.GetLength(1)) minCycle = array.GetLength(1);
    int index = 0;
    for (int i = 0; i < minCycle; i++)
    {
        int j = i;
        int k = i + 1;
        for (; j < array.GetLength(1) - i; j++)
        {
            index++;
            array[i, j] = index;
            if(index == array.GetLength(0) * array.GetLength(1)) return;        
        }        
        for (j--; k < array.GetLength(0) - i; k++)
        {
            index++;
            array[k, j] = index;
            if(index == array.GetLength(0) * array.GetLength(1)) return;          
        }
        for (j--, k--; j >= 0 + i; j--)
        {
            index++;
            array[k, j] = index;
            if(index == array.GetLength(0) * array.GetLength(1)) return;
        }        
        for (j++, k--; k > 0 + i; k--)
        {
            index++;
            array[k, j] = index;
            if(index == array.GetLength(0) * array.GetLength(1)) return;      
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

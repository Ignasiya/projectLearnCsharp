/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

using System;
using static System.Console;

Clear();
int[,,] array3D = InputData($"Введите размеры трехмерного массива через пробел и нажмите Enter: ");
int[] digitDoub = DigitsDouble(array3D);
FillArray(array3D, digitDoub);

void FillArray(int[,,] array3D, int[] digitDoub)
{
    int index = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = digitDoub[index];
                Write($"{array3D[i, j, k]}({j},{k},{i}) ");
                index++;
            }
        WriteLine();
        }
    }
}

int[] DigitsDouble(int[,,] array3D)
{
    int[] array = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 10 + i;
    }
    return array;
}

int[,,] InputData(string text)
{
    Write(text);
    int[] size = ReadLine().Split(" ").Select(int.Parse).ToArray();
    int[,,] array3D = new int[size[0] ,size[1], size[2]];
    return array3D;
}
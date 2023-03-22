using System;
using static System.Console;

int[] array = new int[5];
for (int i = 0; i < array.Length; i++) 
    array[i] = Convert.ToInt32(ReadLine());
WriteLine("[" + string.Join(", ", array) + "]");
WriteLine(array[3]);
// Сложность алгоритма О(1)
// [4, 5, 3, 1, 2]
// O(n)
// [1, 2, 3, 4, 5] = O(n * log n)
// (5 + 1)/2) * 5 = O(1)
// n < n * log(n) + 1

int n = Convert.ToInt32(ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Write(matrix[i, j] + "\t");
    }
    WriteLine();
}
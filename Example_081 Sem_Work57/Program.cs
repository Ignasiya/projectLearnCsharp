// /* **Задача 57:**Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит информацию о том,
//  сколько раз встречается элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }

// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3, 4, 6, 1, 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза*\

using System;
using static System.Console;

Clear();
Write("Введите количество строк: ");
int num1 = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int num2 = int.Parse(ReadLine());

int[,] result = GetArray(num1, num2, 0, 9);
PrintArray(result);
WriteLine();
string[,] count = OutputCount(result);
PrintText(count);

string[,] OutputCount(int[,] array)
{
    string[,] text = new string[,]
    {
        {"0", "встречается", " ", "раз"},
        {"1", "встречается", " ", "раз"},
        {"2", "встречается", " ", "раз"},
        {"3", "встречается", " ", "раз"},
        {"4", "встречается", " ", "раз"},
        {"5", "встречается", " ", "раз"},
        {"6", "встречается", " ", "раз"},
        {"7", "встречается", " ", "раз"},
        {"8", "встречается", " ", "раз"},
        {"9", "встречается", " ", "раз"},
    };        
    for (int i = 0; i < text.GetLength(0); i++){
        int count = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(1); k++){
                if (i == array[j, k]) count++;
            }
        }
        text[i,2] = Convert.ToString(count);
    }
    return text;
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

void PrintText(string[,] inArray)
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

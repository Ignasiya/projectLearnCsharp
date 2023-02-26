
Console.Clear();
//                       строка  столбец
string[,] table = new string[2, 5];
// String.Empty
// table[0,0]  table[0,1]  table[0,2] table[0,3] table[0,4]
// table[1,0]  table[1,1]  table[1,2] table[1,3] table[1,4]

table[1, 2] = "с";

for (int rows = 0; rows < 2; rows++) // строки
{
    for (int columns = 0; columns < 5; columns++) // столбцы
    {
        Console.Write($"-{table[rows, columns]}-");
    }
Console.WriteLine();
}
Console.WriteLine();

// Облизано с числами
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            matr[i,j] = new Random().Next(1,10); 
        }
    }    
}
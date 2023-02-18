// 20 Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);

Console.Clear();
Console.Write($"Введите значение X, для первой точки: ");
double X1 = double.Parse(Console.ReadLine());
Console.Write($"Введите значение Y, для первой точки: ");
double Y1 = double.Parse(Console.ReadLine());

Console.Write($"Введите значение X, для второй точки: ");
double X2 = double.Parse(Console.ReadLine());
Console.Write($"Введите значение Y, для второй точки: ");
double Y2 = double.Parse(Console.ReadLine());

double s = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
Console.WriteLine($"{s}");
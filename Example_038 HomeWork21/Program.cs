/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();
void ReadLineXYZ(double[] array){    
    Console.Write($"Введите координаты точки в формате X Y Z, через ENTER: ");
    int index = 0;
    while (index < 3){
        array[index] = double.Parse(Console.ReadLine());
        index ++;
    }
}

double[] LocA = new double[3];
double[] LocB = new double[3];
ReadLineXYZ(LocA);
ReadLineXYZ(LocB);

double result = Math.Sqrt(Math.Pow(LocA[0] - LocB[0], 2) + Math.Pow(LocA[1] - LocB[1], 2) + Math.Pow(LocA[2] - LocB[2], 2));
Console.WriteLine($"{result}");
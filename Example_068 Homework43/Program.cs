/* Задача 43:** Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

/*Если подставить y, то k1*x+b1 = k2*x+b2 -> k1*x-k2*x = b2-b1 -> x(k1-k2) = b2-b1 -> x = b2-b1 / k1-k2 
y = k2 * x + b2*/

double[] InputData(string text)
{
    Console.Write(text);
    string[] str = text.Split(" ");
    double[] num = new double[2];
    num[0] = double.Parse(str[0]);
    num[1] = double.Parse(str[1]);
    Console.WriteLine();
    return num;
}

double[] XandY(double[] array1, double[] array2)
{
    double[] coordinate = new double[2];
    coordinate[0] = (array2[0] - array1[0]) / (array1[1] - array2[1]); // 0 - b, 1 - k
    coordinate[1] = array2[1] * coordinate[0] + array2[0];
    return coordinate;
}

bool Validate(double[] array1, double[] array2)
{    
    if (array1[0] == array2[0] && array1[1] == array2[1]){
        Console.WriteLine("Прямые совпадают");
        return false;
    }
    if (array1[0] == array2[0] || array1[1] == array2[1]){
        Console.WriteLine("Прямые паралельны");
        return false;
    }
return true;
}

Console.Clear();
Console.Write("Введите значения b и k для прямой 1: ");
double[] Line1 = InputData(Console.ReadLine());

Console.Write("Введите значения b и k для прямой 2: ");
double[] Line2 = InputData(Console.ReadLine());
if (Validate(Line1, Line2))
{
    double[] coordinate = XandY(Line1, Line2);
    Console.Write($"Точка пересечения уравнений прямых y={Line1[1]}*x+{Line1[0]} и y={Line2[1]}*x+{Line2[0]} ");
    Console.Write($"Имеет координаты ({String.Join(", ", coordinate)}) ");
}
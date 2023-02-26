// **Задача 40:**Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.

int Input(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    while (num <= 0){
    Console.WriteLine($"Неверное значение");
    Console.Write(text);
    num = int.Parse(Console.ReadLine());
    }
    return num;
}

bool Result(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

Console.Clear();
int A = Input("Введите сторону A: ");
int B = Input("Введите сторону B: ");
int C = Input("Введите сторону C: ");
if (Result(A,B,C)){
    Console.WriteLine($"Треугольник существует");
}else Console.WriteLine($"Треугольник не существует");
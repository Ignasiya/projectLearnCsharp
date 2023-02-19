//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

long GetMulti(long n)
{
    long multi = 1;
    long i = 2;
    if (n < 0){
        i = n;
        n = -1;
    }
    for(; i <= n; i++)    {
        multi *= i;
    }
    return multi;
}

Console.Clear();
Console.Write("Введите число: ");
long n = long.Parse(Console.ReadLine());
Console.WriteLine($"Факториал равен {GetMulti(n)}");
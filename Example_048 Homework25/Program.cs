/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Clear();

int GetPow(int arg1, int arg2)
{    
    int pow = Convert.ToInt32(Math.Pow(arg1, arg2));
    return pow;
}

int PrintNum(string text)
{
    Console.Write(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}

bool Validate(int arg)
{
    if (arg < 0){
        Console.WriteLine($"Введено значение меньше нуля");
        return false;
    }
    return true;
}

int a = PrintNum($"Введите значение A: ");
int b = PrintNum($"Введите значение B: ");
if (Validate(b)){
    Console.WriteLine($"Число {a} в степени {b} равно {GetPow(a,b)}");
}
/* **Задача 32:**Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2] */

int[] Array(int size)
{
    Console.WriteLine($"Введите максимальное значение массива: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine($"Введите минимальное значение массива: ");
    int b = int.Parse(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(b, a+1);               
    }
    return array;    
}

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

int[] Result(int[] array)
{
    for(int i = 0; i < array.Length; i++){
        array[i] *= -1;
    }
    return array;
}

Console.Clear();
int size = Input($"Введите размер массива: ");
int[] array = Array(size);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"[{String.Join(", ", Result(array))}]");
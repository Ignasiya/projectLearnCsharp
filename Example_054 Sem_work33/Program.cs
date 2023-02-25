/* **Задача 33:**Задайте массив.Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.

4; массив[6, 7, 19, 345, 3]->нет
3; массив[6, 7, 19, 345, 3]->да*/

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

bool Result(int[] array)
{
    Console.WriteLine($"Введите значение для поиска в массиве: ");
    int find = int.Parse(Console.ReadLine());    
    for(int i = 0; i < array.Length; i++){
        if (array[i] == find){
            return true;
        }
    }return false;      
}

Console.Clear();
int size = Input($"Введите размер массива: ");
int[] array = Array(size);
Console.WriteLine($"[{String.Join(", ", array)}]");
if (Result(array)) Console.WriteLine($"Значение присутствует в массиве");
else Console.WriteLine($"Значение не присутствует в массиве");
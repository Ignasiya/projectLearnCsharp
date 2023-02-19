//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]
// a = new Random().Next()
// Random r = new Random();
// int a = new Random().Next(2, 10)
// int a = r.Next(2, 10);
// int a = r.Next(2);

int[] ArrayNull(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(2);
        Console.Write($"{array[i]} ");        
    }
    return array;
}
// Console.Write($"[{String.Join(", ", array)}]");
Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
ArrayNull(size);
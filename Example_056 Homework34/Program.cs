/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(100, 1000);               
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

int Result(int[] array)
{
    int count = 0;
    foreach (int arg in array){
        if(arg % 2 == 0) count++;        
    }
    return count;
}

Console.Clear();
int size = Input($"Введите размер массива: ");
int[] array = Array(size);
Console.WriteLine($"Количество чётных чисел в массиве [{String.Join(", ", array)}] -> {Result(array)}");
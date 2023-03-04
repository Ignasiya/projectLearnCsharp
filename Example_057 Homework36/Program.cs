/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int Result(int[] array)
{
    int sum = 0;
    int i = 1;
    while (i < array.Length){
        sum = sum + array[i];
        i += 2;
    }
    return sum;
}

Console.Clear();
Console.Write($"Введите элементы массива через пробел: ");
int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); // Перевод массива с клавы в массив
Console.WriteLine($"Сумма элементов массива [{String.Join(", ", array)}], стоящих на нечётных позициях -> {Result(array)}");
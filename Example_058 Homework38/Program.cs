/* **Задача 38:** Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

int[] GetArrayString(string stringArray) // Для вводе массива с клавы
{
    string[] nums = stringArray.Split(" ");
    int[] array = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++){
        array[i] = int.Parse(nums[i]);
    } return array;
}

int Result(int[] array)
{
    int max = 0; int min = 0; int diff = 0; // Переменные
    foreach (int arg in array){
        if (arg > max) max = arg;
        else if (arg < min) min = arg;
    }
    diff = max - min;
    return diff;
}

Console.Clear();
Console.Write($"Введите целые числа массива через пробел: ");
int[] array = GetArrayString(Console.ReadLine());
Console.WriteLine($"Разница между максимальным и минимальным элементов массива [{String.Join(", ", array)}] -> {Result(array)}");
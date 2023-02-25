/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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
int[] array = GetArrayString(Console.ReadLine());
Console.WriteLine($"Сумма элементов массива [{String.Join(", ", array)}], стоящих на нечётных позициях -> {Result(array)}");
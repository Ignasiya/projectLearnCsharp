/* Задача 39:** Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

int[] GetArrayString(string stringArray) // Для вводе массива с клавы
{
    string[] nums = stringArray.Split(" ");
    int[] array = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++){
        array[i] = int.Parse(nums[i]);
    } return array;
}

int[] Result(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++){
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;        
    }
    return array;
}

int[] ResultAlt(int[] array)
{
    int[] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        result[i] = array[array.Length - 1 - i];       
    }
    return result;
}

Console.Clear();
Console.Write($"Введите элементы массива через пробел: ");
int[] array = GetArrayString(Console.ReadLine());
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"[{String.Join(", ", ResultAlt(array))}]");
Console.WriteLine($"[{String.Join(", ", Result(array))}]");
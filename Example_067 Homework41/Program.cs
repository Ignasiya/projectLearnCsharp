/* **Задача 41:** Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

// Метод ввода с клавы
int[] GetArray(string text)
{
    string[] str = text.Split(" ");
    int[] array = new int[str.Length];
    for (int i = 0; i < str.Length; i++){
        array[i] = int.Parse(str[i]);
    }return array;
}

// Метод 
int Count(int[] array)
{
    int count = 0;
    foreach (int el in array){
        if (el > 0) count++;
    }return count;
}

Console.Clear();
Console.Write($"Введите элементы массива через пробел: ");
int[] array = GetArray(Console.ReadLine());
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Чисел больше 0 -> {Count(array)}");
// **Задача 42:*Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

int[] GetArrayString(string stringArray) // Для вводе массива с клавы
{
    string[] nums = stringArray.Split(" ");
    int[] array = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++){
        array[i] = int.Parse(nums[i]);
    } return array;
}

string Result (int[] number)
{
    string result = "";
    string nums = "0123456789ABCDEF";
    int tmp = number[0];
    while (tmp > 0)
    {  // 21 2 - ost = 10 - result = 19 * 10    
        result = nums[tmp % number[1]] + result;
        tmp /= number[1];
    }
    return result;
}

Console.Clear();
Console.Write($"Введите десятичное число и нужную систему через пробел: ");
int[] num = GetArrayString(Console.ReadLine());
string result = Result(num);
Console.WriteLine($"{num[0]} -> {result}");
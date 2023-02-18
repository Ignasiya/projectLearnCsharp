// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.Write($"Введите число: ");
int number = int.Parse(Console.ReadLine());
for (int i = 1; i <= number; i++){
    double Sqrt = Math.Pow(i, 2);
    Console.Write($"{Sqrt}, ");
}
Console.WriteLine();
int[] array = new int[number+1];
for (int i = 1; i <= number; i++){
    array[i] = i * i;
    Console.Write($"{array[i]} ");
}
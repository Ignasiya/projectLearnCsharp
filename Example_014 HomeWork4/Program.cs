/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Clear();
Console.Write("Введите первое число: ");
int FirstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int SecondNumber = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int ThirdNumber = int.Parse(Console.ReadLine());
int MaxNumber = FirstNumber;
if (MaxNumber < SecondNumber){
    MaxNumber = SecondNumber;
}
if (MaxNumber < ThirdNumber){
    MaxNumber = ThirdNumber;
}
Console.WriteLine($"Максимальное число {MaxNumber}");
/* Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если второе число не кратно числу первому,
то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4  -> кратно */

Console.Clear();

Console.Write("Введите любое двухзначное число: ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write("Введите любое двухзначное число: ");
int NumberB = int.Parse(Console.ReadLine());
if (NumberA % NumberB == 0) Console.WriteLine($"Число {NumberB} кратно числу {NumberA}");
else Console.WriteLine($"Число {NumberB} не кратно числу {NumberA}, оастаток {NumberA % NumberB}");
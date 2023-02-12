/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14  ->  нет
46  ->  нет
161 ->  да */

Console.Clear();

Console.Write("Введите любое двухзначное число: ");
int Number = int.Parse(Console.ReadLine());
if (Number % 7 == 0 && Number % 23 == 0) Console.WriteLine($"Число {Number} кратно числу 7 и 23");
else Console.WriteLine($"Число {Number} не кратно числу 7 и 23");
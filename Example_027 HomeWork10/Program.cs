﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает **вторую** цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();
Console.Write("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine());
while (number < -999 || (number > -100 && number < 100) || number > 999){
    Console.Write("Введено неверное число, введите трехзначное число ");
    number = int.Parse(Console.ReadLine());
}
int result = number / 10 % 10;
Console.WriteLine($"Вторая цифра числа {number} -> {result}");
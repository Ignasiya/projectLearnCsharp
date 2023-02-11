/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.Clear();
Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine());
int ost = Number % 2;
if (ost == 0){
    Console.WriteLine($"Число {Number} четное");
}else{
    Console.WriteLine($"Число {Number} не четное");
}
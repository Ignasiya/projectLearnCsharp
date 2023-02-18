/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да  */

Console.Clear();
Console.Write($"Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
while (number < 10000 || number > 99999){
    Console.Write($"Введено неверное число, введите пятизначное число: ");
    number = int.Parse(Console.ReadLine());
}
int index = 0;
if ((number / 10000 % 10) == (number % 10) && (number / 1000 % 10) == (number / 10 % 10)){
    Console.Write($"Число {number} является палиндромом");
}else{
    Console.Write($"Число {number} не является палиндромом");
}


/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Clear();
Console.Write("Введите число от 1 до 7, обозначающую день недели: ");
int number = int.Parse(Console.ReadLine());
while(number < 1||number > 7){
    Console.Write("Введено неправильное число. Укажите число от 1 до 7, обозначающую день недели: ");
    number = int.Parse(Console.ReadLine());
}
if (number > 0 && number < 6){Console.WriteLine($"День недели не выходной");}
if (number > 5 && number < 8){Console.WriteLine($"День недели выходной");}
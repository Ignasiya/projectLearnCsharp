/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Clear();
Console.Write("Введите любое натуральное число: ");
int Number = int.Parse(Console.ReadLine());
while (Number < 2){
    Console.WriteLine("Вы ввели не натуральное число");
    Console.Write("Введите любое натуральное число: ");
    Number = int.Parse(Console.ReadLine());
}for (int index = 2; index <= Number; index = index + 2){
    Console.Write($"{index} ");
}
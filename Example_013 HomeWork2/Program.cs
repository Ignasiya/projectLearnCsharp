/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Clear();
Console.Write("Введите первое число: ");
int FirstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int SecondNumber = int.Parse(Console.ReadLine());
if (FirstNumber > SecondNumber){
    Console.WriteLine($"Большее число {FirstNumber}, меньшее число {SecondNumber}");
}else if (FirstNumber == SecondNumber){
    Console.WriteLine($"Число {FirstNumber} равно числу {SecondNumber}");
}else{
    Console.WriteLine($"Большее число {SecondNumber}, меньшее число {FirstNumber}");
}
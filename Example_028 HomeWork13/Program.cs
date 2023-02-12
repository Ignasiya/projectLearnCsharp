/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Clear();
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
int result = number;
if (number < -99 || number > 99){
    for (int i = 0; result > 999 || result < -999; i ++){
        result = result / 10;
    }
    result = result % 10;
    Console.WriteLine($"Третья цифра числа {number} -> {result}");
}else {
    Console.WriteLine($"Третьей цифры числа {number} нет");  
}
/* 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 ->  Пятница */

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
//while(number < 1||number > 7) || - "или", && - "и", != - не равно
if (number > 0 && number < 8)
{
    Console.WriteLine("Введено неправильное число. Укажите число от 1 до 7");
    return; // На блок схеме выход
} 
if (number == 1){Console.WriteLine($"{number} день недели Monday");}
if (number == 1){Console.WriteLine($"{number} день недели Tuesday");}
if (number == 3){Console.WriteLine($"{number} день недели Wednesday");}
if (number == 4){Console.WriteLine($"{number} день недели Thursday");}
if (number == 5){Console.WriteLine($"{number} день недели Friday");}
if (number == 6){Console.WriteLine($"{number} день недели Saturday");}
if (number == 7){Console.WriteLine($"{number} день недели Sunday");}
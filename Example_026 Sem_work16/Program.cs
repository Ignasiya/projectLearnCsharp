﻿/* На столе лежат n монеток. Некоторые из них лежат вверх решкой, а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть, 
 чтобы все монетки были повернуты вверх одной и той же стороной. */

Console.Clear();
Console.Write("Сколько монеток?");
int Ntemp = 0;
int Ptemp = 0;
int size_monet = int.Parse(Console.ReadLine());
int[] a = new int[size_monet];

for (int i = 0; i < size_monet; i++){
    a[i] = new Random().Next(0, 2);
    Console.Write($"{a[i]} ");
    if (a[i] == 0) Ntemp++;
    else Ptemp++;
}
if (Ntemp > Ptemp) Console.WriteLine($"Минимально{Ntemp}");
else Console.WriteLine($"Минимально{Ptemp}");
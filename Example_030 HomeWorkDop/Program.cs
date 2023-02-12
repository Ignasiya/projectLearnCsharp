/* Петя впервые пришел на урок физкультуры в новой школе. Перед началом урока ученики выстраиваются по росту, 
в порядке невозрастания. Напишите программу, которая определит на какое место в шеренге Пете нужно встать, чтобы 
не нарушить традицию, если заранее известен рост каждого ученика и эти данные уже расположены по невозрастанию 
(то есть каждое следующее число не больше предыдущего). Если в классе есть несколько учеников с таким же ростом, как 
у Пети, то программа должна расположить его после них.

Входные данные
Первая строка входного файла INPUT.TXT содержит натуральное число N (N ≤ 100) – количество учеников (не считая Петю). 
Во второй строке записаны N натуральных чисел Ai (Ai ≤ 200) – рост учеников в сантиметрах в порядке невозрастания. 
Третья строка содержит единственное натуральное число X (X ≤ 200) – рост Пети.

Выходные данные
В выходной файл OUTPUT.TXT выведите единственное целое число – номер Пети в шеренге учеников. */

/* using System;

class Program {
static void Main(string[] args) {
Console.WriteLine("Hello, world!");
}
} */

Console.Clear();
// Вводные данные
Console.Write("Введите количество учеников (не считая Петю): ");
int countStudents = int.Parse(Console.ReadLine());
Console.Write("Введите рост Пети, в сантиметрах: ");
int heightPeti = int.Parse(Console.ReadLine());
// Уточнение роста Пети, не карлик и не дылда же
while (heightPeti < 150 || heightPeti > 200){
    Console.Write("Введен неверный рост, укажите верный рост Пети, в сантиметрах: ");
    heightPeti = int.Parse(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine($"Шеренга без Пети ");
// Расставляю рандомно рост остальных учеников в шеренге
countStudents++;
int[] sherenga = new int[countStudents];
int index = 0;
while (index < countStudents - 1){
    sherenga[index] = new Random().Next(150, 201);
    Console.Write($"{sherenga[index]} ");
    index++;
}
sherenga[countStudents - 1] = heightPeti;
Console.WriteLine();
Console.WriteLine($"Шеренга с Петей ");
// Проверка шеренги с Петей
int iWithPeti = 0;
while (iWithPeti < countStudents){    
    Console.Write($"{sherenga[iWithPeti]} ");
    iWithPeti++;
}
Console.WriteLine();
Console.WriteLine($"Шеренга выстраивается в порядке невозрастания");
// Начинаю пузырьковую сортировку
int i = 0;
while (i < countStudents){
    for (int j = 0; j < countStudents - 1; j++){
        if (sherenga[j] < sherenga[j+1]){
            int temp = sherenga[j];
            sherenga[j] = sherenga[j+1];
            sherenga[j+1] = temp;
        }        
    }
    i++;
}
// После сротировки
int isort = 0;
while (isort < countStudents){    
    Console.Write($"{sherenga[isort]} ");
    isort++;
}
Console.WriteLine();
// Где же теперь Петя?
int indexWithPeti = 0;
int position = 0;
while (indexWithPeti < countStudents){
    if(sherenga[indexWithPeti] == heightPeti)    {
        position = indexWithPeti;        
    }
    indexWithPeti++;
}
Console.WriteLine($"Место Пети в шеренге {position+1}");
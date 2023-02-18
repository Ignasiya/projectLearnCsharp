/* Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();
Console.Write($"Введите число: ");
int number = int.Parse(Console.ReadLine());
int index = 1;
int size = number; // Размер массива запоминаем
if (number < 0){ // Для отрицательного значения
    index = number; // Смещаем массив в отрицательные значения
    size = -number; // Размер массива делаем положительным
    number = -1; // Для работы Цикла до -1
}
int[] result = new int[size];
int jndex = 0;
for (; index <= number; index ++){ // Можно не объявлять index
    result[jndex] = index * index * index;
    jndex++;
}for (jndex = 0; jndex < size; jndex++){ // Выводим прогу
    Console.Write($"{result[jndex]} ");
}
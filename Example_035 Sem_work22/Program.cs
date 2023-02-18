// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int index = 1;
int perM = number; // Размер массива
if (number < 0){ // Для отрицательного значения
    index = number; // Смещаем массив в отрицательные значения
    perM = -number; // Размер массива делаем положительным
    number = -1; // Для работы Цикла до -1
}
int[] result = new int[perM];
int jndex = 0;
for (; index <= number; index ++){ // Можно не объявлять index
    result[jndex] = index * index;
    jndex++;
}for (jndex = 0; jndex < perM; jndex++){ // Выводим прогу
    Console.Write($"{result[jndex]} ");
}
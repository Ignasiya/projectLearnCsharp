Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()); // Здесь int.Parse конвертирует введенные в целое число
int sqr = number * number; // number *= number <=> number = number * number
Console.WriteLine($"Квадрат числа {number} number -> {sqr}({number * number})"); // интерпалция $ - текст
int sqr1 = Convert.ToInt32(Math.Pow(number, 2)); //Toint32 - в double Math.Pow библиотека
Console.WriteLine($"Квадрат числа {number} number -> {sqr1}");
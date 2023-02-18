// **Задача 18:**
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write($"Введите номер четверти: ");
int chetvert = int.Parse(Console.ReadLine());
/* 
while (chetvert < 1 || chetvert > 4){
    Console.Write($"Введено неверное число, укажите верное число: ");
    chetvert = int.Parse(Console.ReadLine());
}

if (chetvert == 1){
    Console.WriteLine($"X > 0 и Y > 0");
}else if(chetvert == 2){
    Console.WriteLine($"X < 0 и Y > 0");
}else if(chetvert == 3){
    Console.WriteLine($"X < 0 и Y < 0");
}else if(chetvert == 4){
    Console.WriteLine($"X > 0 и Y < 0");
}
*/
switch (chetvert) // return - завершает программу, break - завершает конструкцию
{
    case 1:{ // Для конкретного значения
        Console.WriteLine($"X > 0 и Y > 0");
        break;
        }
        case 2:{
        Console.WriteLine($"X < 0 и Y > 0");
        break;
        }
        case 3:{
        Console.WriteLine($"X < 0 и Y < 0");
        break;
        }
        case 4:{
        Console.WriteLine($"X > 0 и Y < 0");
        break;
        }
        default:{ // всегда работает
        Console.WriteLine($"Введено неверное число");
        break;
        }
}
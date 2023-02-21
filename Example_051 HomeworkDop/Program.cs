/* Хочу написать прогу по перерводу разрядов числа в массив без использования string и list */

ulong Input(string text) // Ввод и проверка на натуральное число, если минус то баг
{
    Console.Write(text);
    ulong num = ulong.Parse(Console.ReadLine());
    while (num <= 0){
    Console.WriteLine($"Неверное значение");
    Console.Write(text);
    num = ulong.Parse(Console.ReadLine());
    }
    return num;
}

int Count(ulong size) // Размер массива, если первое ноль, то не входит в массив
{
    int count = 0;
    while (size > 0){
        size = size / 10;
        count ++;
    }
    return count;    
}

int[] Array(ulong size, int count) // Создание массива из разрядов числа
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++){
        array[count - 1 - i] = Convert.ToInt32(size % 10);
        size /= 10;
    }
    return array;
}

void Polimorf(int[] array)
{
    int count = 0;
    int length = array.Length;
    for (int i = 0; i < length/2; i++){
        if (array[i] == array[length - 1 - i]) count ++;
    }
    if (count == length/2) Console.WriteLine($"Число полиморфно");
    else Console.WriteLine($"Число не полиморфно");
}



Console.Clear();
Console.WriteLine($"Задачки с переводом числа в массив");
ulong number = Input($"Введите натуральное число: ");
int sizeArray = Count(number);
int[] arrayNum = Array(number, sizeArray);
Console.WriteLine($"[{String.Join(", ", arrayNum)}]");
Polimorf(arrayNum);
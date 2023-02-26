/* Одного неформала выгнали с работы, и теперь ему надо как-то зарабатывать себе на жизнь. 
Поразмыслив, он решил, что сможет иметь очень неплохие деньги на продаже собственных волос. 
Известно, что пункты приема покупают волосы произвольной длины стоимостью С у.е. за каждый сантиметр. 
Так как волосяной рынок является очень динамичным, то цена одного сантиметра волос меняется каждый день как и курс валют. 
Неформал является очень хорошим бизнес-аналитиком. Он смог вычислить, какой будет цена одного сантиметра волос в каждый 
из ближайших N дней (для удобства пронумеруем дни в хронологическом порядке от 0 до N-1). Теперь он хочет определить, 
в какие из этих дней ему следует продавать волосы, чтобы по истечению всех N дней заработать максимальное количество денег. 
Заметим, что волосы у неформала растут только ночью и вырастают на 1 сантиметр за ночь. Следует также учесть, что до 0-го 
дня неформал с горя подстригся наголо и к 0-му дню длина его волос составляла 1 сантиметр. */

int[] Array(int size)  // Формирую массив из рандомных чисел
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(1, 101);               
    }
    return array;    
}

int Input(string text)  // Ввод размера массива
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    while (num <= 0){
    Console.WriteLine($"Неверное значение");
    Console.Write(text);
    num = int.Parse(Console.ReadLine());
    }
    return num;
}

int Result(int[] array, int day) // Расчет максимального значения и его индекса
{
    int max = 0; int maxDay = 0;
    while(day < array.Length){
        if(max < array[day]){
            max = array[day];
            maxDay = day;          
        }day ++;
    }    
    return maxDay;
}

Console.Clear();
int size = Input($"Введите количество дней: ");
int[] array = Array(size);
Console.WriteLine($"Цены на все дни -> [{String.Join(", ", array)}]");
int daySale = Result(array, 0);
int cash = (daySale + 1) * array[daySale];
Console.WriteLine($"Продал в {daySale} день, всего заработал {cash}"); // До сюда работает отлично

// Не стал записывать в метод, сам потом не разбирусь
int temp = 0;
while (daySale < array.Length - 1){
    temp = Result(array, daySale + 1);
    cash = cash + (temp - daySale) * array[temp];
    daySale = temp;
    Console.WriteLine($"Продал в {daySale} день, всего заработал {cash}");    
}
Console.WriteLine($"На продаже волосов заработал -> {cash}");
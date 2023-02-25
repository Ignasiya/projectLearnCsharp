//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

Console.Clear();
int[] array = Array(12);
int[] result = Result(array);
Console.WriteLine();
Console.WriteLine(String.Join(", ", result));

int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(-9, 10);
        Console.Write($"{array[i]} ");
    }
    return array;    
}

int[] Result(int[] array)
{
    int[] mass = new int[2];
    foreach (int el in array)    
    {
        mass[0] += el > 0 ? el : 0;
        mass[1] += el < 0 ? el : 0;
    }
    return mass;
}
/* Доп:
Игра «Жизнь» была придумана английским математиком Джоном Конвейем в 1970 году.
Впервые описание этой игры опубликовано в октябрьском выпуске (1970) журнала Scientic American,
в рубрике «Математические игры» Мартина Гарднера.

Место действия этой игры – «вселенная» – это размеченная на клетки поверхность.
Каждая клетка на этой поверхности может находиться в двух состояниях: быть живой или быть мертвой.
Клетка имеет восемь соседей. Распределение живых клеток в начале игры называется первым поколением.
Каждое следующее поколение рассчитывается на основе предыдущего по таким правилам:

1)пустая(мертвая) клетка с ровно тремя живыми клетками-соседями оживает;
2)если у живой клетки есть две или три живые соседки, то эта клетка продолжает жить;
в противном случае (если соседок меньше двух или больше трех)
клетка умирает(от «одиночества» или от «перенаселенности»).
В этой задаче рассматривается игра «Жизнь» на торе.
Представим себе прямоугольник размером n строк на m столбцов.
Для того, чтобы превратить его в тор мысленно «склеим» его верхнюю сторону с нижней, а левую с правой.

Таким образом, у каждой клетки, даже если она раньше находилась на границе прямоугольника,
теперь есть ровно восемь соседей.

Ваша задача состоит в том, чтобы найти конфигурацию клеток, которая будет через k поколений от заданного.

n m k(4 ≤ n, m ≤ 100; 0 ≤ k ≤ 100).

5 5 1          5 5 5           4 7 5
++...  .+.++   ++...   .+++.   .+.+.+.   .......
..++.  +.+..   ..++.   .+...   +.+.+.+   .......
.+...  .+.+.   .+...   .+...   .+.+.+.   .......
..+..  ..+..   ..+..   ..++.   +.+.+.+   .......
...+.  .++..   ...+.   ..... */

using System;
using static System.Console;

// Основное действие
Clear();
string[,] planet = {
    {"", "#", "-", "-", "-"}, 
    {"-", "-", "#", "#", "-"}, 
    {"-", "#", "-", "-", "-"}, 
    {"-", "-", "#", "-", "-"}, 
    {"-", "-", "-", "#", "-"}
    };
// LiveDeathPlanet("Введите размеры планеты (высота, ширина) через пробел и нажмите Enter: ");
// PopulatePlanet(planet);
SeePlanet(planet);
WriteLine();
Write("Введите количество поколений, нажмите Enter и наблюдаем симуляцию: ");
int countGenerations = int.Parse(ReadLine());
int generation = 0;
while(generation <= countGenerations){
    Clear();
    string[,] evolutionCurrent = IncreasePlanet(planet);  
    for (int i = 1; i < evolutionCurrent.GetLength(0) - 1; i++){
        for (int j = 1; j < evolutionCurrent.GetLength(1) - 1; j++){
            int count = Survival(planet, evolutionCurrent, i, j);
            if (evolutionCurrent [i, j] == "-" && count == 3){
                planet [i - 1, j - 1] = "#";
            }else if (evolutionCurrent [i, j] == "#" && (count < 3 || count > 4)){
                planet [i - 1, j - 1] = "-";
            }else if (evolutionCurrent [i, j] == "#" && (count >= 3 && count <= 4)){
                planet [i - 1, j - 1] = "#";
            }else{
                planet [i - 1, j - 1] = "-";
            }
        }
    }
    SeePlanet(planet);
    await Task.Delay(4000);
    generation++;
}

string[,] IncreasePlanet(string[,] planet) // Увеличение планеты
{
    string[,] evolution = new string[planet.GetLength(0) + 2, planet.GetLength(1) + 2];
    // Увидеть соседей
    for (int i = 0; i < planet.GetLength(0); i++){
        for (int j = 0; j < planet.GetLength(1); j++){
            evolution[i + 1, j + 1] = planet[i, j];
        }
    }
    // Бока
    for (int i = 0; i < planet.GetLength(0); i++){
        evolution[i + 1, 0] = planet[i, planet.GetLength(1) - 1];
        evolution[i + 1, evolution.GetLength(1) - 1] = planet[i, 0];
    }
    // Вверх и низ
    for (int i = 0; i < planet.GetLength(1); i++){
        evolution[0, i + 1] = planet[planet.GetLength(0) - 1, i];
        evolution[evolution.GetLength(0) - 1, i + 1] = planet[0, i];
    }
    // Углы
    evolution[0, 0] = planet[planet.GetLength(0) - 1, planet.GetLength(1) - 1];
    evolution[evolution.GetLength(0) - 1, 0] = planet[0, planet.GetLength(1) - 1];
    evolution[0, evolution.GetLength(1) - 1] = planet[planet.GetLength(0) - 1, 0];
    evolution[evolution.GetLength(0) - 1, evolution.GetLength(1) - 1] = planet[0, 0];
    return evolution;
}

int Survival(string[,] planet, string[,] evolution, int i, int j) // Проверка на жизнь
{
    int count = 0;
    for (int k = i - 1; k <= i + 1; k++){
        for (int l = j - 1; l <= j + 1; l++){
            if (evolution[k, l] == "#"){
                count ++;
            } 
        }
    }
    return count;
}

string[,] LiveDeathPlanet(string text) // Задаем размеры планеты
{
    Write(text);
    int[] sizePlanet = ReadLine().Split(" ").Select(int.Parse).ToArray();
    string[,] planet = new string[sizePlanet[0] ,sizePlanet[1]];
    return planet;
}

void PopulatePlanet(string[,] array) // Задаем жизнь на планете
{
    string[] chars = {"#", "-"};
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i,j] = chars[new Random().Next(0, 2)];
        }        
    }
}

void SeePlanet(string[,] array) // Увидеть планету
{
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Write($"{array[i,j]} ");
        }
        WriteLine();
    }
}
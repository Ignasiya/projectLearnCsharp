/* Тетрис на минималках */

Console.Clear(); // Подготовка
string[,] tetris = new string[17, 10];
for(int i = 0; i < tetris.GetLength(0); i++){
    for(int j = 0; j < tetris.GetLength(1); j++){
        tetris[i,j] = " ";
    }
Console.WriteLine();
}
Border(tetris);

// Основное действие c бесконечным циклом
for(int i = 0; ; i++){
    Console.Clear();
    UpdateTetris(tetris);
    string[,] tempFigure = GenerateFigure();
    for (int j = 0; j < tetris.GetLength(0)-1; j++){
        int u = 0;
        for (; u < tempFigure.GetLength(1); u++)
            tetris[j,u+2] = tempFigure[i,u];
    }
    Thread.Sleep(2000);
}

void UpdateTetris(string[,] tetris) // Метод обновления поля для тетриса
{
    for(int i = 0; i < tetris.GetLength(0); i++){
        for(int j = 0; j < tetris.GetLength(1); j++){
            Console.Write($"{tetris[i,j]} ");
        }
    Console.WriteLine();
    }
}

void Border(string[,] array) // Метод изготовки рамки
{
    int y = 0; int x = 0;
    for (; y < array.GetLength(0) - 1; y++) array[y, x] = "*";
    for (; x < array.GetLength(1) - 1; x++) array[y, x] = "*";
    for (; y >= 0; y--) array[y,x] = "*";
}

string[,] GenerateFigure() // Генератор фигур
{
    string [,] tetrisFigO = new string[2, 2]{ 
    {"#", "#"},
    {"#", "#"}, 
};
    string [,] tetrisFigI = new string[4, 4]{ 
    {" ", " ", "#", " "},
    {" ", " ", "#", " "},
    {" ", " ", "#", " "},
    {" ", " ", "#", " "},
};
    string [,] tetrisFigL = new string[3, 3]{ 
    {"#", " ", " "},
    {"#", " ", " "},
    {"#", "#", " "}, 
};
    string [,] tetrisFigZ = new string[3, 3]{ 
    {" ", " ", " "},
    {"#", "#", " "},
    {" ", "#", "#"}, 
};
    string [,] tetrisFigT = new string[3, 3]{ 
    {" ", " ", " "},
    {"#", "#", "#"},
    {" ", "#", " "}, 
};
    string[,] array = tetrisFigT;
    switch(new Random().Next(1, 6)){    
        case 1:{array = tetrisFigO; break;}
        case 2:{array = tetrisFigI; break;}
        case 3:{array = tetrisFigL; break;}
        case 4:{array = tetrisFigZ; break;}
        case 5:{array = tetrisFigT; break;}
    }return array;
}

void ControlKey(string[,] tetris)
{

}
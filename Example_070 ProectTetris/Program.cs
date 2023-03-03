/* Тетрис на минималках */

Console.Clear(); // Подготовка - создание поля и заполнение его пробелами
string[,] tetris = new string[17, 10];
for(int i = 0; i < tetris.GetLength(0); i++){
    for(int j = 0; j < tetris.GetLength(1); j++){
        tetris[i,j] = " ";
    }
}
Border(tetris); // Рамка из *

for(int i = 0; ; i++){ // Основное действие c бесконечным циклом
    Console.Clear();
    UpdateTetris(tetris);    
    int high = 0; int width = 3;
    string [,] tetrisFig = GenerateFigure(); // Задаем случайную фигуру
    while(high < 17){ // Граница
        // Рисуем фигуру
        for (int y = 0; y < tetrisFig.GetLength(0); y++){
            for (int x = 0; x < tetrisFig.GetLength(1); x++){
                if (tetris[high + y, width + x] != "#")
                    tetris[high + y, width + x] = tetrisFig[y ,x];
            }
        }        
        Console.Clear();
        UpdateTetris(tetris);        
        if (MoveValidateDown(tetris, tetrisFig, high, width) == true) break;        
        ClearFigure(tetris, tetrisFig, high, width); // Стирает фигуру 
        if ((Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.RightArrow)){
            width++;            
            for (int y = 0; y < tetrisFig.GetLength(0); y++){
                for (int x = 0; x < tetrisFig.GetLength(1); x++){
                    if (tetris[high + y, width + x] != "#")
                        tetris[high + y, width + x] = tetrisFig[y ,x];
                }
            }   
            Console.Clear();
            UpdateTetris(tetris);
            ClearFigure(tetris, tetrisFig, high, width);            
        }        
        await Task.Delay(2000);        
        high++;
    }
    RewriteTetris(tetris);// Перерисовывает поле
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

void RewriteTetris(string[,] tetris) // Метод перерисовывания поля для тетриса
{
    for(int i = 0; i < tetris.GetLength(0); i++){
        for(int j = 1; j < tetris.GetLength(1) - 1; j++){
            if (tetris[i, j] == "*") tetris[i, j] = "#";
        }
    }
}

void Border(string[,] array) // Метод изготовки рамки по краям
{
    int y = 0; int x = 0;
    array[y, x] = "|";
    for (; y < array.GetLength(0) - 1; y++) array[y, x] = "|";
    for (x = 1; x < array.GetLength(1) - 1; x++) array[y, x] = "―";
    for (; y > 0; y--) array[y - 1, x] = "|";
}

string[,] GenerateFigure() // Генератор фигур
{
    string[,] tetrisFigO = new string[2,2]{
        {"*", "*"},
        {"*", "*"},
    };
    string[,] tetrisFigI = new string[4,1]{
        {"*"},
        {"*"},
        {"*"},
        {"*"},
    };
    string[,] tetrisFigL1 = new string[2,3]{
        {"*", " ", " "},
        {"*", "*", "*"},
    };
    string[,] tetrisFigL2 = new string[2,3]{
        {" ", " ", "*"},
        {"*", "*", "*"},
    };
    string[,] tetrisFigZ1 = new string[2,3]{
        {" ", "*", "*"},
        {"*", "*", " "},
    };
    string[,] tetrisFigZ2 = new string[2,3]{
        {"*", "*", " "},
        {" ", "*", "*"},
    };
    string[,] tetrisFigT = new string[2,3]{
        {" ", "*", " "},
        {"*", "*", "*"},
    };
    string[,] figure = tetrisFigO;
    switch(new Random().Next(1, 6)){    
        case 1:{break;}
        case 2:{figure = tetrisFigI; break;}
        case 3:{figure = tetrisFigL1; break;}
        case 4:{figure = tetrisFigL2; break;}
        case 5:{figure = tetrisFigZ1; break;}
        case 6:{figure = tetrisFigZ2; break;}
        case 7:{figure = tetrisFigT; break;}
    };
    return figure;
}

void ClearFigure(string[,] tetris, string[,]tetrisFig, int high, int width) // Стирает фигуру
{
    for (int y = 0; y < tetrisFig.GetLength(0); y++){
        for (int x = 0; x < tetrisFig.GetLength(1); x++){
            if(tetris[high + y, width + x] == "*")
                tetris[high + y, width + x] = " ";
        }
    }
}

bool MoveValidateDown(string[,] tetris , string[,] tetrisFig, int high, int width) // Проверка на движение вниз
{
    for (int y = 0; y < tetrisFig.GetLength(0); y++){
        for (int x = 0; x < tetrisFig.GetLength(1); x++){
            if (tetris[high + y, width + x] == "*"){
                if (tetris[high + y + 1, width + x] == "#" ||
                tetris[high + y + 1, width + x] == "―") return true;
            }                          
        }
    }
    return false;
}

bool MoveValidateRight(string[,] tetris , string[,] tetrisFig, int high, int width) // Проверка на движение вправо
{
    for (int y = 0; y < tetrisFig.GetLength(0); y++){
        for (int x = 0; x < tetrisFig.GetLength(1); x++){
            if (tetris[high + y, width + x] == "*"){
                if (tetris[high + y, width + x + 1] == "#" ||
                tetris[high + y, width + x + 1] == "|") return true;
            }
        }
    }
    return false;
}

void MoveValidateLeft(string[,] tetris , string[,] tetrisFig, int high, int width) // Проверка на движение влево
{
    for (int y = 0; y < tetrisFig.GetLength(0); y++){
        for (int x = tetrisFig.GetLength(1) - 1; x >= 0; x--){
            if (tetris[high + y, width + x] == "*"){
                if (tetris[high + y, width + x - 1] == "#" ||
                tetris[high + y, width + x - 1] == "―") return;
            }                          
        }
        for (y = 0; y < tetrisFig.GetLength(0); y++){
            for (int x = 0; x < tetrisFig.GetLength(1); x++){                
                if (tetris[high + y, width + x - 1] != "#")
                    tetris[high + y, width + x - 1] = tetrisFig[y ,x];
            }
        }
    }    
}
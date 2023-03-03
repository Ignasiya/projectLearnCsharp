/* Тетрис на минималках */

Console.Clear(); // Подготовка - создание поля и заполнение его пробелами
string[,] tetris = new string[20, 14];
for(int i = 0; i < tetris.GetLength(0); i++){
    for(int j = 0; j < tetris.GetLength(1); j++){
        tetris[i,j] = " ";
    }
}
Border(tetris); // Рамка из *

for(int i = 0; ; i++){ // Основное действие c бесконечным циклом
    Console.Clear();
    UpdateTetris(tetris);    
    int high = 0; int width = 6;
    string [,] tetrisFig = GenerateFigure(); // Задаем случайную фигуру
    while(high < 18){ // Действие        
        PaintFigure(tetris, tetrisFig, high, width);
        Console.Clear();
        UpdateTetris(tetris);        
        while (Console.KeyAvailable == true)
        {
            var btn = Console.ReadKey(true).Key;
            if (btn == ConsoleKey.RightArrow && MoveValidateRight(tetris, tetrisFig, high, width) == false){               
                ClearFigure(tetris, tetrisFig, high, width);
                width++;                
                PaintFigure(tetris, tetrisFig, high, width);
                Console.Clear();
                UpdateTetris(tetris);                
            }
            if (btn == ConsoleKey.LeftArrow && MoveValidateLeft(tetris, tetrisFig, high, width) == false){
                ClearFigure(tetris, tetrisFig, high, width);
                width--;
                PaintFigure(tetris, tetrisFig, high, width);
                Console.Clear();
                UpdateTetris(tetris);                
            }
            if (btn == ConsoleKey.UpArrow){
                ClearFigure(tetris, tetrisFig, high, width);
                tetrisFig = RotateFigure(tetrisFig);
                PaintFigure(tetris, tetrisFig, high, width);
                Console.Clear();
                UpdateTetris(tetris);                
            }
            if (btn == ConsoleKey.DownArrow && MoveValidateDown(tetris, tetrisFig, high, width) == false){
                ClearFigure(tetris, tetrisFig, high, width);
                high++;
                PaintFigure(tetris, tetrisFig, high, width);
                Console.Clear();
                UpdateTetris(tetris);                
            }
        }
        await Task.Delay(1000);
        if (MoveValidateDown(tetris, tetrisFig, high, width) == true) break;
        ClearFigure(tetris, tetrisFig, high, width);
        high++;
        FillTetris(tetris); // удаляет полосу полную        
    }    
    RewriteTetris(tetris);// Перерисовывает поле
}

void PaintFigure(string[,] tetris, string[,]tetrisFig, int high, int width){ // Рисует фигуру
    for (int y = 0; y < tetrisFig.GetLength(0); y++){
        for (int x = 0; x < tetrisFig.GetLength(1); x++){
            if (tetrisFig[y ,x] == "*")
                tetris[high + y, width + x] = tetrisFig[y ,x];
        }
    }
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

void FillTetris(string[,] tetris) // Стереть заполненную линию
{
    for (int y = 1; y < tetris.GetLength(0) - 3; y++){
        int count = 0;
        for (int x = 3; x < tetris.GetLength(1) - 3; x++){
            if (tetris[y, x] == "#") count++;
        }
        if (count == 8){
            for (; y > 0; y--){                    
                for (int x = 3; x < tetris.GetLength(1) - 3; x++){
                    tetris[y, x] = tetris[y - 1, x];
                }
            }
        }
    }
}

void Border(string[,] array) // Метод изготовки рамки по краям
{
    int y = 1; int x = 2;
    array[y, x] = "|";
    for (; y < array.GetLength(0) - 3; y++) array[y, x] = "|";
    for (x = 3; x < array.GetLength(1) - 3; x++) array[y, x] = "―";
    for (; y > 1; y--) array[y - 1, x] = "|";
}

string[,] GenerateFigure() // Генератор фигур
{
    string[,] tetrisFigO = new string[2,2]{
        {"*", "*"},
        {"*", "*"},
    };
    string[,] tetrisFigI = new string[4,4]{
        {" ", "*", " ", " "},
        {" ", "*", " ", " "},
        {" ", "*", " ", " "},
        {" ", "*", " ", " "},
    };
    string[,] tetrisFigL1 = new string[3,3]{
        {" ", " ", " "},
        {"*", " ", " "},
        {"*", "*", "*"},
    };
    string[,] tetrisFigL2 = new string[3,3]{
        {" ", " ", " "},
        {" ", " ", "*"},
        {"*", "*", "*"},
    };
    string[,] tetrisFigZ1 = new string[3,3]{
        {" ", " ", " "},
        {" ", "*", "*"},
        {"*", "*", " "},
    };
    string[,] tetrisFigZ2 = new string[3,3]{
        {" ", " ", " "},
        {"*", "*", " "},
        {" ", "*", "*"},
    };
    string[,] tetrisFigT = new string[3,3]{
        {" ", " ", " "},
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

string[,] RotateFigure(string[,]tetrisFig) // Поворот фигуры
{
    string[,] res = new string[tetrisFig.GetLength(0), tetrisFig.GetLength(1)];
    for(int i = 0; i < tetrisFig.GetLength(0); i++)
        for (int j = 0; j < tetrisFig.GetLength(1); j++)
            res[j, tetrisFig.GetLength(0) - i - 1] = tetrisFig[i, j];
    return res;
}

bool MoveValidateDown(string[,] tetris, string[,] tetrisFig, int high, int width) // Проверка на движение вниз
{
    for (int y = 0; y < tetrisFig.GetLength(0); y++){
        for (int x = 0; x < tetrisFig.GetLength(1); x++){            
            if (tetris[high + y, width + x] == "*" && tetris[high + y + 1, width + x] == "―") return true;
            else if (tetris[high + y, width + x] == "*" && tetris[high + y + 1, width + x] == "#") return true;
        }
    }    
    return false;
}

bool MoveValidateRight(string[,] tetris, string[,] tetrisFig, int high, int width) // Проверка на движение вправо
{
    for (int y = 0; y < tetrisFig.GetLength(0); y++){
        for (int x = 0; x < tetrisFig.GetLength(1); x++){
            if (tetris[high + y, width + x] == "*" && tetris[high + y, width + x + 1] == "|") return true;
            else if (tetris[high + y, width + x] == "*" && tetris[high + y, width + x + 1] == "#") return true;
        }
    }
    return false;
}

bool MoveValidateLeft(string[,] tetris, string[,] tetrisFig, int high, int width) // Проверка на движение влево
{
    for (int y = 0; y < tetrisFig.GetLength(0); y++){
        for (int x = tetrisFig.GetLength(1) - 1; x >= 0; x--){
            if (tetris[high + y, width + x] == "*" && tetris[high + y, width + x - 1] == "#") return true;
            else if (tetris[high + y, width + x] == "*" && tetris[high + y, width + x - 1] == "|") return true;
        } 
    }  
    return false; 
}
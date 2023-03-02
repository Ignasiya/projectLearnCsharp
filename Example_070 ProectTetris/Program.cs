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
    while(high < 17){ // Граница
        if (TetrisFigO(tetris, high, width) == true) break;
        high++;        
        await Task.Delay(2000);
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

void Border(string[,] array) // Метод изготовки рамки
{
    int y = 0; int x = 0;
    for (; y < array.GetLength(0) - 1; y++) array[y, x] = "*";
    for (; x < array.GetLength(1) - 1; x++) array[y, x] = "*";
    for (; y >= 0; y--) array[y,x] = "*";
}

/* void GenerateFigure() // Генератор фигур
{
    switch(new Random().Next(1, 6)){    
        case 1:{TetrisFigO; break;}
        case 2:{TetrisFigI; break;}
        case 3:{TetrisFigL; break;}
        case 4:{TetrisFigZ; break;}
        case 5:{TetrisFigT; break;}
    };
} */

bool TetrisFigO(string[,] tetris, int high, int width) // Метод написания фигуры О
{
    string[,] tetrisFigO = new string[2,2];    
    // Рисует фигуру
    for (int y = 0; y < tetrisFigO.GetLength(0); y++){
        for (int x = 0; x < tetrisFigO.GetLength(1); x++){
            tetrisFigO[y ,x] = "#";
            tetris[high + y, width + x] = tetrisFigO[y ,x];
        }
    }
    Console.Clear();
    UpdateTetris(tetris);
    if (MoveValidateDown(tetris, tetrisFigO, high, width) == true) return true;
    // Стирает фигуру
    for (int y = 0; y < tetrisFigO.GetLength(0); y++){
        for (int x = 0; x < tetrisFigO.GetLength(1); x++){
            tetris[high + y, width + x] = " ";
        }
    }
    return false;
}

void TetrisFigI()
{

}

void TetrisFigL()
{

}

void TetrisFigZ()
{

}

void TetrisFigT()
{

}

bool MoveValidateDown(string[,] tetris , string[,] tetrisFig, int high, int width) // Проверка на движение вниз
{
    for (int y = 0; y < tetrisFig.GetLength(0); y++){
        for (int x = 0; x < tetrisFig.GetLength(1); x++){
            if (tetris[high + tetrisFig.GetLength(0), width + x] != " ") return true; // Нижняя сторона
        }
    }
    return false;
}
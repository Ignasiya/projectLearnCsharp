/* 
Доп на вход массив удалить все повторения
1. Массив для уникальных значений
2. Функция ищет значения в массиве

*/

bool FindElInMas(string[] array, string el){
    for (int i = 0; i < array.Length; i++)
        if (el == array[i])
            return false;
    return true;
}

 List<string> split(string s){ // массив продвинутый
    List<string> result = new List<string>(); // [] - динамический массив
    s += "; ";
    string s1 = "";
    
    for (int i = 0; i < s.Length - 1; i++){
        if ("; " == s[i].ToString() + s[i + 1].ToString()){
            result.Add(s1);
            s1 = "";
            i++;
        }else{
            s1 += s[i];
        }
    }
    return result;
}

void Print(List<string> s){
    for (int i = 0; i < s.Count - 1; i++){
        Console.Write($"{s[i]}, ");
    }
    Console.WriteLine(s[s.Count - 1]);
}

Print(split("123, 124; aasdas; asdasd"));
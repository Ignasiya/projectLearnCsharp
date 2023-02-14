/* В доме живет N жильцов. Однажды решили провести перепись всех жильцов данного дома и составили список, 
в котором указали возраст и пол каждого жильца. Требуется найти номер самого старшего жителя мужского пола. */

// Здесь будут методы


Console.Clear();
// Вводные данные
Console.Write($"Введите количество квартир МКД: ");
uint apartament = uint.Parse(Console.ReadLine());
// Представлю список квартир с 1 до N
int[] ListApartament = new int[apartament];
    for (int i = 0; i < apartament; i++){
    ListApartament[i] = i + 1;
    int CountResident = new Random().Next(0, 8);
    int[] AgeResident = new int[CountResident];
    Console.Write($"кв.{ListApartament[i]}->жильцов {CountResident}");
    if (CountResident > 0){
        for (int j = 0; j < CountResident; j++){
            AgeResident[j] = new Random().Next(0, 100); // Будь, что будет
            int GenderResident = new Random().Next(0, 2);
            string gender = "";
            if (GenderResident == 0){
                gender = "М";
            }else{
                gender = "Ж";
            }
            Console.Write($"->возр.{AgeResident[j]},пол({gender})");
        }        
    }
    Console.WriteLine();
}

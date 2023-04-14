App<Worker> app = new App<Worker>(new PostgresRepository("db14042023"));

app.Create(new("Василий Иванов", 22, 3312));
app.Create(new("Василий Петров", 33, 4546));
app.Create(new("Иван Васильев", 44, 1124));

app.Print(); Console.WriteLine();

app.Remove(2);

app.Print(); Console.WriteLine();

app.Update(1, new("Sergei Kam", 122, 31312));
app.Print(); Console.WriteLine();
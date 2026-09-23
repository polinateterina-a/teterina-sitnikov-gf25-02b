using BusinessLogic;

var logic = new Logic();
bool up = true;
// для теста
//logic.AddStudent("Артем", "ГФ25-02Б", "Прикладная информатика");
//logic.AddStudent("Полина", "гф25-02б", "прикладная информатика");
//logic.AddStudent("Полина", "гф25-02б", "прикладная информатика");
//logic.AddStudent("Сергей", "ГФ25-01Б", "Прикладная информатика");
//logic.AddStudent("Алина", "ГФ25-01Б", "Прикладная информатика");
//logic.AddStudent("Карина", "ГФ25-01Б", "прикладная информатика");
//logic.AddStudent("Карина", "ГФ25-01Б", "прикладная информатика");
//logic.AddStudent("Виктор", "ИК26-02Б", "Не знаю как назвать направление");
//logic.AddStudent("Александр", "ИК26-01Б", "не знаю как назвать направление");
//logic.AddStudent("Карина", "ИК26-01Б", "Не знаю как назвать направление 2");

while (up)
{
    Console.WriteLine("1) Добавить студента" +
                      "\n2) Удалить студента" +
                      "\n3) Вывести весь список в таблицу" +
                      "\n4) Вывести гистограмму: распределение студентов по специальности" +
                      "\n0) Выйти из программы");
    Console.Write("\nВведите число от 0 до 4: ");
    string input = Console.ReadLine();
    switch (input)
    {
        case "1":
            AddMenu(logic);
            break;
        case "2":
            DeleteMenu(logic);
            break;
        case "3":
            ShowAll(logic);
            break;
        case "4":
            ShowHistogram(logic);
            break;
        case "0":
            up=false; break;
        default:
            Console.WriteLine("Введите число от 0 до 4!!!");
            break;
    }
}

void AddMenu(Logic logic)
{
    while (true)
    {
        Console.Write("Имя: ");
        string Name = Console.ReadLine();
        Console.Write("Группа: ");
        string Group = Console.ReadLine();
        Console.Write("Направелние: ");
        string Discipline = Console.ReadLine();

        if (logic.AddStudent(Name, Group, Discipline, out string error))
        {
            Console.WriteLine("Студент добавлен");
            break;
        }
        else
        {
            Console.WriteLine($"Ошибка: {error}");
        }
    }
    
}

void DeleteMenu(Logic logic)
{
    var list = logic.GetAllStudents();

    if (list.Count == 0)
    {
        Console.WriteLine("Список пуст.");
        return;
    }

    // чтобы табличка красиво выглядела там ниже тоже
    int maxName = list.Max(n => n.FullName.Length);
    int maxGroup = list.Max(n => n.Speciality.Length);
    int maxDirection = list.Max(n => n.Group.Length);


    if (list.Count == 0)
    {
        Console.WriteLine("Список пуст.");
    }

    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine($"{i + 1} | {list[i].FullName.PadRight(maxName)} | {list[i].Speciality.PadRight(maxGroup)} | {list[i].Group.PadRight(maxDirection)}");
        // PadRight Это чтобы табличка красиво выглядела, без волн, потом увидишь если табличку выведешь
    }
    int n;
    while (true)
    {
        Console.Write("Введите номер студента: ");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out n)) // я не придумал способа проще чем ета гавно
        {
            Console.WriteLine("Введите число!!!");
            continue;
        }

        if (n < 1 || n > list.Count())
        {
            Console.WriteLine($"Номер должен быть от 1 ло {list.Count()}");
            continue;
        }

        break;
    }
    logic.DeleteStudent(n - 1);
}

void ShowHistogram(Logic logic) 
{
    var dict = logic.Histogram();
    if (dict.Count == 0)
    {
        Console.WriteLine("Нет данных");
        return;
    }

    int length = dict.Keys.Max(k => k.Length);

    foreach (var gr in dict)
    {
        Console.WriteLine($"{gr.Key.PadRight(length)}: {new string('-', gr.Value)}");
    }
}

void ShowAll(Logic logic)
{

    var students = logic.GetAllStudents();
    if (students.Count == 0)
    {
        Console.WriteLine("Список пуст.");
        return;
    }
    int maxName = students.Max(n => n.FullName.Length);
    int maxGroup = students.Max(n => n.Speciality.Length);
    int maxDirection = students.Max(n => n.Group.Length);
    foreach (var st in students )
    {
        Console.WriteLine($"| {st.FullName.PadRight(maxName)} | {st.Speciality.PadRight(maxGroup)} | {st.Group.PadRight(maxDirection)}|");
    } 
}
    
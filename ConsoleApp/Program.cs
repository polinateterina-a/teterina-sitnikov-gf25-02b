using BusinessLogic;
using System;

var logic = new Logic();
bool up = true;

while (up)
{
    Console.WriteLine("1) Добавить студента" +
                      "2) Удалить студента" +
                      "3) Вывести весь список в таблицу" +
                      "4) Вывести гистограмму: распределение студентов по специальности" +
                      "0) Выйти из программы");
    Console.Write("Введите число от 0 до 4: ");
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
            break;
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

        if (logic.AddStudent(Name, Group, Discipline))
        {
            Console.WriteLine("Студент добавлен");
            break;
        }
        else
        {
            Console.WriteLine("Проверьте корректность ввода. Ввод не может быть пустым или содержать пробелы")
        }
    }
    
}

void DeleteMenu(Logic logic)
{
    var list = logic.GetAllStudents();
    if (list.Count == 0)
    {
        Console.WriteLine("Список пуст.");
    }

    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine($"{i + 1} | {list[i].FullName} | {list[i].Group} | {list[i].Direction}");
    }
    int n;
    while (true)
    {
        Console.Write("Введите номер студента: ");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out n))
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
    var stud = list[n - 1];
    logic.DeleteStudent(stud);
}

    
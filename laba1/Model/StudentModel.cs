using System.Globalization;
namespace Model;

public class StudentModel : IModel<Student>
{
    private readonly List<Student> students = new();
    public event DataChangedHandler? DataChanged;

    public bool Insert(Student student, out string? error)
    {
        if (string.IsNullOrWhiteSpace(student.Name))
        {
            error = "Имя не указано";
            return false;
        }
        if (string.IsNullOrWhiteSpace(student.Speciality))
        {
            error = "Специальность не указана";
            return false;
        }
        if (string.IsNullOrWhiteSpace(student.Group))
        {
            error = "Группа не указана";
            return false;
        }
        if (!IsValidName(student.Name))
        {
            error = "Неверно введено имя";
            return false;
        }
        if (!IsValidGroup(student.Group))
        {
            error = "Неверно введена группа";
            return false;
        }

        string name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(student.Name.Trim().ToLower());
        string speciality = student.Speciality.Trim();
        speciality = char.ToUpper(speciality[0]) + speciality.Substring(1).ToLower();
        string group = student.Group.Trim().ToUpper();

        var existing = students.FirstOrDefault(s =>
            s.Group.Equals(group, StringComparison.OrdinalIgnoreCase));
        if (existing != null &&
            !existing.Speciality.Equals(speciality, StringComparison.OrdinalIgnoreCase))
        {
            error = $"Группа {group} уже относится к специальности {existing.Speciality}";
            return false;
        }

        students.Add(new Student { Name = name, Speciality = speciality, Group = group });
        error = null;
        Notify();
        return true;
    }

    public bool Delete(int index)
    {
        if (index < 0 || index >= students.Count) return false;
        students.RemoveAt(index);
        Notify();
        return true;
    }

    private void Notify()
    {
        DataChanged?.Invoke(students
            .Select(s => (IEnumerable<object>)new object[] { s.Name, s.Speciality, s.Group })
            .ToList());
    }


    private static bool IsValidName(string name) =>
        !name.Contains("  ") &&
        name.All(c => (c >= 'А' && c <= 'я') || c == 'Ё' || c == 'ё' || c == ' ' || c == '-');

    private static bool IsValidGroup(string group) =>
        group.All(c => (c >= 'А' && c <= 'я') || c == 'Ё' || c == 'ё'
                       || char.IsDigit(c) || c == ' ' || c == '-');
}
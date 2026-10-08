using Model;
using System.Globalization;
namespace BusinessLogic
{
    public class Logic
    {
        private readonly List<Student> students = new();
        public bool AddStudent(string name, string speciality, string group, out string error) 
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                error = "Имя не указано";
                return false;
            }
            if (string.IsNullOrWhiteSpace(speciality))
            {
                error = "Группа не указана";
                return false;
            }
            if (string.IsNullOrWhiteSpace(group))
            {
                error = "Направление не указано";
                return false;
            }
            if (!NameValidator(name))
            {
                error = "Неверно введено имя\n";
                return false;
            }
            if (!SpecialityValidator(speciality))
            {
                error = "Неверно введена специальность/группа\n";
                return false;
            }

            name = name.Trim();
            speciality = speciality.Trim().ToUpper();
            group = group.Trim();
            
            var existingGroup = students.FirstOrDefault(s => s.Speciality.Equals(speciality, StringComparison.OrdinalIgnoreCase));

            if (existingGroup != null && group.ToUpper() != existingGroup.Group.ToUpper())
            {
                error = $"Группа {speciality} уже относится к направлению {existingGroup.Group}";
                return false;
            }
            students.Add(new Student
            {
                Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower()), 
                Speciality = speciality.ToUpper(), 
                Group = char.ToUpper(group[0]) + group.Substring(1).ToLower() 
            });
            error = null;
            return true;
        }

        public bool DeleteStudent(int index)
        {
            if (index < 0 || index >= students.Count)
            {
                return false;
            }

            students.RemoveAt(index);
            return true;
        }

        public List<(string Name, string Speciality, string Group)> GetAllStudents()
        {
            var copy = students.Select(s => (s.Name, s.Speciality, s.Group)).ToList();
            return copy;
        }
        public Dictionary<string, int> Histogram()
        {
            return students.GroupBy(g => g.Group).ToDictionary(g => g.Key, g => g.Count());
        }

        public bool NameValidator(string name)
        {
            for (int i = 0; i < name.Length - 1; i++)
            {
                if (name[i] == ' ' && name[i + 1] == ' ')
                {
                    return false;
                }
            }
            foreach (char c in name)
            {
                bool upper = (c >= 'А' && c <= 'Я') || c == 'Ё';
                bool lower = (c >= 'а' && c <= 'я') || c == 'ё';
                bool space = c == ' ';
                bool dash = c == '-';


                if (!upper && !lower && !space && !dash)
                {
                    return false;
                }
            }
            return true;
        }
        public bool SpecialityValidator(string speciality)
        {

            foreach (char c in speciality)
            {
                bool upper = (c >= 'А' && c <= 'Я') || c == 'Ё';
                bool lower = (c >= 'а' && c <= 'я') || c == 'ё';
                bool number = (c >= '0' && c <= '9');
                bool space = c == ' ';
                bool dash = c == '-';


                if (!upper && !lower && !space && !dash && !number)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

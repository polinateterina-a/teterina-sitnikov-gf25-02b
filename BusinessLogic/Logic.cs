using Model;
using System.Globalization;
namespace BusinessLogic
{
    public class Logic
    {
        private readonly List<Student> students = new();
        public bool AddStudent(string fullName, string speciality, string group, out string error) //out string error это, если какое-то условие не соблюдено, выведет в консоли ошибку
        {
            if (string.IsNullOrWhiteSpace(fullName))
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
            if (!NameValidator(fullName))
            {
                error = "Имя не может содержать цифры и специальные символы\n";
                return false;
            }

            fullName = fullName.Trim();
            speciality = speciality.Trim().ToUpper();
            group = group.Trim();

            // проверка на "Два студента в одной группе не могут находиться на разных направлениях"
            var existingGroup = students.FirstOrDefault(s => s.Speciality.Equals(speciality, StringComparison.OrdinalIgnoreCase));//вот это сложная фигня, я ее с нейронки слизал не хотел просто иф елзе делать везде
            
            if (existingGroup != null && group.ToUpper() != existingGroup.Group.ToUpper())
            {
                error = $"Группа {speciality} уже относится к направлению {existingGroup.Group}";
                return false;
            }
            students.Add(new Student
            {
                FullName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fullName), // это чтобы в ФИО все первые буквы были заглавные
                Speciality = speciality.ToUpper(), // все буквы в группе заглавные
                Group = char.ToUpper(group[0]) + group.Substring(1).ToLower() // в названии направления только первая буква заглавная, а дальше как пользователь введет
            });
            error = null;
            return true;
        }

        // это тож раскомментировать, если надо будет проверять работоспособность логики
        //public void AddStudent(string fullName, string group, string direction)
        //{
        //    students.Add(new Student
        //    {
        //        FullName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fullName),
        //        Group = group.ToUpper(),
        //        Direction = char.ToUpper(direction[0]) + direction.Substring(1).ToLower()
        //    });
        //}
        public bool DeleteStudent(int index)
        {
            if (index < 0 || index >= students.Count)
            {
                return false;
            }

            students.RemoveAt(index);
            return true;
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }
        public Dictionary<string, int> Histogram()
        {
            return students.GroupBy(g => g.Group).ToDictionary(g => g.Key, g => g.Count());
        }

        // дляя проверки имени на корректность (без цифр и спец символов)
        public bool NameValidator(string name)
        {
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
    }
}

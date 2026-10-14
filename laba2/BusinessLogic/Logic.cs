using Model;
using System.Globalization;
using DataAccess;

namespace BusinessLogic
{
    /// <summary>
    /// Бизнес-логика работы со студентами: проверка ввода, форматирование данных
    /// и обращение к хранилищу через репозиторий.
    /// </summary>
    public class Logic
    {
        private readonly IRepository<Student> repository;

        /// <summary>
        /// Создаёт логику, работающую с указанным репозиторием.
        /// </summary>
        /// <param name="repository">Репозиторий студентов (Entity Framework, Dapper и т.д.).</param>
        public Logic(IRepository<Student> _repository)
        {
            repository = _repository;
        }

        /// <summary>
        /// Проверяет введённые данные и добавляет студента в хранилище.
        /// </summary>
        /// <param name="name">ФИО студента.</param>
        /// <param name="speciality">Группа студента.</param>
        /// <param name="group">Направление подготовки.</param>
        /// <param name="error">Текст ошибки, если студента добавить не удалось; иначе null.</param>
        /// <returns>true, если студент добавлен; false, если данные не прошли проверку.</returns>
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

            var existingGroup = repository.ReadALL()
                .FirstOrDefault(s => s.Speciality.Equals(speciality, StringComparison.OrdinalIgnoreCase));

            if (existingGroup != null && group.ToUpper() != existingGroup.Group.ToUpper())
            {
                error = $"Группа {speciality} уже относится к направлению {existingGroup.Group}";
                return false;
            }

            repository.Create(new Student
            {
                Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower()),
                Speciality = speciality.ToUpper(),
                Group = char.ToUpper(group[0]) + group.Substring(1).ToLower()
            });
            error = null;
            return true;
        }

        /// <summary>
        /// Удаляет студента по его порядковому номеру в списке.
        /// </summary>
        /// <param name="index">Номер студента в списке, начиная с 0.</param>
        /// <returns>true, если студент удалён; false, если номер выходит за границы списка.</returns>
        public bool DeleteStudent(int index)
        {
            var students = repository.ReadALL();
            if (index < 0 || index >= students.Count)
            {
                return false;
            }

            repository.Delete(students[index]);
            return true;
        }

        /// <summary>
        /// Возвращает всех студентов.
        /// </summary>
        /// <returns>Список кортежей: ФИО, группа, направление.</returns>
        public List<(string Name, string Speciality, string Group)> GetAllStudents()
        {
            return repository.ReadALL()
                .Select(s => (s.Name, s.Speciality, s.Group))
                .ToList();
        }

        /// <summary>
        /// Подсчитывает количество студентов по направлениям.
        /// </summary>
        /// <returns>Словарь: направление и число студентов в нём.</returns>
        public Dictionary<string, int> Histogram()
        {
            return repository.ReadALL()
                .GroupBy(g => g.Group)
                .ToDictionary(g => g.Key, g => g.Count());
        }

        /// <summary>
        /// Проверяет, что ФИО содержит только русские буквы, пробелы и дефисы, без двойных пробелов.
        /// </summary>
        /// <param name="name">Проверяемая строка.</param>
        /// <returns>true, если строка допустима.</returns>
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

        /// <summary>
        /// Проверяет, что строка содержит только русские буквы, цифры, пробелы и дефисы.
        /// </summary>
        /// <param name="speciality">Проверяемая строка.</param>
        /// <returns>true, если строка допустима.</returns>
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
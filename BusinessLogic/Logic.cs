using Model;
using System.Net;
namespace BusinessLogic
{
    public class Logic
    {
        private readonly List<Student> students = new();
        public bool AddStudent(string fullName, string group, string direction)
        {
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(group) || string.IsNullOrWhiteSpace(direction))
            {
                return false;
            }

            students.Add(new Student
            {
                FullName = fullName,
                Group = group,
                Direction = direction
            });
            return true;
        }
        public bool DeleteStudent(Student student)
        {
            return students.Remove(student);
        }
        public List<Student> GetAllStudents()
        {
            return students;
        }
        public Dictionary<string, int> Histogram()
        {
            return students.GroupBy(g => g.Group).ToDictionary(g => g.Key, g => g.Count());
        }


    }
}

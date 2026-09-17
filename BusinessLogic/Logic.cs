using Model;
namespace BusinessLogic
{
    public class Logic
    {
        private readonly List<Student> students = new();
        public void AddStudent(string fullName, string group, string direction)
        {
            students.Add(new Student
            {
                FullName = fullName,
                Group = group,
                Direction = direction
            });
        }
    }
}

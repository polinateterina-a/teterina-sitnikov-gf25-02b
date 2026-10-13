using DataAccess;
using Model;
using BusinessLogic;

namespace WinFormView
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // По умолчанию запускаем Entity Framework.
            IRepository<Student> repository =
                new EntityRepository<Student>();

            Logic logic = new Logic(repository);

            Application.Run(new MainForm(logic));
        }
    }
}

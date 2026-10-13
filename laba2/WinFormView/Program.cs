using BusinessLogic;
using Model;
using DataAccess;

namespace WinFormView
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Logic logic = new Logic(new EntityRepository<Student>());
            Application.Run(new MainForm(logic));
        }
    }
}
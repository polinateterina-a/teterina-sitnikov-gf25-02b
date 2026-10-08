using BusinessLogic;

namespace WinFormView
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Logic logic = new Logic();
            Application.Run(new MainForm(logic));
        }
    }
}
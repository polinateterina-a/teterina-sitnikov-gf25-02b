using BusinessLogic;
using Ninject;

namespace WinFormView
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            int choice = 1;
            IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule(choice));
            Logic logic = ninjectKernel.Get<Logic>();
            Application.Run(new MainForm(logic));
        }
    }
}

using Model;
using WinFormView;
namespace Presenter;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        System.Windows.Forms.Application.EnableVisualStyles();
        System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

        var model = new StudentModel();
        var view = new MainForm();
        var presenter = new StudentPresenter(model, view);

        System.Windows.Forms.Application.Run(view);
    }
}

using Model;
using WinFormView;
namespace Presenter;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        var model = new StudentModel();
        var view = new MainForm();
        var presenter = new StudentPresenter(model, view);
        
        Application.Run(view);
    }
}

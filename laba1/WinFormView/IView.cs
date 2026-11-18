namespace WinFormView;

public interface IView
{
    event Action<IEnumerable<object>>? AddDataEvent;
    event Action<int>? DeleteDataEvent;

    void RedrawForm(IEnumerable<IEnumerable<object>> data);
    void ClearFields();
    void ShowMessage(string text, string caption, bool isError);
}
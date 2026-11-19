namespace WinFormView;
/// <summary>
/// Интерфейс представления (View) для взаимодействия с презентером.
/// </summary>
public interface IView
{
    /// <summary>
    /// Событие запроса на добавление новой записи.
    /// </summary>
    event Action<IEnumerable<object>>? AddDataEvent;
    /// <summary>
    /// Событие запроса на удаление записи по индексу.
    /// </summary>
    event Action<int>? DeleteDataEvent;
    /// <summary>
    /// Перерисовывает отображаемый список данных на форме.
    /// </summary>
    /// <param name="data">Коллекция строк с упакованными значениями столбцов.</param>
    void RedrawForm(IEnumerable<IEnumerable<object>> data);
    /// <summary>
    /// Очищает поля ввода на форме.
    /// </summary>
    void ClearFields();
    /// <summary>
    /// Отображает пользователю диалоговое окно с сообщением.
    /// </summary>
    /// <param name="text">Текст сообщения.</param>
    /// <param name="caption">Заголовок окна.</param>
    /// <param name="isError">Флаг ошибки: <see langword="true"/> для иконки ошибки, <see langword="false"/> для информации.</param>
    void ShowMessage(string text, string caption, bool isError);
}
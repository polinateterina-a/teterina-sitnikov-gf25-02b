namespace Model;

/// <summary>
/// Делегат обработчика события изменения данных в модели.
/// </summary>
/// <param name="data">Коллекция упакованных данных всех элементов модели.</param>
public delegate void DataChangedHandler(IEnumerable<IEnumerable<object>> data);

/// <summary>
/// Обобщённый интерфейс модели данных.
/// </summary>
/// <typeparam name="T">Тип доменной сущности.</typeparam>
public interface IModel<T>
{
    /// <summary>
    /// Событие, возникающее при изменении состава данных в модели.
    /// </summary>
    event DataChangedHandler? DataChanged;
    /// <summary>
    /// Добавляет новый элемент в модель после проверки корректности данных.
    /// </summary>
    /// <param name="item">Добавляемый элемент.</param>
    /// <param name="error">Текст ошибки, если добавление не удалось; иначе <see langword="null"/>.</param>
    /// <returns><see langword="true"/>, если элемент успешно добавлен; иначе <see langword="false"/>.</returns>
    bool Insert(T item, out string? error);
    /// <summary>
    /// Удаляет элемент из модели по указанному индексу.
    /// </summary>
    /// <param name="index">Индекс удаляемого элемента.</param>
    /// <returns><see langword="true"/>, если элемент успешно удалён; иначе <see langword="false"/>.</returns>
    bool Delete(int index);
}
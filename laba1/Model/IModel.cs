namespace Model;

public delegate void DataChangedHandler(IEnumerable<IEnumerable<object>> data);

public interface IModel<T>
{
    event DataChangedHandler? DataChanged;
    bool Insert(T item, out string? error);
    bool Delete(int index);
}
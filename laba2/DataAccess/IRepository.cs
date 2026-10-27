using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// Репозиторий: набор операций доступа к данным (CRUD) для сущностей типа <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">Тип доменного объекта.</typeparam>
    public interface IRepository<T> where T : class, IDomainObject, new()
    {
        /// <summary>Добавляет новую запись в источник данных.</summary>
        /// <param name="obj">Добавляемый объект.</param>
        void Create(T item);

        /// <summary>Возвращает все записи из источника данных.</summary>
        /// <returns>Список всех объектов, отсортированный по идентификатору.</returns>
        List<T> ReadALL();

        /// <summary>Удаляет запись из источника данных.</summary>
        /// <param name="obj">Удаляемый объект.</param>
        void Delete(T item);
    }
}

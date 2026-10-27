using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Описывает сущность, у которой есть уникальный идентификатор в источнике данных.
    /// </summary>
    public interface IDomainObject
    {
        /// <summary>Уникальный идентификатор записи.</summary>
        int Id { get; set; }
    }
}

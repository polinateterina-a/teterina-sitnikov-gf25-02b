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

    /// <summary>
    /// Студент: доменный объект, который хранится в базе данных.
    /// Каждое свойство можно задать только один раз, повторная запись игнорируется.
    /// </summary>
    public class Student : IDomainObject
    {
        /// <summary>Уникальный идентификатор студента (первичный ключ в БД).</summary>
        public int Id { get; set; }

        private string _name;

        /// <summary>Фамилия, имя (и отчество) студента.</summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
        }

        private string _speciality;

        /// <summary>Группа студента (например, ПИ-101).</summary>
        public string Speciality
        {
            get { return _speciality; }
            set
            {
                if (string.IsNullOrEmpty(_speciality))
                {
                    _speciality = value;
                }
            }
        }

        private string _group;

        /// <summary>Направление подготовки студента.</summary>
        public string Group
        {
            get { return _group; }
            set
            {
                if (string.IsNullOrEmpty(_group))
                {
                    _group = value;
                }
            }
        }
    }
}

namespace Model
{
    /// <summary>
    /// Доменная сущность, представляющая студента.
    /// </summary>
    public class Student
    {
        private string _name;
        /// <summary>
        /// ФИО студента.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
        }
        private string _speciality;
        /// <summary>
        /// Специальность (направление подготовки) студента.
        /// </summary>
        public string Speciality
        {
            get
            {
                return _speciality;
            }
            set
            {
                if (string.IsNullOrEmpty(_speciality))
                {
                    _speciality = value;
                }
            }
        }

        private string _group;
        /// <summary>
        /// Учебная группа студента.
        /// </summary>
        public string Group
        {
            get
            {
                return _group;
            }
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

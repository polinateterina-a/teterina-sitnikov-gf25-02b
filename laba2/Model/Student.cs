namespace Model
{
    public class Student
    {
        private string _name;
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

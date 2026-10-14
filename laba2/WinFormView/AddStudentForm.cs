using BusinessLogic;

namespace WinFormView
{
    /// <summary>
    /// Окно добавления студента
    /// </summary>
    public partial class AddStudentForm : Form
    {
        private readonly Logic logic;
        private readonly MainForm main;
        /// <summary>
        /// Создаёт окно и строит добавляет студентов по данным из бизнес-логики. Обновляет главное окно.
        /// </summary>
        /// <param name="logic"></param>
        /// <param name="main"></param>
        public AddStudentForm(Logic logic, MainForm main)
        {
            InitializeComponent();
            this.logic = logic;
            this.main = main;
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text;
            string speciality = textBoxSpeciality.Text;
            string group = textBoxGroup.Text;

            if (logic.AddStudent(
                fullName,
                speciality,
                group,
                out string error))
            {

                textBoxFullName.Clear();
                textBoxSpeciality.Clear();
                textBoxGroup.Clear();
                
            }
            else
            {
                MessageBox.Show(
                    error,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            main.UpdateData();
        }
        private void ButtonToStart_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

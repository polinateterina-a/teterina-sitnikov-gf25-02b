
using BusinessLogic;
using DataAccess;
using Model;

namespace WinFormView
{
    /// <summary>
    /// Главное окно приложения: таблица студентов, добавление, удаление, гистограмма.
    /// </summary>
    public partial class MainForm : Form
    {
        public Logic logic;

        /// <summary>
        /// Создаёт главное окно.
        /// </summary>
        /// <param name="logic">Бизнес-логика, с которой работает окно.</param>
        public MainForm(Logic logic)
        {
            InitializeComponent();
            this.logic = logic;
            UpdateData();
        }

        private void ShowingStudents()
        {
            dataGridViewStudents.Rows.Clear();

            var students = logic.GetAllStudents();

            foreach (var item in students)
            {
                dataGridViewStudents.Rows.Add(
                    item.Name,
                    item.Speciality,
                    item.Group);
            }
        }

        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm(logic, this);
            form.ShowDialog();
            UpdateData();
        }

        private void ButtonDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Выберите студента.",
                    "Удаление",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int index = dataGridViewStudents.SelectedRows[0].Index;

            bool deleted = logic.DeleteStudent(index);

            if (deleted)
            {
                UpdateData();
                MessageBox.Show(
                    "Студент удалён.",
                    "Удаление",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                
            }
            else
            {
                MessageBox.Show(
                    "Не удалось удалить студента.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обновляет данные в таблице студентов.
        /// </summary>
        public void UpdateData()
        {
            ShowingStudents();
        }

        
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            IRepository<Student> repository;

            if (CheckBox1.Checked)
            {
                repository = new DapperRepository<Student>();
            }
            else
            {
                repository = new EntityRepository<Student>();
            }

            logic = new Logic(repository);

            UpdateData();
        }

        private void ButtonHistogram_Click(object sender, EventArgs e)
        {
            using var form = new HistogramForm(logic);
            form.ShowDialog();
        }
    }
}





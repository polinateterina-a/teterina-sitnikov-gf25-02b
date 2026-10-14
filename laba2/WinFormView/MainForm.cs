
using BusinessLogic;
using DataAccess;
using Model;

namespace WinFormView
{
    public partial class MainForm : Form
    {
        public Logic logic;

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

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm(logic, this);
            form.ShowDialog();
            UpdateData();
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
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

        public void UpdateData()
        {
            ShowingStudents();
        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            IRepository<Student> repository;

            if (checkBox1.Checked)
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

        private void buttonHistogram_Click(object sender, EventArgs e)
        {
            using var form = new HistogramForm(logic);
            form.ShowDialog();
        }
    }
}





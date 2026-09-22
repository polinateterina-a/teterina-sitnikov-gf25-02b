using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormView
{
    public partial class DeleteStudentForm : Form
    {
        private readonly Logic logic;
        public DeleteStudentForm(Logic logic)
        {
            InitializeComponent();
            this.logic = logic;
            ShowingStudents();
        }
        private void ShowingStudents()
        {
            dataGridViewStudents.Rows.Clear();

            var students = logic.GetAllStudents();

            for (int i = 0; i < students.Count; i++)
            {
                dataGridViewStudents.Rows.Add(
                    i + 1,
                    students[i].FullName,
                    students[i].Group,
                    students[i].Direction);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
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
                MessageBox.Show(
                    "Студент удалён.",
                    "Удаление",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ShowingStudents();
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
    }
}

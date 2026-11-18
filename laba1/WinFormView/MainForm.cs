using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormView
{
    // Обязательно реализуем интерфейс IView для связи с Presenter
    public partial class MainForm : Form, IView
    {
        public event Action<IEnumerable<object>>? AddDataEvent;
        public event Action<int>? DeleteDataEvent;

        public MainForm()
        {
            InitializeComponent();
        }


        public void RedrawForm(IEnumerable<IEnumerable<object>> data)
        {
            dataGridViewStudents.Rows.Clear();
            foreach (var row in data)
            {
                dataGridViewStudents.Rows.Add(row.ToArray());
            }
        }

        public void ClearFields()
        {
            textBoxFullName.Clear();
            textBoxSpeciality.Clear();
            textBoxGroup.Clear();
        }

        public void ShowMessage(string text, string caption, bool isError)
        {
            MessageBox.Show(
                text,
                caption,
                MessageBoxButtons.OK,
                isError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }

        // --- Обработчики событий кнопок ---
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            // Передаем данные в Presenter. 
            // Вся логика проверок (if/else) на пустоту и валидацию теперь на стороне Model/Presenter.
            AddDataEvent?.Invoke(new object[]
            {
                textBoxFullName.Text,
                textBoxSpeciality.Text,
                textBoxGroup.Text
            });
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            // Оставил вашу логику с if и MessageBox прямо в форме
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

            // Передаем команду на удаление в Presenter
            DeleteDataEvent?.Invoke(index);
        }
    }
}
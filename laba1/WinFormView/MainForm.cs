using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormView
{
    /// <summary>
    /// Главная форма приложения, реализующая пассивное представление <see cref="IView"/>.
    /// </summary>
    public partial class MainForm : Form, IView
    {
        /// <summary>
        /// Событие, генерируемое при нажатии кнопки добавления студента.
        /// </summary>
        public event Action<IEnumerable<object>>? AddDataEvent;
        /// <summary>
        /// Событие, генерируемое при нажатии кнопки удаления студента.
        /// </summary>
        public event Action<int>? DeleteDataEvent;
        /// <summary>
        /// Инициализирует новый экземпляр главной формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Очищает таблицу и заполняет её актуальными данными.
        /// </summary>
        /// <param name="data">Коллекция строк с упакованными свойствами студентов.</param>
        public void RedrawForm(IEnumerable<IEnumerable<object>> data)
        {
            dataGridViewStudents.Rows.Clear();
            foreach (var row in data)
            {
                dataGridViewStudents.Rows.Add(row.ToArray());
            }
        }
        /// <summary>
        /// Очищает текстовые поля ввода ФИО, специальности и группы.
        /// </summary>
        public void ClearFields()
        {
            textBoxFullName.Clear();
            textBoxSpeciality.Clear();
            textBoxGroup.Clear();
        }
        /// <summary>
        /// Выводит всплывающее окно <see cref="MessageBox"/> с заданным текстом и иконкой.
        /// </summary>
        /// <param name="text">Текст сообщения.</param>
        /// <param name="caption">Заголовок окна.</param>
        /// <param name="isError">Если <see langword="true"/>, отображается иконка ошибки; иначе — информационная иконка.</param>
        public void ShowMessage(string text, string caption, bool isError)
        {
            MessageBox.Show(
                text,
                caption,
                MessageBoxButtons.OK,
                isError ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }


        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            AddDataEvent?.Invoke(new object[]
            {
                textBoxFullName.Text,
                textBoxSpeciality.Text,
                textBoxGroup.Text
            });
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

            DeleteDataEvent?.Invoke(index);
        }
    }
}
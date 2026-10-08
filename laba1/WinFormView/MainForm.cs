using BusinessLogic;


namespace WinFormView
{
    public partial class MainForm : Form
    {
        public readonly Logic logic;
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
            Show();
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
                MessageBox.Show(
                    "Студент удалён.",
                    "Удаление",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                UpdateData();
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
            HistogramPanel.Refresh();
        }

        private void HistogramPanel_Paint_1(object sender, PaintEventArgs e)
        {
            var histogram = logic.Histogram();

            if (histogram.Count == 0)
            {
                e.Graphics.DrawString(
                    "Нет данных",
                    Font,
                    Brushes.Black,
                    20,
                    20);

                return;
            }

            int x = 20;
            int y = 30;

            float maxTextWidth = 0;

            foreach (var item in histogram)
            {
                float width = e.Graphics.MeasureString(item.Key, Font).Width;

                if (width > maxTextWidth)
                    maxTextWidth = width;
            }

            float barX = x + maxTextWidth + 20;

            foreach (var item in histogram)
            {
                string group = item.Key;
                int count = item.Value;

                e.Graphics.DrawString(
                    group,
                    Font,
                    Brushes.Black,
                    x,
                    y);

                int barWidth = count * 30;

                e.Graphics.FillRectangle(
                    Brushes.SteelBlue,
                    barX,
                    y,
                    barWidth,
                    20);

                e.Graphics.DrawString(
                    count.ToString(),
                    Font,
                    Brushes.Black,
                    barX + barWidth,
                    y);

                y += 40;
            }
        }
    }

}




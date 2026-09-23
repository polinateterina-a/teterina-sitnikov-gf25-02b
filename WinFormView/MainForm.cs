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
        }
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            Hide();
            AddStudentForm form = new AddStudentForm(logic);
            form.ShowDialog();
            Show();
        }
        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            Hide();
            DeleteStudentForm form = new DeleteStudentForm(logic);
            form.ShowDialog();
            Show();
        }

        private void buttonShowStudents_Click(object sender, EventArgs e)
        {
            Hide();
            StudentListForm form = new StudentListForm(logic);
            form.ShowDialog();
            Show();
        }

        private void buttonHistogram_Click(object sender, EventArgs e)
        {
            Hide();
            HistogramForm form = new HistogramForm(logic);
            form.ShowDialog();
            Show();
        }
    }
}




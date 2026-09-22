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
            AddStudentForm form = new AddStudentForm(logic);
            form.ShowDialog();
        }
        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudentForm form = new DeleteStudentForm(logic);
            form.ShowDialog();
        }

        private void buttonShowStudents_Click(object sender, EventArgs e)
        {
            StudentListForm form = new StudentListForm(logic);
            form.ShowDialog();
        }

        private void buttonHistogram_Click(object sender, EventArgs e)
        {
            HistogramForm form = new HistogramForm(logic);
            form.ShowDialog();
        }
    }
}




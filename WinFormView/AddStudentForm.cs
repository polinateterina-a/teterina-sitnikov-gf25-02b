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
using BusinessLogic;

namespace WinFormView
{
    public partial class AddStudentForm : Form
    {
        private readonly Logic logic;
        public AddStudentForm(Logic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text;
            string group = textBoxGroup.Text;
            string direction = textBoxDirection.Text;

            if (logic.AddStudent(
                fullName,
                group,
                direction,
                out string error))
            {
                MessageBox.Show(
                    "Студент успешно добавлен",
                    " ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                textBoxFullName.Clear();
                textBoxGroup.Clear();
                textBoxDirection.Clear();
            }
            else
            {
                MessageBox.Show(
                    error,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

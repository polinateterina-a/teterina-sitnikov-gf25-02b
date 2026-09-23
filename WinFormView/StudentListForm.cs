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
    public partial class StudentListForm : Form
    {
        private readonly Logic logic;
        public StudentListForm(Logic logic)
        {
            InitializeComponent();
            this.logic = logic;
            ShowingStudents();
        }
        private void ShowingStudents()
        {
            dataGridViewStudents.Rows.Clear();

            var students = logic.GetAllStudents();

            foreach (var student in students)
            {
                dataGridViewStudents.Rows.Add(
                    student.Name,
                    student.Speciality,
                    student.Group);
            }
        }
    }
}

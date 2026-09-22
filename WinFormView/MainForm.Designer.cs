namespace WinFormView
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonAddStudent = new Button();
            buttonDeleteStudent = new Button();
            buttonShowStudents = new Button();
            buttonHistogram = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 56);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 0;
            label1.Text = "Управление студентами";
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new Point(64, 144);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(181, 83);
            buttonAddStudent.TabIndex = 1;
            buttonAddStudent.Text = "Добавить студента";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonDeleteStudent
            // 
            buttonDeleteStudent.Location = new Point(64, 318);
            buttonDeleteStudent.Name = "buttonDeleteStudent";
            buttonDeleteStudent.Size = new Size(181, 83);
            buttonDeleteStudent.TabIndex = 2;
            buttonDeleteStudent.Text = "Удалить студента";
            buttonDeleteStudent.UseVisualStyleBackColor = true;
            buttonDeleteStudent.Click += buttonDeleteStudent_Click;
            // 
            // buttonShowStudents
            // 
            buttonShowStudents.Location = new Point(366, 144);
            buttonShowStudents.Name = "buttonShowStudents";
            buttonShowStudents.Size = new Size(181, 83);
            buttonShowStudents.TabIndex = 3;
            buttonShowStudents.Text = "Список студентов";
            buttonShowStudents.UseVisualStyleBackColor = true;
            buttonShowStudents.Click += buttonShowStudents_Click;
            // 
            // buttonHistogram
            // 
            buttonHistogram.Location = new Point(366, 318);
            buttonHistogram.Name = "buttonHistogram";
            buttonHistogram.Size = new Size(181, 83);
            buttonHistogram.TabIndex = 4;
            buttonHistogram.Text = "Гичтограмма";
            buttonHistogram.UseVisualStyleBackColor = true;
            buttonHistogram.Click += buttonHistogram_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 536);
            Controls.Add(buttonHistogram);
            Controls.Add(buttonShowStudents);
            Controls.Add(buttonDeleteStudent);
            Controls.Add(buttonAddStudent);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DecanatPRO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAddStudent;
        private Button buttonDeleteStudent;
        private Button buttonShowStudents;
        private Button buttonHistogram;
    }
}

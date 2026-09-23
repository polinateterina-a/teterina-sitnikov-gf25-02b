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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(622, 125);
            label1.TabIndex = 0;
            label1.Text = "Управление студентами";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.BackColor = SystemColors.AppWorkspace;
            buttonAddStudent.Dock = DockStyle.Fill;
            buttonAddStudent.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddStudent.Location = new Point(3, 3);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(308, 190);
            buttonAddStudent.TabIndex = 1;
            buttonAddStudent.Text = "Добавить студента";
            buttonAddStudent.UseVisualStyleBackColor = false;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonDeleteStudent
            // 
            buttonDeleteStudent.BackColor = SystemColors.AppWorkspace;
            buttonDeleteStudent.Dock = DockStyle.Fill;
            buttonDeleteStudent.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteStudent.Location = new Point(3, 199);
            buttonDeleteStudent.Name = "buttonDeleteStudent";
            buttonDeleteStudent.Size = new Size(308, 190);
            buttonDeleteStudent.TabIndex = 2;
            buttonDeleteStudent.Text = "Удалить студента";
            buttonDeleteStudent.UseVisualStyleBackColor = false;
            buttonDeleteStudent.Click += buttonDeleteStudent_Click;
            // 
            // buttonShowStudents
            // 
            buttonShowStudents.BackColor = SystemColors.AppWorkspace;
            buttonShowStudents.Dock = DockStyle.Fill;
            buttonShowStudents.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShowStudents.Location = new Point(317, 3);
            buttonShowStudents.Name = "buttonShowStudents";
            buttonShowStudents.Size = new Size(308, 190);
            buttonShowStudents.TabIndex = 3;
            buttonShowStudents.Text = "Список студентов";
            buttonShowStudents.UseVisualStyleBackColor = false;
            buttonShowStudents.Click += buttonShowStudents_Click;
            // 
            // buttonHistogram
            // 
            buttonHistogram.BackColor = SystemColors.AppWorkspace;
            buttonHistogram.Dock = DockStyle.Fill;
            buttonHistogram.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHistogram.Location = new Point(317, 199);
            buttonHistogram.Name = "buttonHistogram";
            buttonHistogram.Size = new Size(308, 190);
            buttonHistogram.TabIndex = 4;
            buttonHistogram.Text = "Гистограмма";
            buttonHistogram.UseVisualStyleBackColor = false;
            buttonHistogram.Click += buttonHistogram_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonAddStudent, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonDeleteStudent, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonHistogram, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonShowStudents, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 144);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(628, 392);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(628, 125);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 536);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DecanatPRO";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonAddStudent;
        private Button buttonDeleteStudent;
        private Button buttonShowStudents;
        private Button buttonHistogram;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}

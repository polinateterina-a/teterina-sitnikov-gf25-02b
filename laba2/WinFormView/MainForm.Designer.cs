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
            buttonDeleteStudent = new Button();
            buttonAddStudent = new Button();
            dataGridViewStudents = new DataGridView();
            FullNameColumn = new DataGridViewTextBoxColumn();
            GroupColumn = new DataGridViewTextBoxColumn();
            DirectionColumn = new DataGridViewTextBoxColumn();
            HistogramPanel = new Panel();
            label1 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // buttonDeleteStudent
            // 
            buttonDeleteStudent.BackColor = SystemColors.AppWorkspace;
            buttonDeleteStudent.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteStudent.Location = new Point(384, 384);
            buttonDeleteStudent.Name = "buttonDeleteStudent";
            buttonDeleteStudent.Size = new Size(213, 99);
            buttonDeleteStudent.TabIndex = 2;
            buttonDeleteStudent.Text = "Удалить студента";
            buttonDeleteStudent.UseVisualStyleBackColor = false;
            buttonDeleteStudent.Click += buttonDeleteStudent_Click;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.BackColor = SystemColors.AppWorkspace;
            buttonAddStudent.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddStudent.Location = new Point(48, 384);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(213, 99);
            buttonAddStudent.TabIndex = 1;
            buttonAddStudent.Text = "Добавить студента";
            buttonAddStudent.UseVisualStyleBackColor = false;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Columns.AddRange(new DataGridViewColumn[] { FullNameColumn, GroupColumn, DirectionColumn });
            dataGridViewStudents.Location = new Point(32, 39);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.ReadOnly = true;
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(565, 188);
            dataGridViewStudents.TabIndex = 3;
            // 
            // FullNameColumn
            // 
            FullNameColumn.HeaderText = "ФИО";
            FullNameColumn.MinimumWidth = 6;
            FullNameColumn.Name = "FullNameColumn";
            FullNameColumn.ReadOnly = true;
            // 
            // GroupColumn
            // 
            GroupColumn.HeaderText = "Группа";
            GroupColumn.MinimumWidth = 6;
            GroupColumn.Name = "GroupColumn";
            GroupColumn.ReadOnly = true;
            // 
            // DirectionColumn
            // 
            DirectionColumn.HeaderText = "Специальность";
            DirectionColumn.MinimumWidth = 6;
            DirectionColumn.Name = "DirectionColumn";
            DirectionColumn.ReadOnly = true;
            // 
            // HistogramPanel
            // 
            HistogramPanel.Location = new Point(32, 233);
            HistogramPanel.Name = "HistogramPanel";
            HistogramPanel.Size = new Size(565, 145);
            HistogramPanel.TabIndex = 4;
            HistogramPanel.Paint += HistogramPanel_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(703, 53);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(671, 98);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Dapper";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 536);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(HistogramPanel);
            Controls.Add(dataGridViewStudents);
            Controls.Add(buttonDeleteStudent);
            Controls.Add(buttonAddStudent);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DecanatPRO";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonDeleteStudent;
        private Button buttonAddStudent;
        private DataGridView dataGridViewStudents;
        private Panel HistogramPanel;
        private DataGridViewTextBoxColumn FullNameColumn;
        private DataGridViewTextBoxColumn GroupColumn;
        private DataGridViewTextBoxColumn DirectionColumn;
        private Label label1;
        private CheckBox checkBox1;
    }
}

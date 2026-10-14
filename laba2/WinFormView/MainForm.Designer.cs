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
            ButtonDeleteStudent = new Button();
            ButtonAddStudent = new Button();
            dataGridViewStudents = new DataGridView();
            FullNameColumn = new DataGridViewTextBoxColumn();
            GroupColumn = new DataGridViewTextBoxColumn();
            DirectionColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            CheckBox1 = new CheckBox();
            ButtonHistogram = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonDeleteStudent
            // 
            ButtonDeleteStudent.BackColor = SystemColors.AppWorkspace;
            ButtonDeleteStudent.Dock = DockStyle.Fill;
            ButtonDeleteStudent.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonDeleteStudent.Location = new Point(439, 361);
            ButtonDeleteStudent.Name = "ButtonDeleteStudent";
            ButtonDeleteStudent.Size = new Size(150, 88);
            ButtonDeleteStudent.TabIndex = 2;
            ButtonDeleteStudent.Text = "Удалить студента";
            ButtonDeleteStudent.UseVisualStyleBackColor = false;
            ButtonDeleteStudent.Click += ButtonDeleteStudent_Click;
            // 
            // ButtonAddStudent
            // 
            ButtonAddStudent.BackColor = SystemColors.AppWorkspace;
            ButtonAddStudent.Dock = DockStyle.Fill;
            ButtonAddStudent.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonAddStudent.Location = new Point(34, 361);
            ButtonAddStudent.Name = "ButtonAddStudent";
            ButtonAddStudent.Size = new Size(150, 88);
            ButtonAddStudent.TabIndex = 1;
            ButtonAddStudent.Text = "Добавить студента";
            ButtonAddStudent.UseVisualStyleBackColor = false;
            ButtonAddStudent.Click += ButtonAddStudent_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Columns.AddRange(new DataGridViewColumn[] { FullNameColumn, GroupColumn, DirectionColumn });
            tableLayoutPanel1.SetColumnSpan(dataGridViewStudents, 5);
            dataGridViewStudents.Location = new Point(34, 29);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.ReadOnly = true;
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(555, 317);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(703, 53);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // CheckBox1
            // 
            CheckBox1.Anchor = AnchorStyles.None;
            CheckBox1.AutoSize = true;
            CheckBox1.Location = new Point(271, 471);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(81, 24);
            CheckBox1.TabIndex = 7;
            CheckBox1.Text = "Dapper";
            CheckBox1.TextAlign = ContentAlignment.MiddleCenter;
            CheckBox1.UseVisualStyleBackColor = true;
            CheckBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // ButtonHistogram
            // 
            ButtonHistogram.BackColor = SystemColors.ActiveBorder;
            ButtonHistogram.Dock = DockStyle.Fill;
            ButtonHistogram.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonHistogram.Location = new Point(221, 362);
            ButtonHistogram.Margin = new Padding(3, 4, 3, 4);
            ButtonHistogram.Name = "ButtonHistogram";
            ButtonHistogram.Size = new Size(181, 86);
            ButtonHistogram.TabIndex = 8;
            ButtonHistogram.Text = "Гистограмма";
            ButtonHistogram.UseVisualStyleBackColor = false;
            ButtonHistogram.Click += ButtonHistogram_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(CheckBox1, 3, 5);
            tableLayoutPanel1.Controls.Add(ButtonHistogram, 3, 3);
            tableLayoutPanel1.Controls.Add(dataGridViewStudents, 1, 1);
            tableLayoutPanel1.Controls.Add(ButtonAddStudent, 1, 3);
            tableLayoutPanel1.Controls.Add(ButtonDeleteStudent, 5, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.866357F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60.26263F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.77357244F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.59907F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.67791975F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.954096F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.866356F));
            tableLayoutPanel1.Size = new Size(624, 536);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 536);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DecanatPRO";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonDeleteStudent;
        private Button ButtonAddStudent;
        private DataGridView dataGridViewStudents;
        private DataGridViewTextBoxColumn FullNameColumn;
        private DataGridViewTextBoxColumn GroupColumn;
        private DataGridViewTextBoxColumn DirectionColumn;
        private Label label1;
        private CheckBox CheckBox1;
        private Button ButtonHistogram;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

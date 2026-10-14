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
            label1 = new Label();
            checkBox1 = new CheckBox();
            buttonHistogram = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDeleteStudent
            // 
            buttonDeleteStudent.BackColor = SystemColors.AppWorkspace;
            buttonDeleteStudent.Dock = DockStyle.Fill;
            buttonDeleteStudent.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteStudent.Location = new Point(383, 270);
            buttonDeleteStudent.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteStudent.Name = "buttonDeleteStudent";
            buttonDeleteStudent.Size = new Size(130, 66);
            buttonDeleteStudent.TabIndex = 2;
            buttonDeleteStudent.Text = "Удалить студента";
            buttonDeleteStudent.UseVisualStyleBackColor = false;
            buttonDeleteStudent.Click += buttonDeleteStudent_Click;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.BackColor = SystemColors.AppWorkspace;
            buttonAddStudent.Dock = DockStyle.Fill;
            buttonAddStudent.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddStudent.Location = new Point(30, 270);
            buttonAddStudent.Margin = new Padding(3, 2, 3, 2);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(130, 66);
            buttonAddStudent.TabIndex = 1;
            buttonAddStudent.Text = "Добавить студента";
            buttonAddStudent.UseVisualStyleBackColor = false;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Columns.AddRange(new DataGridViewColumn[] { FullNameColumn, GroupColumn, DirectionColumn });
            tableLayoutPanel1.SetColumnSpan(dataGridViewStudents, 5);
            dataGridViewStudents.Location = new Point(30, 21);
            dataGridViewStudents.Margin = new Padding(3, 2, 3, 2);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.ReadOnly = true;
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(483, 238);
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
            label1.Location = new Point(615, 40);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(239, 352);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Dapper";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // buttonHistogram
            // 
            buttonHistogram.BackColor = SystemColors.ActiveBorder;
            buttonHistogram.Dock = DockStyle.Fill;
            buttonHistogram.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHistogram.Location = new Point(193, 271);
            buttonHistogram.Name = "buttonHistogram";
            buttonHistogram.Size = new Size(157, 64);
            buttonHistogram.TabIndex = 8;
            buttonHistogram.Text = "Гистограмма";
            buttonHistogram.UseVisualStyleBackColor = false;
            buttonHistogram.Click += buttonHistogram_Click;
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
            tableLayoutPanel1.Controls.Add(checkBox1, 3, 5);
            tableLayoutPanel1.Controls.Add(buttonHistogram, 3, 3);
            tableLayoutPanel1.Controls.Add(dataGridViewStudents, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonAddStudent, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonDeleteStudent, 5, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.866357F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60.26263F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.77357244F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.59907F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.67791975F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.954096F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.866356F));
            tableLayoutPanel1.Size = new Size(546, 402);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 402);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button buttonDeleteStudent;
        private Button buttonAddStudent;
        private DataGridView dataGridViewStudents;
        private DataGridViewTextBoxColumn FullNameColumn;
        private DataGridViewTextBoxColumn GroupColumn;
        private DataGridViewTextBoxColumn DirectionColumn;
        private Label label1;
        private CheckBox checkBox1;
        private Button buttonHistogram;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

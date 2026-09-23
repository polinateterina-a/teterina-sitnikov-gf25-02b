namespace WinFormView
{
    partial class DeleteStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridViewStudents = new DataGridView();
            NumberColumn = new DataGridViewTextBoxColumn();
            FullNameColumn = new DataGridViewTextBoxColumn();
            GroupColumn = new DataGridViewTextBoxColumn();
            DirectionColumn = new DataGridViewTextBoxColumn();
            buttonDelete = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonToStart = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 0);
            label1.Name = "label1";
            label1.Size = new Size(634, 45);
            label1.TabIndex = 0;
            label1.Text = "Удаление студента";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Columns.AddRange(new DataGridViewColumn[] { NumberColumn, FullNameColumn, GroupColumn, DirectionColumn });
            dataGridViewStudents.Dock = DockStyle.Fill;
            dataGridViewStudents.Location = new Point(83, 48);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(634, 309);
            dataGridViewStudents.TabIndex = 1;
            // 
            // NumberColumn
            // 
            NumberColumn.HeaderText = "№";
            NumberColumn.MinimumWidth = 6;
            NumberColumn.Name = "NumberColumn";
            // 
            // FullNameColumn
            // 
            FullNameColumn.HeaderText = "ФИО";
            FullNameColumn.MinimumWidth = 6;
            FullNameColumn.Name = "FullNameColumn";
            // 
            // GroupColumn
            // 
            GroupColumn.HeaderText = "Группа";
            GroupColumn.MinimumWidth = 6;
            GroupColumn.Name = "GroupColumn";
            // 
            // DirectionColumn
            // 
            DirectionColumn.HeaderText = "Направление";
            DirectionColumn.MinimumWidth = 6;
            DirectionColumn.Name = "DirectionColumn";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.AppWorkspace;
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(83, 363);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(634, 39);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить выбранного";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(buttonDelete, 1, 2);
            tableLayoutPanel1.Controls.Add(dataGridViewStudents, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonToStart, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonToStart
            // 
            buttonToStart.BackColor = SystemColors.AppWorkspace;
            buttonToStart.Dock = DockStyle.Fill;
            buttonToStart.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonToStart.Location = new Point(83, 408);
            buttonToStart.Name = "buttonToStart";
            buttonToStart.Size = new Size(634, 39);
            buttonToStart.TabIndex = 3;
            buttonToStart.Text = "На главную";
            buttonToStart.UseVisualStyleBackColor = false;
            buttonToStart.Click += buttonToStart_Click;
            // 
            // DeleteStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "DeleteStudentForm";
            Text = "DeleteStudentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewStudents;
        private DataGridViewTextBoxColumn NumberColumn;
        private DataGridViewTextBoxColumn FullNameColumn;
        private DataGridViewTextBoxColumn GroupColumn;
        private DataGridViewTextBoxColumn DirectionColumn;
        private Button buttonDelete;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonToStart;
    }
}
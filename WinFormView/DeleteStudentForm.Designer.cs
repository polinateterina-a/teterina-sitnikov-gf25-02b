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
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 51);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Удаление студента";
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Columns.AddRange(new DataGridViewColumn[] { NumberColumn, FullNameColumn, GroupColumn, DirectionColumn });
            dataGridViewStudents.Location = new Point(29, 128);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(625, 188);
            dataGridViewStudents.TabIndex = 1;
            // 
            // NumberColumn
            // 
            NumberColumn.HeaderText = "№";
            NumberColumn.MinimumWidth = 6;
            NumberColumn.Name = "NumberColumn";
            NumberColumn.Width = 125;
            // 
            // FullNameColumn
            // 
            FullNameColumn.HeaderText = "ФИО";
            FullNameColumn.MinimumWidth = 6;
            FullNameColumn.Name = "FullNameColumn";
            FullNameColumn.Width = 125;
            // 
            // GroupColumn
            // 
            GroupColumn.HeaderText = "Группа";
            GroupColumn.MinimumWidth = 6;
            GroupColumn.Name = "GroupColumn";
            GroupColumn.Width = 125;
            // 
            // DirectionColumn
            // 
            DirectionColumn.HeaderText = "Направление";
            DirectionColumn.MinimumWidth = 6;
            DirectionColumn.Name = "DirectionColumn";
            DirectionColumn.Width = 125;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(309, 393);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить выбранного";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // DeleteStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(dataGridViewStudents);
            Controls.Add(label1);
            Name = "DeleteStudentForm";
            Text = "DeleteStudentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewStudents;
        private DataGridViewTextBoxColumn NumberColumn;
        private DataGridViewTextBoxColumn FullNameColumn;
        private DataGridViewTextBoxColumn GroupColumn;
        private DataGridViewTextBoxColumn DirectionColumn;
        private Button buttonDelete;
    }
}
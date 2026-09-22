namespace WinFormView
{
    partial class StudentListForm
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
            FullNameColumn = new DataGridViewTextBoxColumn();
            GroupColumn = new DataGridViewTextBoxColumn();
            DirectionColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 29);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 0;
            label1.Text = "Список студентов";
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Columns.AddRange(new DataGridViewColumn[] { FullNameColumn, GroupColumn, DirectionColumn });
            dataGridViewStudents.Location = new Point(112, 87);
            dataGridViewStudents.MultiSelect = false;
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.ReadOnly = true;
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudents.Size = new Size(417, 260);
            dataGridViewStudents.TabIndex = 1;
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
            DirectionColumn.HeaderText = "Направление";
            DirectionColumn.MinimumWidth = 6;
            DirectionColumn.Name = "DirectionColumn";
            DirectionColumn.ReadOnly = true;
            // 
            // StudentListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewStudents);
            Controls.Add(label1);
            Name = "StudentListForm";
            Text = "StudentListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewStudents;
        private DataGridViewTextBoxColumn FullNameColumn;
        private DataGridViewTextBoxColumn GroupColumn;
        private DataGridViewTextBoxColumn DirectionColumn;
    }
}
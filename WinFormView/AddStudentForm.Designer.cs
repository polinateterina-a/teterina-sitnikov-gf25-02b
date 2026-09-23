namespace WinFormView
{
    partial class AddStudentForm
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
            label2 = new Label();
            textBoxFullName = new TextBox();
            label3 = new Label();
            textBoxSpeciality = new TextBox();
            label4 = new Label();
            textBoxGroup = new TextBox();
            buttonAdd = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonToStart = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 11);
            label1.Name = "label1";
            label1.Size = new Size(634, 23);
            label1.TabIndex = 0;
            label1.Text = "Добавление студента";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 45);
            label2.Name = "label2";
            label2.Size = new Size(62, 45);
            label2.TabIndex = 1;
            label2.Text = "ФИО:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.BackColor = SystemColors.AppWorkspace;
            textBoxFullName.Dock = DockStyle.Fill;
            textBoxFullName.Location = new Point(83, 93);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(634, 27);
            textBoxFullName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(83, 135);
            label3.Name = "label3";
            label3.Size = new Size(82, 45);
            label3.TabIndex = 3;
            label3.Text = "Группа:";
            // 
            // textBoxSpeciality
            // 
            textBoxSpeciality.BackColor = SystemColors.AppWorkspace;
            textBoxSpeciality.Dock = DockStyle.Fill;
            textBoxSpeciality.Location = new Point(83, 183);
            textBoxSpeciality.Name = "textBoxSpeciality";
            textBoxSpeciality.Size = new Size(634, 27);
            textBoxSpeciality.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(83, 225);
            label4.Name = "label4";
            label4.Size = new Size(177, 45);
            label4.TabIndex = 5;
            label4.Text = "Специальность:";
            // 
            // textBoxGroup
            // 
            textBoxGroup.BackColor = SystemColors.AppWorkspace;
            textBoxGroup.Dock = DockStyle.Fill;
            textBoxGroup.Location = new Point(83, 273);
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.Size = new Size(634, 27);
            textBoxGroup.TabIndex = 6;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.AppWorkspace;
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(83, 363);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(634, 39);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(buttonAdd, 1, 8);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxGroup, 1, 6);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 5);
            tableLayoutPanel1.Controls.Add(textBoxFullName, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxSpeciality, 1, 4);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonToStart, 1, 9);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // buttonToStart
            // 
            buttonToStart.BackColor = SystemColors.AppWorkspace;
            buttonToStart.Dock = DockStyle.Fill;
            buttonToStart.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonToStart.Location = new Point(83, 408);
            buttonToStart.Name = "buttonToStart";
            buttonToStart.Size = new Size(634, 39);
            buttonToStart.TabIndex = 8;
            buttonToStart.Text = "На главную";
            buttonToStart.UseVisualStyleBackColor = false;
            buttonToStart.Click += buttonToStart_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxFullName;
        private Label label3;
        private TextBox textBoxSpeciality;
        private Label label4;
        private TextBox textBoxGroup;
        private Button buttonAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonToStart;
    }
}
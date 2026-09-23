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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 37);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 0;
            label1.Text = "Добавление студента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 76);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "ФИО:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(90, 120);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(125, 27);
            textBoxFullName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 203);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 3;
            label3.Text = "Группа:";
            // 
            // textBoxGroup
            // 
            textBoxSpeciality.Location = new Point(90, 246);
            textBoxSpeciality.Name = "textBoxGroup";
            textBoxSpeciality.Size = new Size(125, 27);
            textBoxSpeciality.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 323);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 5;
            label4.Text = "Специальность:";
            // 
            // textBoxDirection
            // 
            textBoxGroup.Location = new Point(90, 372);
            textBoxGroup.Name = "textBoxDirection";
            textBoxGroup.Size = new Size(125, 27);
            textBoxGroup.TabIndex = 6;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(370, 242);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxGroup);
            Controls.Add(label4);
            Controls.Add(textBoxSpeciality);
            Controls.Add(label3);
            Controls.Add(textBoxFullName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            ResumeLayout(false);
            PerformLayout();
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
    }
}
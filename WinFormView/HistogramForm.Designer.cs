namespace WinFormView
{
    partial class HistogramForm
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
            panelHistogram = new Panel();
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
            label1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 12);
            label1.Name = "label1";
            label1.Size = new Size(634, 21);
            label1.TabIndex = 0;
            label1.Text = "Гистограмма распределения студентов по группам";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelHistogram
            // 
            panelHistogram.Dock = DockStyle.Fill;
            panelHistogram.Location = new Point(83, 48);
            panelHistogram.Name = "panelHistogram";
            panelHistogram.Size = new Size(634, 309);
            panelHistogram.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(panelHistogram, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonToStart, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonToStart
            // 
            buttonToStart.BackColor = SystemColors.ControlDark;
            buttonToStart.Dock = DockStyle.Fill;
            buttonToStart.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonToStart.Location = new Point(83, 363);
            buttonToStart.Name = "buttonToStart";
            buttonToStart.Size = new Size(634, 84);
            buttonToStart.TabIndex = 2;
            buttonToStart.Text = "На главную";
            buttonToStart.UseVisualStyleBackColor = false;
            buttonToStart.Click += buttonToStart_Click;
            // 
            // HistogramForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "HistogramForm";
            Text = "HistogramForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panelHistogram;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonToStart;
    }
}
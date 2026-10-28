namespace Tyuiu.KrukGV.Sprint6.Task2.V15
{
    partial class Form1
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
            groupBoxTask_KGV = new GroupBox();
            textBoxTask_KGV = new TextBox();
            groupBoxInput_KGV = new GroupBox();
            labelEnd_KGV = new Label();
            labelStart_KGV = new Label();
            textBoxEnd_KGV = new TextBox();
            textBoxStart_KGV = new TextBox();
            groupBoxOutput_KGV = new GroupBox();
            dataGridViewOutput_KGV = new DataGridView();
            buttonAbout_KGV = new Button();
            buttonCalculate_KGV = new Button();
            groupBoxTask_KGV.SuspendLayout();
            groupBoxInput_KGV.SuspendLayout();
            groupBoxOutput_KGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_KGV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KGV
            // 
            groupBoxTask_KGV.Controls.Add(textBoxTask_KGV);
            groupBoxTask_KGV.Location = new Point(12, 12);
            groupBoxTask_KGV.Name = "groupBoxTask_KGV";
            groupBoxTask_KGV.Size = new Size(492, 326);
            groupBoxTask_KGV.TabIndex = 0;
            groupBoxTask_KGV.TabStop = false;
            groupBoxTask_KGV.Text = "Условие";
            // 
            // textBoxTask_KGV
            // 
            textBoxTask_KGV.Location = new Point(6, 22);
            textBoxTask_KGV.Multiline = true;
            textBoxTask_KGV.Name = "textBoxTask_KGV";
            textBoxTask_KGV.ReadOnly = true;
            textBoxTask_KGV.Size = new Size(480, 298);
            textBoxTask_KGV.TabIndex = 0;
            textBoxTask_KGV.Text = "Написать программу, которая выводит таблицу значений функции: F(x)=2sin⁡(x)/(3x+1.2)+cos⁡(x)−7x∗2. f(x) на заданном диапазоне [-5; 5] с шагом 1.";
            // 
            // groupBoxInput_KGV
            // 
            groupBoxInput_KGV.Controls.Add(labelEnd_KGV);
            groupBoxInput_KGV.Controls.Add(labelStart_KGV);
            groupBoxInput_KGV.Controls.Add(textBoxEnd_KGV);
            groupBoxInput_KGV.Controls.Add(textBoxStart_KGV);
            groupBoxInput_KGV.Location = new Point(12, 344);
            groupBoxInput_KGV.Name = "groupBoxInput_KGV";
            groupBoxInput_KGV.Size = new Size(301, 94);
            groupBoxInput_KGV.TabIndex = 1;
            groupBoxInput_KGV.TabStop = false;
            groupBoxInput_KGV.Text = "Ввод данных";
            // 
            // labelEnd_KGV
            // 
            labelEnd_KGV.AutoSize = true;
            labelEnd_KGV.Location = new Point(153, 44);
            labelEnd_KGV.Name = "labelEnd_KGV";
            labelEnd_KGV.Size = new Size(124, 15);
            labelEnd_KGV.TabIndex = 3;
            labelEnd_KGV.Text = "Последнее значение:";
            // 
            // labelStart_KGV
            // 
            labelStart_KGV.AutoSize = true;
            labelStart_KGV.Location = new Point(26, 44);
            labelStart_KGV.Name = "labelStart_KGV";
            labelStart_KGV.Size = new Size(121, 15);
            labelStart_KGV.TabIndex = 2;
            labelStart_KGV.Text = "Стартовое значение:";
            // 
            // textBoxEnd_KGV
            // 
            textBoxEnd_KGV.Location = new Point(153, 62);
            textBoxEnd_KGV.Name = "textBoxEnd_KGV";
            textBoxEnd_KGV.Size = new Size(100, 23);
            textBoxEnd_KGV.TabIndex = 1;
            // 
            // textBoxStart_KGV
            // 
            textBoxStart_KGV.Location = new Point(26, 62);
            textBoxStart_KGV.Name = "textBoxStart_KGV";
            textBoxStart_KGV.Size = new Size(100, 23);
            textBoxStart_KGV.TabIndex = 0;
            // 
            // groupBoxOutput_KGV
            // 
            groupBoxOutput_KGV.Controls.Add(dataGridViewOutput_KGV);
            groupBoxOutput_KGV.Location = new Point(510, 12);
            groupBoxOutput_KGV.Name = "groupBoxOutput_KGV";
            groupBoxOutput_KGV.Size = new Size(283, 426);
            groupBoxOutput_KGV.TabIndex = 2;
            groupBoxOutput_KGV.TabStop = false;
            groupBoxOutput_KGV.Text = "Вывод данных";
            // 
            // dataGridViewOutput_KGV
            // 
            dataGridViewOutput_KGV.AllowUserToAddRows = false;
            dataGridViewOutput_KGV.AllowUserToDeleteRows = false;
            dataGridViewOutput_KGV.AllowUserToResizeColumns = false;
            dataGridViewOutput_KGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_KGV.Location = new Point(6, 22);
            dataGridViewOutput_KGV.Name = "dataGridViewOutput_KGV";
            dataGridViewOutput_KGV.ReadOnly = true;
            dataGridViewOutput_KGV.RowHeadersVisible = false;
            dataGridViewOutput_KGV.Size = new Size(271, 395);
            dataGridViewOutput_KGV.TabIndex = 0;
            // 
            // buttonAbout_KGV
            // 
            buttonAbout_KGV.BackColor = SystemColors.ActiveCaption;
            buttonAbout_KGV.Location = new Point(324, 344);
            buttonAbout_KGV.Name = "buttonAbout_KGV";
            buttonAbout_KGV.Size = new Size(84, 94);
            buttonAbout_KGV.TabIndex = 3;
            buttonAbout_KGV.Text = "Справка";
            buttonAbout_KGV.UseVisualStyleBackColor = false;
            buttonAbout_KGV.Click += buttonAboutClick;
            // 
            // buttonCalculate_KGV
            // 
            buttonCalculate_KGV.BackColor = Color.FromArgb(192, 255, 192);
            buttonCalculate_KGV.Location = new Point(414, 344);
            buttonCalculate_KGV.Name = "buttonCalculate_KGV";
            buttonCalculate_KGV.Size = new Size(90, 94);
            buttonCalculate_KGV.TabIndex = 4;
            buttonCalculate_KGV.Text = "Выполнить";
            buttonCalculate_KGV.UseVisualStyleBackColor = false;
            buttonCalculate_KGV.Click += buttonDone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 450);
            Controls.Add(buttonCalculate_KGV);
            Controls.Add(buttonAbout_KGV);
            Controls.Add(groupBoxOutput_KGV);
            Controls.Add(groupBoxInput_KGV);
            Controls.Add(groupBoxTask_KGV);
            Name = "Form1";
            Text = "Form1";
            groupBoxTask_KGV.ResumeLayout(false);
            groupBoxTask_KGV.PerformLayout();
            groupBoxInput_KGV.ResumeLayout(false);
            groupBoxInput_KGV.PerformLayout();
            groupBoxOutput_KGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_KGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KGV;
        private GroupBox groupBoxInput_KGV;
        private GroupBox groupBoxOutput_KGV;
        private TextBox textBoxTask_KGV;
        private Label labelEnd_KGV;
        private Label labelStart_KGV;
        private TextBox textBoxEnd_KGV;
        private TextBox textBoxStart_KGV;
        private DataGridView dataGridViewOutput_KGV;
        private Button buttonAbout_KGV;
        private Button buttonCalculate_KGV;
    }
}

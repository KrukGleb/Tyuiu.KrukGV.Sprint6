namespace Tyuiu.KrukGV.Sprint6.Task3.V19
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_KGV = new GroupBox();
            textBoxTask_KGV = new TextBox();
            groupBoxOuput_KGV = new GroupBox();
            dataGridViewOutput_KGV = new DataGridView();
            buttonCalculate_KGV = new Button();
            buttonAbout_KGV = new Button();
            groupBoxTask_KGV.SuspendLayout();
            groupBoxOuput_KGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_KGV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KGV
            // 
            groupBoxTask_KGV.Controls.Add(textBoxTask_KGV);
            groupBoxTask_KGV.Location = new Point(12, 12);
            groupBoxTask_KGV.Name = "groupBoxTask_KGV";
            groupBoxTask_KGV.Size = new Size(486, 426);
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
            textBoxTask_KGV.Size = new Size(474, 398);
            textBoxTask_KGV.TabIndex = 0;
            textBoxTask_KGV.Text = resources.GetString("textBoxTask_KGV.Text");
            // 
            // groupBoxOuput_KGV
            // 
            groupBoxOuput_KGV.Controls.Add(dataGridViewOutput_KGV);
            groupBoxOuput_KGV.Controls.Add(buttonCalculate_KGV);
            groupBoxOuput_KGV.Controls.Add(buttonAbout_KGV);
            groupBoxOuput_KGV.Location = new Point(513, 12);
            groupBoxOuput_KGV.Name = "groupBoxOuput_KGV";
            groupBoxOuput_KGV.Size = new Size(503, 426);
            groupBoxOuput_KGV.TabIndex = 1;
            groupBoxOuput_KGV.TabStop = false;
            groupBoxOuput_KGV.Text = "Таблица:";
            // 
            // dataGridViewOutput_KGV
            // 
            dataGridViewOutput_KGV.AllowUserToAddRows = false;
            dataGridViewOutput_KGV.AllowUserToDeleteRows = false;
            dataGridViewOutput_KGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_KGV.Location = new Point(18, 22);
            dataGridViewOutput_KGV.Name = "dataGridViewOutput_KGV";
            dataGridViewOutput_KGV.ReadOnly = true;
            dataGridViewOutput_KGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewOutput_KGV.Size = new Size(479, 291);
            dataGridViewOutput_KGV.TabIndex = 4;
            // 
            // buttonCalculate_KGV
            // 
            buttonCalculate_KGV.BackColor = Color.FromArgb(192, 255, 192);
            buttonCalculate_KGV.Location = new Point(417, 361);
            buttonCalculate_KGV.Name = "buttonCalculate_KGV";
            buttonCalculate_KGV.Size = new Size(80, 59);
            buttonCalculate_KGV.TabIndex = 3;
            buttonCalculate_KGV.Text = "Выполнить";
            buttonCalculate_KGV.UseVisualStyleBackColor = false;
            buttonCalculate_KGV.Click += buttonDone_Click;
            // 
            // buttonAbout_KGV
            // 
            buttonAbout_KGV.BackColor = SystemColors.ActiveCaption;
            buttonAbout_KGV.Location = new Point(6, 361);
            buttonAbout_KGV.Name = "buttonAbout_KGV";
            buttonAbout_KGV.Size = new Size(75, 59);
            buttonAbout_KGV.TabIndex = 2;
            buttonAbout_KGV.Text = "Справка";
            buttonAbout_KGV.UseVisualStyleBackColor = false;
            buttonAbout_KGV.Click += buttonAboutClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 450);
            Controls.Add(groupBoxOuput_KGV);
            Controls.Add(groupBoxTask_KGV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 19 | Крук Г.В.";
            Load += FormMain_Load;
            groupBoxTask_KGV.ResumeLayout(false);
            groupBoxTask_KGV.PerformLayout();
            groupBoxOuput_KGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_KGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KGV;
        private GroupBox groupBoxOuput_KGV;
        private TextBox textBoxTask_KGV;
        private DataGridView dataGridViewOutput_KGV;
        private Button buttonCalculate_KGV;
        private Button buttonAbout_KGV;
    }
}

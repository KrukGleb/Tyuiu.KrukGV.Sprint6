namespace Tyuiu.KrukGV.Sprint6.Task5.V22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_KGV = new GroupBox();
            textBoxTask_KGV = new TextBox();
            groupBoxOutput_KGV = new GroupBox();
            buttonCalculate__KGV = new Button();
            buttonOpen_KGV = new Button();
            buttonAbout_KGV = new Button();
            chartFunction_KGV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewOutput_KGV = new DataGridView();
            groupBoxTask_KGV.SuspendLayout();
            groupBoxOutput_KGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_KGV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KGV
            // 
            groupBoxTask_KGV.Controls.Add(textBoxTask_KGV);
            groupBoxTask_KGV.Location = new Point(12, 12);
            groupBoxTask_KGV.Name = "groupBoxTask_KGV";
            groupBoxTask_KGV.Size = new Size(523, 100);
            groupBoxTask_KGV.TabIndex = 0;
            groupBoxTask_KGV.TabStop = false;
            groupBoxTask_KGV.Text = "Условие";
            // 
            // textBoxTask_KGV
            // 
            textBoxTask_KGV.Location = new Point(21, 26);
            textBoxTask_KGV.Multiline = true;
            textBoxTask_KGV.Name = "textBoxTask_KGV";
            textBoxTask_KGV.ReadOnly = true;
            textBoxTask_KGV.Size = new Size(496, 68);
            textBoxTask_KGV.TabIndex = 0;
            textBoxTask_KGV.Text = "Прочитать данные из файла InPutFileTask5V22.txt. Вывести в dataGridView.Дан список из 20 чисел. Вывести все числа, больше 5.  Построить диаграмму по этим значениям.";
            // 
            // groupBoxOutput_KGV
            // 
            groupBoxOutput_KGV.Controls.Add(dataGridViewOutput_KGV);
            groupBoxOutput_KGV.Location = new Point(12, 118);
            groupBoxOutput_KGV.Name = "groupBoxOutput_KGV";
            groupBoxOutput_KGV.Size = new Size(200, 320);
            groupBoxOutput_KGV.TabIndex = 1;
            groupBoxOutput_KGV.TabStop = false;
            groupBoxOutput_KGV.Text = "Вывод данных";
            // 
            // buttonCalculate__KGV
            // 
            buttonCalculate__KGV.BackColor = Color.FromArgb(192, 255, 192);
            buttonCalculate__KGV.Location = new Point(541, 38);
            buttonCalculate__KGV.Name = "buttonCalculate__KGV";
            buttonCalculate__KGV.Size = new Size(85, 68);
            buttonCalculate__KGV.TabIndex = 2;
            buttonCalculate__KGV.Text = "Выполнить";
            buttonCalculate__KGV.UseVisualStyleBackColor = false;
            buttonCalculate__KGV.Click += buttonDone_Click;
            // 
            // buttonOpen_KGV
            // 
            buttonOpen_KGV.Location = new Point(632, 38);
            buttonOpen_KGV.Name = "buttonOpen_KGV";
            buttonOpen_KGV.Size = new Size(75, 68);
            buttonOpen_KGV.TabIndex = 3;
            buttonOpen_KGV.Text = "Открыть файл";
            buttonOpen_KGV.UseVisualStyleBackColor = true;
            buttonOpen_KGV.Click += buttonOpenCLick;
            // 
            // buttonAbout_KGV
            // 
            buttonAbout_KGV.BackColor = SystemColors.ActiveCaption;
            buttonAbout_KGV.Location = new Point(713, 38);
            buttonAbout_KGV.Name = "buttonAbout_KGV";
            buttonAbout_KGV.Size = new Size(75, 68);
            buttonAbout_KGV.TabIndex = 4;
            buttonAbout_KGV.Text = "Справка";
            buttonAbout_KGV.UseVisualStyleBackColor = false;
            buttonAbout_KGV.Click += buttonAboutClick;
            // 
            // chartFunction_KGV
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction_KGV.ChartAreas.Add(chartArea2);
            chartFunction_KGV.Location = new Point(218, 118);
            chartFunction_KGV.Name = "chartFunction_KGV";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            chartFunction_KGV.Series.Add(series2);
            chartFunction_KGV.Size = new Size(570, 320);
            chartFunction_KGV.TabIndex = 5;
            chartFunction_KGV.Text = "chart1";
            // 
            // dataGridViewOutput_KGV
            // 
            dataGridViewOutput_KGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_KGV.Location = new Point(6, 22);
            dataGridViewOutput_KGV.Name = "dataGridViewOutput_KGV";
            dataGridViewOutput_KGV.Size = new Size(188, 292);
            dataGridViewOutput_KGV.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chartFunction_KGV);
            Controls.Add(buttonAbout_KGV);
            Controls.Add(buttonOpen_KGV);
            Controls.Add(buttonCalculate__KGV);
            Controls.Add(groupBoxOutput_KGV);
            Controls.Add(groupBoxTask_KGV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 22 | Крук Г.В.";
            groupBoxTask_KGV.ResumeLayout(false);
            groupBoxTask_KGV.PerformLayout();
            groupBoxOutput_KGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_KGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_KGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KGV;
        private GroupBox groupBoxOutput_KGV;
        private Button buttonCalculate__KGV;
        private Button buttonOpen_KGV;
        private Button buttonAbout_KGV;
        private TextBox textBoxTask_KGV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KGV;
        private DataGridView dataGridViewOutput_KGV;
    }
}

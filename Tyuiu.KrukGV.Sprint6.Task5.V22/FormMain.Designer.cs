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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_KGV = new GroupBox();
            textBoxTask_KGV = new TextBox();
            groupBoxOutput_KGV = new GroupBox();
            dataGridViewOutput_KGV = new DataGridView();
            buttonCalculate__KGV = new Button();
            buttonOpen_KGV = new Button();
            buttonAbout_KGV = new Button();
            chartFunction_KGV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel_KGV = new TableLayoutPanel();
            groupBoxButtons_KGV = new GroupBox();
            groupBoxTask_KGV.SuspendLayout();
            groupBoxOutput_KGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_KGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KGV).BeginInit();
            tableLayoutPanel_KGV.SuspendLayout();
            groupBoxButtons_KGV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KGV
            // 
            groupBoxTask_KGV.Controls.Add(textBoxTask_KGV);
            groupBoxTask_KGV.Location = new Point(3, 3);
            groupBoxTask_KGV.Name = "groupBoxTask_KGV";
            groupBoxTask_KGV.Size = new Size(633, 127);
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
            textBoxTask_KGV.Size = new Size(606, 95);
            textBoxTask_KGV.TabIndex = 0;
            textBoxTask_KGV.Text = "Прочитать данные из файла InPutFileTask5V22.txt. Вывести в dataGridView.Дан список из 20 чисел. Вывести все числа, больше 5.  Построить диаграмму по этим значениям.";
            // 
            // groupBoxOutput_KGV
            // 
            groupBoxOutput_KGV.Controls.Add(dataGridViewOutput_KGV);
            groupBoxOutput_KGV.Location = new Point(642, 136);
            groupBoxOutput_KGV.Name = "groupBoxOutput_KGV";
            groupBoxOutput_KGV.Size = new Size(200, 320);
            groupBoxOutput_KGV.TabIndex = 1;
            groupBoxOutput_KGV.TabStop = false;
            groupBoxOutput_KGV.Text = "Вывод данных";
            // 
            // dataGridViewOutput_KGV
            // 
            dataGridViewOutput_KGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_KGV.Location = new Point(6, 22);
            dataGridViewOutput_KGV.Name = "dataGridViewOutput_KGV";
            dataGridViewOutput_KGV.Size = new Size(282, 503);
            dataGridViewOutput_KGV.TabIndex = 0;
            // 
            // buttonCalculate__KGV
            // 
            buttonCalculate__KGV.BackColor = Color.FromArgb(192, 255, 192);
            buttonCalculate__KGV.Location = new Point(6, 32);
            buttonCalculate__KGV.Name = "buttonCalculate__KGV";
            buttonCalculate__KGV.Size = new Size(85, 68);
            buttonCalculate__KGV.TabIndex = 2;
            buttonCalculate__KGV.Text = "Выполнить";
            buttonCalculate__KGV.UseVisualStyleBackColor = false;
            buttonCalculate__KGV.Click += buttonDone_Click;
            // 
            // buttonOpen_KGV
            // 
            buttonOpen_KGV.Location = new Point(119, 32);
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
            buttonAbout_KGV.Location = new Point(213, 32);
            buttonAbout_KGV.Name = "buttonAbout_KGV";
            buttonAbout_KGV.Size = new Size(75, 68);
            buttonAbout_KGV.TabIndex = 4;
            buttonAbout_KGV.Text = "Справка";
            buttonAbout_KGV.UseVisualStyleBackColor = false;
            buttonAbout_KGV.Click += buttonAboutClick;
            // 
            // chartFunction_KGV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KGV.ChartAreas.Add(chartArea1);
            chartFunction_KGV.Location = new Point(3, 136);
            chartFunction_KGV.Name = "chartFunction_KGV";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chartFunction_KGV.Series.Add(series1);
            chartFunction_KGV.Size = new Size(633, 525);
            chartFunction_KGV.TabIndex = 5;
            chartFunction_KGV.Text = "chart1";
            // 
            // tableLayoutPanel_KGV
            // 
            tableLayoutPanel_KGV.ColumnCount = 2;
            tableLayoutPanel_KGV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.8344F));
            tableLayoutPanel_KGV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.1656036F));
            tableLayoutPanel_KGV.Controls.Add(groupBoxButtons_KGV, 1, 0);
            tableLayoutPanel_KGV.Controls.Add(groupBoxTask_KGV, 0, 0);
            tableLayoutPanel_KGV.Controls.Add(groupBoxOutput_KGV, 1, 1);
            tableLayoutPanel_KGV.Controls.Add(chartFunction_KGV, 0, 1);
            tableLayoutPanel_KGV.Dock = DockStyle.Fill;
            tableLayoutPanel_KGV.Location = new Point(0, 0);
            tableLayoutPanel_KGV.Name = "tableLayoutPanel_KGV";
            tableLayoutPanel_KGV.RowCount = 2;
            tableLayoutPanel_KGV.RowStyles.Add(new RowStyle(SizeType.Percent, 19.7622585F));
            tableLayoutPanel_KGV.RowStyles.Add(new RowStyle(SizeType.Percent, 80.23774F));
            tableLayoutPanel_KGV.Size = new Size(942, 673);
            tableLayoutPanel_KGV.TabIndex = 6;
            // 
            // groupBoxButtons_KGV
            // 
            groupBoxButtons_KGV.Controls.Add(buttonCalculate__KGV);
            groupBoxButtons_KGV.Controls.Add(buttonOpen_KGV);
            groupBoxButtons_KGV.Controls.Add(buttonAbout_KGV);
            groupBoxButtons_KGV.Location = new Point(642, 3);
            groupBoxButtons_KGV.Name = "groupBoxButtons_KGV";
            groupBoxButtons_KGV.Size = new Size(297, 127);
            groupBoxButtons_KGV.TabIndex = 7;
            groupBoxButtons_KGV.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 673);
            Controls.Add(tableLayoutPanel_KGV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 22 | Крук Г.В.";
            groupBoxTask_KGV.ResumeLayout(false);
            groupBoxTask_KGV.PerformLayout();
            groupBoxOutput_KGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_KGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KGV).EndInit();
            tableLayoutPanel_KGV.ResumeLayout(false);
            groupBoxButtons_KGV.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel_KGV;
        private GroupBox groupBoxButtons_KGV;
    }
}

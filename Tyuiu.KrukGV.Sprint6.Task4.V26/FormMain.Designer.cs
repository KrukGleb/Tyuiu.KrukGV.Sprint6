namespace Tyuiu.KrukGV.Sprint6.Task4.V26
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
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartFunction_KGV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBox1 = new TextBox();
            textBoxOutput_KGV = new TextBox();
            groupBoxTask_KGV = new GroupBox();
            groupBoxInput_KGV = new GroupBox();
            labelEnd_KGV = new Label();
            labelStart_KGV = new Label();
            textBoxEnd_KGV = new TextBox();
            textBoxStart_KGV = new TextBox();
            buttonSave_KGV = new Button();
            buttonAbout_KGV = new Button();
            buttonCalculate_KGV = new Button();
            groupBoxOutput_KGV = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KGV).BeginInit();
            groupBoxTask_KGV.SuspendLayout();
            groupBoxInput_KGV.SuspendLayout();
            groupBoxOutput_KGV.SuspendLayout();
            SuspendLayout();
            // 
            // chartFunction_KGV
            // 
            chartFunction_KGV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textAnnotation1.AnchorAlignment = ContentAlignment.TopCenter;
            textAnnotation1.Name = "TextAnnotation1";
            textAnnotation1.Text = "График f(x)";
            chartFunction_KGV.Annotations.Add(textAnnotation1);
            chartArea1.Name = "GraphFunction";
            chartFunction_KGV.ChartAreas.Add(chartArea1);
            chartFunction_KGV.Location = new Point(238, 105);
            chartFunction_KGV.Name = "chartFunction_KGV";
            chartFunction_KGV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "GraphFunction";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KGV.Series.Add(series1);
            chartFunction_KGV.Size = new Size(550, 333);
            chartFunction_KGV.TabIndex = 0;
            chartFunction_KGV.Text = "chart1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(345, 56);
            textBox1.TabIndex = 1;
            textBox1.Text = "Вывести таблицу значений функции: F(x)=5-3x +(1+sinx)/(2x-0.5). f(x) на [-5; 5] с шагом 1. При делении на ноль вернуть значение 0.  Сохранить в файл результат.";
            // 
            // textBoxOutput_KGV
            // 
            textBoxOutput_KGV.Location = new Point(6, 22);
            textBoxOutput_KGV.Multiline = true;
            textBoxOutput_KGV.Name = "textBoxOutput_KGV";
            textBoxOutput_KGV.Size = new Size(188, 305);
            textBoxOutput_KGV.TabIndex = 2;
            // 
            // groupBoxTask_KGV
            // 
            groupBoxTask_KGV.Controls.Add(textBox1);
            groupBoxTask_KGV.Location = new Point(12, 12);
            groupBoxTask_KGV.Name = "groupBoxTask_KGV";
            groupBoxTask_KGV.Size = new Size(357, 87);
            groupBoxTask_KGV.TabIndex = 3;
            groupBoxTask_KGV.TabStop = false;
            groupBoxTask_KGV.Text = "Условие";
            // 
            // groupBoxInput_KGV
            // 
            groupBoxInput_KGV.Controls.Add(labelEnd_KGV);
            groupBoxInput_KGV.Controls.Add(labelStart_KGV);
            groupBoxInput_KGV.Controls.Add(textBoxEnd_KGV);
            groupBoxInput_KGV.Controls.Add(textBoxStart_KGV);
            groupBoxInput_KGV.Location = new Point(375, 12);
            groupBoxInput_KGV.Name = "groupBoxInput_KGV";
            groupBoxInput_KGV.Size = new Size(164, 87);
            groupBoxInput_KGV.TabIndex = 4;
            groupBoxInput_KGV.TabStop = false;
            groupBoxInput_KGV.Text = "Ввод данных";
            // 
            // labelEnd_KGV
            // 
            labelEnd_KGV.AutoSize = true;
            labelEnd_KGV.Location = new Point(120, 37);
            labelEnd_KGV.Name = "labelEnd_KGV";
            labelEnd_KGV.Size = new Size(34, 15);
            labelEnd_KGV.TabIndex = 3;
            labelEnd_KGV.Text = "Стоп";
            // 
            // labelStart_KGV
            // 
            labelStart_KGV.AutoSize = true;
            labelStart_KGV.Location = new Point(6, 37);
            labelStart_KGV.Name = "labelStart_KGV";
            labelStart_KGV.Size = new Size(38, 15);
            labelStart_KGV.TabIndex = 2;
            labelStart_KGV.Text = "Старт";
            // 
            // textBoxEnd_KGV
            // 
            textBoxEnd_KGV.Location = new Point(108, 55);
            textBoxEnd_KGV.Name = "textBoxEnd_KGV";
            textBoxEnd_KGV.Size = new Size(50, 23);
            textBoxEnd_KGV.TabIndex = 1;
            // 
            // textBoxStart_KGV
            // 
            textBoxStart_KGV.Location = new Point(6, 55);
            textBoxStart_KGV.Name = "textBoxStart_KGV";
            textBoxStart_KGV.Size = new Size(48, 23);
            textBoxStart_KGV.TabIndex = 0;
            textBoxStart_KGV.KeyPress += textBoxVarX_KeyPress;
            // 
            // buttonSave_KGV
            // 
            buttonSave_KGV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_KGV.Location = new Point(632, 25);
            buttonSave_KGV.Name = "buttonSave_KGV";
            buttonSave_KGV.Size = new Size(75, 65);
            buttonSave_KGV.TabIndex = 5;
            buttonSave_KGV.Text = "Сохранить";
            buttonSave_KGV.UseVisualStyleBackColor = true;
            buttonSave_KGV.Click += buttonSaveCLick;
            // 
            // buttonAbout_KGV
            // 
            buttonAbout_KGV.BackColor = SystemColors.ActiveCaption;
            buttonAbout_KGV.Location = new Point(713, 25);
            buttonAbout_KGV.Name = "buttonAbout_KGV";
            buttonAbout_KGV.Size = new Size(75, 65);
            buttonAbout_KGV.TabIndex = 6;
            buttonAbout_KGV.Text = "Справка";
            buttonAbout_KGV.UseVisualStyleBackColor = false;
            buttonAbout_KGV.Click += buttonAboutClick;
            // 
            // buttonCalculate_KGV
            // 
            buttonCalculate_KGV.BackColor = Color.FromArgb(192, 255, 192);
            buttonCalculate_KGV.Location = new Point(545, 25);
            buttonCalculate_KGV.Name = "buttonCalculate_KGV";
            buttonCalculate_KGV.Size = new Size(81, 65);
            buttonCalculate_KGV.TabIndex = 7;
            buttonCalculate_KGV.Text = "Вычислить";
            buttonCalculate_KGV.UseVisualStyleBackColor = false;
            buttonCalculate_KGV.Click += buttonDone_Click;
            // 
            // groupBoxOutput_KGV
            // 
            groupBoxOutput_KGV.Controls.Add(textBoxOutput_KGV);
            groupBoxOutput_KGV.Location = new Point(18, 105);
            groupBoxOutput_KGV.Name = "groupBoxOutput_KGV";
            groupBoxOutput_KGV.Size = new Size(200, 333);
            groupBoxOutput_KGV.TabIndex = 8;
            groupBoxOutput_KGV.TabStop = false;
            groupBoxOutput_KGV.Text = "Вывод данных";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave_KGV);
            Controls.Add(groupBoxOutput_KGV);
            Controls.Add(buttonCalculate_KGV);
            Controls.Add(buttonAbout_KGV);
            Controls.Add(groupBoxInput_KGV);
            Controls.Add(groupBoxTask_KGV);
            Controls.Add(chartFunction_KGV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 26 | Крук Г.В.";
            ((System.ComponentModel.ISupportInitialize)chartFunction_KGV).EndInit();
            groupBoxTask_KGV.ResumeLayout(false);
            groupBoxTask_KGV.PerformLayout();
            groupBoxInput_KGV.ResumeLayout(false);
            groupBoxInput_KGV.PerformLayout();
            groupBoxOutput_KGV.ResumeLayout(false);
            groupBoxOutput_KGV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KGV;
        private TextBox textBox1;
        private TextBox textBoxOutput_KGV;
        private GroupBox groupBoxTask_KGV;
        private GroupBox groupBoxInput_KGV;
        private Button buttonSave_KGV;
        private Button buttonAbout_KGV;
        private Button buttonCalculate_KGV;
        private GroupBox groupBoxOutput_KGV;
        private Label labelEnd_KGV;
        private Label labelStart_KGV;
        private TextBox textBoxEnd_KGV;
        private TextBox textBoxStart_KGV;
    }
}

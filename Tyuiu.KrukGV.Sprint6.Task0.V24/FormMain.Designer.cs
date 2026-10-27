namespace Tyuiu.KrukGV.Sprint6.Task0.V24
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
            textBoxInputX_KGV = new TextBox();
            textBoxTask_KGV = new TextBox();
            groupBoxInfo_KGV = new GroupBox();
            pictureBoxFormula_KGV = new PictureBox();
            groupBoxInput_KGV = new GroupBox();
            labelInputX_KGV = new Label();
            groupBoxOutput_KGV = new GroupBox();
            labelOutputResult_KGV = new Label();
            textBoxOutputResult_KGV = new TextBox();
            buttoCalculate_KGV = new Button();
            buttonAbout_KGV = new Button();
            groupBoxInfo_KGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KGV).BeginInit();
            groupBoxInput_KGV.SuspendLayout();
            groupBoxOutput_KGV.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxInputX_KGV
            // 
            textBoxInputX_KGV.Location = new Point(225, 95);
            textBoxInputX_KGV.Name = "textBoxInputX_KGV";
            textBoxInputX_KGV.Size = new Size(100, 23);
            textBoxInputX_KGV.TabIndex = 0;
            textBoxInputX_KGV.KeyPress += textBoxVarX_KeyPress;
            // 
            // textBoxTask_KGV
            // 
            textBoxTask_KGV.Location = new Point(23, 22);
            textBoxTask_KGV.Multiline = true;
            textBoxTask_KGV.Name = "textBoxTask_KGV";
            textBoxTask_KGV.ReadOnly = true;
            textBoxTask_KGV.Size = new Size(514, 209);
            textBoxTask_KGV.TabIndex = 2;
            textBoxTask_KGV.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой.";
            // 
            // groupBoxInfo_KGV
            // 
            groupBoxInfo_KGV.Controls.Add(pictureBoxFormula_KGV);
            groupBoxInfo_KGV.Controls.Add(textBoxTask_KGV);
            groupBoxInfo_KGV.Location = new Point(12, 12);
            groupBoxInfo_KGV.Name = "groupBoxInfo_KGV";
            groupBoxInfo_KGV.Size = new Size(776, 277);
            groupBoxInfo_KGV.TabIndex = 3;
            groupBoxInfo_KGV.TabStop = false;
            groupBoxInfo_KGV.Text = "Условие";
            // 
            // pictureBoxFormula_KGV
            // 
            pictureBoxFormula_KGV.Image = Properties.Resources.FormulaImageTask0;
            pictureBoxFormula_KGV.ImageLocation = "";
            pictureBoxFormula_KGV.Location = new Point(579, 22);
            pictureBoxFormula_KGV.Name = "pictureBoxFormula_KGV";
            pictureBoxFormula_KGV.Size = new Size(160, 40);
            pictureBoxFormula_KGV.TabIndex = 3;
            pictureBoxFormula_KGV.TabStop = false;
            // 
            // groupBoxInput_KGV
            // 
            groupBoxInput_KGV.Controls.Add(labelInputX_KGV);
            groupBoxInput_KGV.Controls.Add(textBoxInputX_KGV);
            groupBoxInput_KGV.Location = new Point(12, 295);
            groupBoxInput_KGV.Name = "groupBoxInput_KGV";
            groupBoxInput_KGV.Size = new Size(537, 143);
            groupBoxInput_KGV.TabIndex = 4;
            groupBoxInput_KGV.TabStop = false;
            groupBoxInput_KGV.Text = "Ввод данных";
            // 
            // labelInputX_KGV
            // 
            labelInputX_KGV.AutoSize = true;
            labelInputX_KGV.Location = new Point(225, 77);
            labelInputX_KGV.Name = "labelInputX_KGV";
            labelInputX_KGV.Size = new Size(89, 15);
            labelInputX_KGV.TabIndex = 1;
            labelInputX_KGV.Text = "Переменная X:";
            // 
            // groupBoxOutput_KGV
            // 
            groupBoxOutput_KGV.Controls.Add(labelOutputResult_KGV);
            groupBoxOutput_KGV.Controls.Add(textBoxOutputResult_KGV);
            groupBoxOutput_KGV.Location = new Point(555, 295);
            groupBoxOutput_KGV.Name = "groupBoxOutput_KGV";
            groupBoxOutput_KGV.Size = new Size(233, 143);
            groupBoxOutput_KGV.TabIndex = 5;
            groupBoxOutput_KGV.TabStop = false;
            groupBoxOutput_KGV.Text = "Вывод данных";
            // 
            // labelOutputResult_KGV
            // 
            labelOutputResult_KGV.AutoSize = true;
            labelOutputResult_KGV.Location = new Point(6, 77);
            labelOutputResult_KGV.Name = "labelOutputResult_KGV";
            labelOutputResult_KGV.Size = new Size(63, 15);
            labelOutputResult_KGV.TabIndex = 1;
            labelOutputResult_KGV.Text = "Результат:";
            labelOutputResult_KGV.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxOutputResult_KGV
            // 
            textBoxOutputResult_KGV.Location = new Point(6, 95);
            textBoxOutputResult_KGV.Name = "textBoxOutputResult_KGV";
            textBoxOutputResult_KGV.ReadOnly = true;
            textBoxOutputResult_KGV.Size = new Size(100, 23);
            textBoxOutputResult_KGV.TabIndex = 0;
            // 
            // buttoCalculate_KGV
            // 
            buttoCalculate_KGV.Location = new Point(695, 444);
            buttoCalculate_KGV.Name = "buttoCalculate_KGV";
            buttoCalculate_KGV.Size = new Size(93, 47);
            buttoCalculate_KGV.TabIndex = 6;
            buttoCalculate_KGV.Text = "Выполнить";
            buttoCalculate_KGV.UseVisualStyleBackColor = true;
            buttoCalculate_KGV.Click += buttonCalculateClick;
            // 
            // buttonAbout_KGV
            // 
            buttonAbout_KGV.Location = new Point(640, 444);
            buttonAbout_KGV.Name = "buttonAbout_KGV";
            buttonAbout_KGV.Size = new Size(49, 47);
            buttonAbout_KGV.TabIndex = 7;
            buttonAbout_KGV.Text = "?";
            buttonAbout_KGV.UseVisualStyleBackColor = true;
            buttonAbout_KGV.Click += buttonAboutClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(buttonAbout_KGV);
            Controls.Add(buttoCalculate_KGV);
            Controls.Add(groupBoxOutput_KGV);
            Controls.Add(groupBoxInput_KGV);
            Controls.Add(groupBoxInfo_KGV);
            Name = "FormMain";
            Text = "Form1";
            groupBoxInfo_KGV.ResumeLayout(false);
            groupBoxInfo_KGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KGV).EndInit();
            groupBoxInput_KGV.ResumeLayout(false);
            groupBoxInput_KGV.PerformLayout();
            groupBoxOutput_KGV.ResumeLayout(false);
            groupBoxOutput_KGV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxInputX_KGV;
        private TextBox textBoxTask_KGV;
        private GroupBox groupBoxInfo_KGV;
        private PictureBox pictureBoxFormula_KGV;
        private GroupBox groupBoxInput_KGV;
        private GroupBox groupBoxOutput_KGV;
        private Button buttoCalculate_KGV;
        private TextBox textBoxOutputResult_KGV;
        private Label labelOutputResult_KGV;
        private Label labelInputX_KGV;
        private Button buttonAbout_KGV;
    }
}

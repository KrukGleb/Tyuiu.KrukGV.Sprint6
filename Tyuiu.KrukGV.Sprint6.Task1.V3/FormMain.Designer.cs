namespace Tyuiu.KrukGV.Sprint6.Task1.V3
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
            groupBoxOutput_KGV = new GroupBox();
            textBoxOutput_KGV = new TextBox();
            labelResult_KGV = new Label();
            groupBoxInput_KGV = new GroupBox();
            textBoxEnd_KGV = new TextBox();
            labelEnd_KGV = new Label();
            textBoxStart_KGV = new TextBox();
            labelStart_KGV = new Label();
            buttonAbout_KGV = new Button();
            buttonCalculate_KGV = new Button();
            groupBoxTask_KGV.SuspendLayout();
            groupBoxOutput_KGV.SuspendLayout();
            groupBoxInput_KGV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KGV
            // 
            groupBoxTask_KGV.Controls.Add(textBoxTask_KGV);
            groupBoxTask_KGV.Location = new Point(12, 12);
            groupBoxTask_KGV.Name = "groupBoxTask_KGV";
            groupBoxTask_KGV.Size = new Size(537, 333);
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
            textBoxTask_KGV.Size = new Size(525, 305);
            textBoxTask_KGV.TabIndex = 0;
            textBoxTask_KGV.Text = resources.GetString("textBoxTask_KGV.Text");
            // 
            // groupBoxOutput_KGV
            // 
            groupBoxOutput_KGV.Controls.Add(textBoxOutput_KGV);
            groupBoxOutput_KGV.Controls.Add(labelResult_KGV);
            groupBoxOutput_KGV.Location = new Point(555, 12);
            groupBoxOutput_KGV.Name = "groupBoxOutput_KGV";
            groupBoxOutput_KGV.Size = new Size(315, 426);
            groupBoxOutput_KGV.TabIndex = 1;
            groupBoxOutput_KGV.TabStop = false;
            groupBoxOutput_KGV.Text = "Вывод данных";
            // 
            // textBoxOutput_KGV
            // 
            textBoxOutput_KGV.Location = new Point(6, 37);
            textBoxOutput_KGV.Multiline = true;
            textBoxOutput_KGV.Name = "textBoxOutput_KGV";
            textBoxOutput_KGV.ReadOnly = true;
            textBoxOutput_KGV.Size = new Size(309, 383);
            textBoxOutput_KGV.TabIndex = 2;
            // 
            // labelResult_KGV
            // 
            labelResult_KGV.AutoSize = true;
            labelResult_KGV.Location = new Point(6, 19);
            labelResult_KGV.Name = "labelResult_KGV";
            labelResult_KGV.Size = new Size(63, 15);
            labelResult_KGV.TabIndex = 1;
            labelResult_KGV.Text = "Результат:";
            // 
            // groupBoxInput_KGV
            // 
            groupBoxInput_KGV.Controls.Add(textBoxEnd_KGV);
            groupBoxInput_KGV.Controls.Add(labelEnd_KGV);
            groupBoxInput_KGV.Controls.Add(textBoxStart_KGV);
            groupBoxInput_KGV.Controls.Add(labelStart_KGV);
            groupBoxInput_KGV.Location = new Point(12, 351);
            groupBoxInput_KGV.Name = "groupBoxInput_KGV";
            groupBoxInput_KGV.Size = new Size(323, 87);
            groupBoxInput_KGV.TabIndex = 2;
            groupBoxInput_KGV.TabStop = false;
            groupBoxInput_KGV.Text = "groupBox3";
            // 
            // textBoxEnd_KGV
            // 
            textBoxEnd_KGV.Location = new Point(112, 45);
            textBoxEnd_KGV.Name = "textBoxEnd_KGV";
            textBoxEnd_KGV.Size = new Size(100, 23);
            textBoxEnd_KGV.TabIndex = 3;
            textBoxEnd_KGV.KeyPress += textBoxVarX_KeyPress;
            // 
            // labelEnd_KGV
            // 
            labelEnd_KGV.AutoSize = true;
            labelEnd_KGV.Location = new Point(112, 27);
            labelEnd_KGV.Name = "labelEnd_KGV";
            labelEnd_KGV.Size = new Size(75, 15);
            labelEnd_KGV.TabIndex = 2;
            labelEnd_KGV.Text = "Конец шага:";
            // 
            // textBoxStart_KGV
            // 
            textBoxStart_KGV.Location = new Point(6, 45);
            textBoxStart_KGV.Name = "textBoxStart_KGV";
            textBoxStart_KGV.Size = new Size(100, 23);
            textBoxStart_KGV.TabIndex = 1;
            textBoxStart_KGV.KeyPress += textBoxVarX_KeyPress;
            // 
            // labelStart_KGV
            // 
            labelStart_KGV.AutoSize = true;
            labelStart_KGV.Location = new Point(6, 27);
            labelStart_KGV.Name = "labelStart_KGV";
            labelStart_KGV.Size = new Size(72, 15);
            labelStart_KGV.TabIndex = 0;
            labelStart_KGV.Text = "Старт шага:";
            // 
            // buttonAbout_KGV
            // 
            buttonAbout_KGV.BackColor = SystemColors.ActiveCaption;
            buttonAbout_KGV.Location = new Point(341, 351);
            buttonAbout_KGV.Name = "buttonAbout_KGV";
            buttonAbout_KGV.Size = new Size(98, 87);
            buttonAbout_KGV.TabIndex = 3;
            buttonAbout_KGV.Text = "Справка";
            buttonAbout_KGV.UseVisualStyleBackColor = false;
            buttonAbout_KGV.Click += buttonAboutClick;
            // 
            // buttonCalculate_KGV
            // 
            buttonCalculate_KGV.BackColor = Color.PaleGreen;
            buttonCalculate_KGV.Location = new Point(445, 351);
            buttonCalculate_KGV.Name = "buttonCalculate_KGV";
            buttonCalculate_KGV.Size = new Size(104, 87);
            buttonCalculate_KGV.TabIndex = 4;
            buttonCalculate_KGV.Text = "Выполнить";
            buttonCalculate_KGV.UseVisualStyleBackColor = false;
            buttonCalculate_KGV.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 450);
            Controls.Add(buttonCalculate_KGV);
            Controls.Add(buttonAbout_KGV);
            Controls.Add(groupBoxInput_KGV);
            Controls.Add(groupBoxOutput_KGV);
            Controls.Add(groupBoxTask_KGV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 3 | Крук Г.В.";
            groupBoxTask_KGV.ResumeLayout(false);
            groupBoxTask_KGV.PerformLayout();
            groupBoxOutput_KGV.ResumeLayout(false);
            groupBoxOutput_KGV.PerformLayout();
            groupBoxInput_KGV.ResumeLayout(false);
            groupBoxInput_KGV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KGV;
        private TextBox textBoxTask_KGV;
        private GroupBox groupBoxOutput_KGV;
        private Label labelResult_KGV;
        private GroupBox groupBoxInput_KGV;
        private Button buttonAbout_KGV;
        private Button buttonCalculate_KGV;
        private TextBox textBoxStart_KGV;
        private Label labelStart_KGV;
        private TextBox textBoxEnd_KGV;
        private Label labelEnd_KGV;
        private TextBox textBoxOutput_KGV;
    }
}

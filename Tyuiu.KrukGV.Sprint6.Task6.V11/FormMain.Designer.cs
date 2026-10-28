namespace Tyuiu.KrukGV.Sprint6.Task6.V11
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            openFileDialogTask_KGV = new OpenFileDialog();
            toolTipTask_KGV = new ToolTip(components);
            buttonFolder_KGV = new Button();
            buttonCalculate_KGV = new Button();
            buttonAbout_KGV = new Button();
            textBoxTask_KGV = new TextBox();
            groupBoxInput_KGV = new GroupBox();
            textBoxFromFile_KGV = new TextBox();
            groupBoxOutput_KGV = new GroupBox();
            textBoxOutput_KGV = new TextBox();
            groupBoxInput_KGV.SuspendLayout();
            groupBoxOutput_KGV.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogTask_KGV
            // 
            openFileDialogTask_KGV.FileName = "openFileDialogTask_KGV";
            // 
            // toolTipTask_KGV
            // 
            toolTipTask_KGV.ToolTipTitle = "Подсказка";
            // 
            // buttonFolder_KGV
            // 
            buttonFolder_KGV.BackColor = SystemColors.Menu;
            buttonFolder_KGV.BackgroundImage = Properties.Resources.FGolder;
            buttonFolder_KGV.BackgroundImageLayout = ImageLayout.Center;
            buttonFolder_KGV.Location = new Point(12, 12);
            buttonFolder_KGV.Name = "buttonFolder_KGV";
            buttonFolder_KGV.Size = new Size(75, 75);
            buttonFolder_KGV.TabIndex = 0;
            toolTipTask_KGV.SetToolTip(buttonFolder_KGV, "Открыть файл");
            buttonFolder_KGV.UseVisualStyleBackColor = false;
            buttonFolder_KGV.Click += buttonOpenFile_Click;
            // 
            // buttonCalculate_KGV
            // 
            buttonCalculate_KGV.BackColor = SystemColors.Menu;
            buttonCalculate_KGV.BackgroundImage = Properties.Resources.docum;
            buttonCalculate_KGV.BackgroundImageLayout = ImageLayout.Center;
            buttonCalculate_KGV.Enabled = false;
            buttonCalculate_KGV.Location = new Point(93, 12);
            buttonCalculate_KGV.Name = "buttonCalculate_KGV";
            buttonCalculate_KGV.Size = new Size(75, 75);
            buttonCalculate_KGV.TabIndex = 1;
            toolTipTask_KGV.SetToolTip(buttonCalculate_KGV, "Выполнить");
            buttonCalculate_KGV.UseVisualStyleBackColor = false;
            buttonCalculate_KGV.Click += buttonDone_Click;
            // 
            // buttonAbout_KGV
            // 
            buttonAbout_KGV.BackColor = SystemColors.Menu;
            buttonAbout_KGV.BackgroundImage = Properties.Resources.HelpSmall;
            buttonAbout_KGV.BackgroundImageLayout = ImageLayout.Center;
            buttonAbout_KGV.Location = new Point(713, 12);
            buttonAbout_KGV.Name = "buttonAbout_KGV";
            buttonAbout_KGV.Size = new Size(75, 75);
            buttonAbout_KGV.TabIndex = 2;
            toolTipTask_KGV.SetToolTip(buttonAbout_KGV, "О программе");
            buttonAbout_KGV.UseVisualStyleBackColor = false;
            buttonAbout_KGV.Click += buttonAboutClick;
            // 
            // textBoxTask_KGV
            // 
            textBoxTask_KGV.Location = new Point(12, 93);
            textBoxTask_KGV.Multiline = true;
            textBoxTask_KGV.Name = "textBoxTask_KGV";
            textBoxTask_KGV.ReadOnly = true;
            textBoxTask_KGV.ShortcutsEnabled = false;
            textBoxTask_KGV.Size = new Size(776, 66);
            textBoxTask_KGV.TabIndex = 3;
            textBoxTask_KGV.Text = resources.GetString("textBoxTask_KGV.Text");
            // 
            // groupBoxInput_KGV
            // 
            groupBoxInput_KGV.Controls.Add(textBoxFromFile_KGV);
            groupBoxInput_KGV.Location = new Point(12, 165);
            groupBoxInput_KGV.Name = "groupBoxInput_KGV";
            groupBoxInput_KGV.Size = new Size(386, 303);
            groupBoxInput_KGV.TabIndex = 4;
            groupBoxInput_KGV.TabStop = false;
            groupBoxInput_KGV.Text = "Из файла";
            // 
            // textBoxFromFile_KGV
            // 
            textBoxFromFile_KGV.Location = new Point(6, 22);
            textBoxFromFile_KGV.Multiline = true;
            textBoxFromFile_KGV.Name = "textBoxFromFile_KGV";
            textBoxFromFile_KGV.ScrollBars = ScrollBars.Both;
            textBoxFromFile_KGV.Size = new Size(374, 275);
            textBoxFromFile_KGV.TabIndex = 0;
            // 
            // groupBoxOutput_KGV
            // 
            groupBoxOutput_KGV.Controls.Add(textBoxOutput_KGV);
            groupBoxOutput_KGV.Location = new Point(404, 165);
            groupBoxOutput_KGV.Name = "groupBoxOutput_KGV";
            groupBoxOutput_KGV.Size = new Size(384, 303);
            groupBoxOutput_KGV.TabIndex = 5;
            groupBoxOutput_KGV.TabStop = false;
            groupBoxOutput_KGV.Text = "Результат";
            // 
            // textBoxOutput_KGV
            // 
            textBoxOutput_KGV.Location = new Point(6, 22);
            textBoxOutput_KGV.Multiline = true;
            textBoxOutput_KGV.Name = "textBoxOutput_KGV";
            textBoxOutput_KGV.Size = new Size(372, 275);
            textBoxOutput_KGV.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(groupBoxOutput_KGV);
            Controls.Add(groupBoxInput_KGV);
            Controls.Add(textBoxTask_KGV);
            Controls.Add(buttonAbout_KGV);
            Controls.Add(buttonCalculate_KGV);
            Controls.Add(buttonFolder_KGV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 11 | Крук Г.В.";
            groupBoxInput_KGV.ResumeLayout(false);
            groupBoxInput_KGV.PerformLayout();
            groupBoxOutput_KGV.ResumeLayout(false);
            groupBoxOutput_KGV.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialogTask_KGV;
        private ToolTip toolTipTask_KGV;
        private Button buttonFolder_KGV;
        private Button buttonCalculate_KGV;
        private Button buttonAbout_KGV;
        private TextBox textBoxTask_KGV;
        private GroupBox groupBoxInput_KGV;
        private GroupBox groupBoxOutput_KGV;
        private TextBox textBoxFromFile_KGV;
        private TextBox textBoxOutput_KGV;
    }
}

namespace Tyuiu.KrukGV.Sprint6.Task7.V5
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
            saveFileDialogTask_KGV = new SaveFileDialog();
            toolTipTask_KGV = new ToolTip(components);
            buttonFolder_KGV = new Button();
            buttonCalculate_KGV = new Button();
            buttonSave_KGV = new Button();
            buttonAbout_KGV = new Button();
            textBoxTask_KGV = new TextBox();
            groupBoxInput_KGV = new GroupBox();
            dataGridViewIn_KGV = new DataGridView();
            groupBoxOutput_KGV = new GroupBox();
            dataGridViewOut_KGV = new DataGridView();
            groupBoxInput_KGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KGV).BeginInit();
            groupBoxOutput_KGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KGV).BeginInit();
            SuspendLayout();
            // 
            // openFileDialogTask_KGV
            // 
            openFileDialogTask_KGV.FileName = "InPutFileTask7V5.csv";
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
            // buttonSave_KGV
            // 
            buttonSave_KGV.BackColor = SystemColors.Menu;
            buttonSave_KGV.BackgroundImage = Properties.Resources.SaveFile;
            buttonSave_KGV.BackgroundImageLayout = ImageLayout.Center;
            buttonSave_KGV.Enabled = false;
            buttonSave_KGV.Location = new Point(174, 12);
            buttonSave_KGV.Name = "buttonSave_KGV";
            buttonSave_KGV.Size = new Size(75, 75);
            buttonSave_KGV.TabIndex = 2;
            toolTipTask_KGV.SetToolTip(buttonSave_KGV, "Сохранить результат в файл");
            buttonSave_KGV.UseVisualStyleBackColor = false;
            buttonSave_KGV.Click += buttonSave_Click;
            // 
            // buttonAbout_KGV
            // 
            buttonAbout_KGV.BackColor = SystemColors.Menu;
            buttonAbout_KGV.BackgroundImage = Properties.Resources.HelpSmall;
            buttonAbout_KGV.BackgroundImageLayout = ImageLayout.Center;
            buttonAbout_KGV.Location = new Point(813, 12);
            buttonAbout_KGV.Name = "buttonAbout_KGV";
            buttonAbout_KGV.Size = new Size(75, 75);
            buttonAbout_KGV.TabIndex = 3;
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
            textBoxTask_KGV.Size = new Size(876, 66);
            textBoxTask_KGV.TabIndex = 4;
            textBoxTask_KGV.Text = resources.GetString("textBoxTask_KGV.Text");
            // 
            // groupBoxInput_KGV
            // 
            groupBoxInput_KGV.Controls.Add(dataGridViewIn_KGV);
            groupBoxInput_KGV.Location = new Point(12, 165);
            groupBoxInput_KGV.Name = "groupBoxInput_KGV";
            groupBoxInput_KGV.Size = new Size(436, 343);
            groupBoxInput_KGV.TabIndex = 5;
            groupBoxInput_KGV.TabStop = false;
            groupBoxInput_KGV.Text = "Из файла";
            // 
            // dataGridViewIn_KGV
            // 
            dataGridViewIn_KGV.AllowUserToAddRows = false;
            dataGridViewIn_KGV.AllowUserToDeleteRows = false;
            dataGridViewIn_KGV.AllowUserToResizeColumns = false;
            dataGridViewIn_KGV.AllowUserToResizeRows = false;
            dataGridViewIn_KGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_KGV.Location = new Point(6, 22);
            dataGridViewIn_KGV.Name = "dataGridViewIn_KGV";
            dataGridViewIn_KGV.ReadOnly = true;
            dataGridViewIn_KGV.RowHeadersWidth = 55;
            dataGridViewIn_KGV.Size = new Size(424, 315);
            dataGridViewIn_KGV.TabIndex = 0;
            // 
            // groupBoxOutput_KGV
            // 
            groupBoxOutput_KGV.Controls.Add(dataGridViewOut_KGV);
            groupBoxOutput_KGV.Location = new Point(452, 165);
            groupBoxOutput_KGV.Name = "groupBoxOutput_KGV";
            groupBoxOutput_KGV.Size = new Size(436, 343);
            groupBoxOutput_KGV.TabIndex = 6;
            groupBoxOutput_KGV.TabStop = false;
            groupBoxOutput_KGV.Text = "Результат";
            // 
            // dataGridViewOut_KGV
            // 
            dataGridViewOut_KGV.AllowUserToAddRows = false;
            dataGridViewOut_KGV.AllowUserToDeleteRows = false;
            dataGridViewOut_KGV.AllowUserToResizeColumns = false;
            dataGridViewOut_KGV.AllowUserToResizeRows = false;
            dataGridViewOut_KGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_KGV.Location = new Point(6, 22);
            dataGridViewOut_KGV.Name = "dataGridViewOut_KGV";
            dataGridViewOut_KGV.ReadOnly = true;
            dataGridViewOut_KGV.RowHeadersWidth = 55;
            dataGridViewOut_KGV.Size = new Size(424, 315);
            dataGridViewOut_KGV.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 520);
            Controls.Add(groupBoxOutput_KGV);
            Controls.Add(groupBoxInput_KGV);
            Controls.Add(textBoxTask_KGV);
            Controls.Add(buttonAbout_KGV);
            Controls.Add(buttonSave_KGV);
            Controls.Add(buttonCalculate_KGV);
            Controls.Add(buttonFolder_KGV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 5 | Крук Г.В.";
            groupBoxInput_KGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KGV).EndInit();
            groupBoxOutput_KGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialogTask_KGV;
        private SaveFileDialog saveFileDialogTask_KGV;
        private ToolTip toolTipTask_KGV;
        private Button buttonFolder_KGV;
        private Button buttonCalculate_KGV;
        private Button buttonSave_KGV;
        private Button buttonAbout_KGV;
        private TextBox textBoxTask_KGV;
        private GroupBox groupBoxInput_KGV;
        private GroupBox groupBoxOutput_KGV;
        private DataGridView dataGridViewIn_KGV;
        private DataGridView dataGridViewOut_KGV;
    }
}

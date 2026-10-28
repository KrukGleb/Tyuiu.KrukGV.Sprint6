namespace Tyuiu.KrukGV.Sprint6.Task6.V11
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxYa__KGV = new PictureBox();
            textBoxAbout_KGV = new TextBox();
            buttonClose_KGV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYa__KGV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxYa__KGV
            // 
            pictureBoxYa__KGV.Image = Properties.Resources.Ya;
            pictureBoxYa__KGV.Location = new Point(12, 12);
            pictureBoxYa__KGV.Name = "pictureBoxYa__KGV";
            pictureBoxYa__KGV.Size = new Size(563, 653);
            pictureBoxYa__KGV.TabIndex = 0;
            pictureBoxYa__KGV.TabStop = false;
            // 
            // textBoxAbout_KGV
            // 
            textBoxAbout_KGV.Font = new Font("Segoe UI", 16F);
            textBoxAbout_KGV.HideSelection = false;
            textBoxAbout_KGV.Location = new Point(581, 12);
            textBoxAbout_KGV.Multiline = true;
            textBoxAbout_KGV.Name = "textBoxAbout_KGV";
            textBoxAbout_KGV.ReadOnly = true;
            textBoxAbout_KGV.Size = new Size(379, 624);
            textBoxAbout_KGV.TabIndex = 1;
            textBoxAbout_KGV.TabStop = false;
            textBoxAbout_KGV.Text = resources.GetString("textBoxAbout_KGV.Text");
            // 
            // buttonClose_KGV
            // 
            buttonClose_KGV.Location = new Point(885, 642);
            buttonClose_KGV.Name = "buttonClose_KGV";
            buttonClose_KGV.Size = new Size(75, 23);
            buttonClose_KGV.TabIndex = 2;
            buttonClose_KGV.Text = "Ок";
            buttonClose_KGV.UseVisualStyleBackColor = true;
            buttonClose_KGV.Click += ClickClose;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 679);
            Controls.Add(buttonClose_KGV);
            Controls.Add(textBoxAbout_KGV);
            Controls.Add(pictureBoxYa__KGV);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxYa__KGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxYa__KGV;
        private TextBox textBoxAbout_KGV;
        private Button buttonClose_KGV;
    }
}
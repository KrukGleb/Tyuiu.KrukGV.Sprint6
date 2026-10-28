using Tyuiu.KrukGV.Sprint6.Task6.V11.Lib;

namespace Tyuiu.KrukGV.Sprint6.Task6.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(openFileDialogTask_KGV.FileName);
            textBoxOutput_KGV.Text = res;
            return;
        }

        private void buttonAboutClick(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.Show();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KGV.ShowDialog();
            string openFilePath = openFileDialogTask_KGV.FileName;

            string content = File.ReadAllText(openFilePath);
            content = content.Replace("\r\n", "\n").Replace("\n", Environment.NewLine);

            textBoxFromFile_KGV.Text = content;
            groupBoxInput_KGV.Text = "¬вод: " + openFileDialogTask_KGV.FileName;
            buttonCalculate_KGV.Enabled = true;
        }

        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '-') || e.KeyChar == 8))
                e.Handled = true;
        }
    }
}

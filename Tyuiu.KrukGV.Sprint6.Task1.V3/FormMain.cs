using Tyuiu.KrukGV.Sprint6.Task1.V3.Lib;

namespace Tyuiu.KrukGV.Sprint6.Task1.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KGV.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_KGV.Text);

                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxOutput_KGV.Text = "";
                textBoxOutput_KGV.AppendText("+---------------------+" + Environment.NewLine);
                textBoxOutput_KGV.AppendText("|    X\t|   f(x)\t|" + Environment.NewLine);
                textBoxOutput_KGV.AppendText("+---------------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}\t|  {1, 5:f2}\t|", startStep, valueArray[i]);
                    textBoxOutput_KGV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Неверно введены значения", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void buttonAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1, вариант 3 выполнил студент группы НТм-25-1 Крук Глеб Владиславович", "О программе", MessageBoxButtons.OK);
        }



        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '-') || e.KeyChar == 8))
                e.Handled = true;
        }
    }
}

using Tyuiu.KrukGV.Sprint6.Task4.V26.Lib;

namespace Tyuiu.KrukGV.Sprint6.Task4.V26
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
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                int len = valueArray.Length;

                textBoxOutput_KGV.Text = "";
                textBoxOutput_KGV.AppendText("+---------------------+" + Environment.NewLine);
                textBoxOutput_KGV.AppendText("|    X\t|   f(x)\t|" + Environment.NewLine);
                textBoxOutput_KGV.AppendText("+---------------------+" + Environment.NewLine);

                chartFunction_KGV.Series[0].Points.Clear();

                chartFunction_KGV.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chartFunction_KGV.Series[0].BorderWidth = 3;
                chartFunction_KGV.Titles.Add("График f(x)");

                chartFunction_KGV.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_KGV.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}\t|  {1, 5:f2}\t|", startStep, valueArray[i]);
                    textBoxOutput_KGV.AppendText(strLine + Environment.NewLine);
                    chartFunction_KGV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Неверно введены значения", "Ошибка", MessageBoxButtons.OK);
            }

    
        }

        private void buttonSaveCLick(object sender, EventArgs e)
        {
            try
            {
                string tempDir = Path.GetTempPath();
                string path = Path.Combine(tempDir, "OutPutFileTask4V26.txt");

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;

                if (fileExists)
                    File.Delete(path);

                File.WriteAllText(path, textBoxOutput_KGV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        private void buttonAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3, вариант 19 выполнил студент группы НТм-25-1 Крук Глеб Владиславович", "О программе", MessageBoxButtons.OK);
        }



        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '-') || e.KeyChar == 8))
                e.Handled = true;
        }
    }
}

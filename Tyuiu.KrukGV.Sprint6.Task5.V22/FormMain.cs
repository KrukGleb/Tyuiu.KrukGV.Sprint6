using Tyuiu.KrukGV.Sprint6.Task5.V22.Lib;
namespace Tyuiu.KrukGV.Sprint6.Task5.V22
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
                string Dir = "C:\\DataSprint6";
                string path = Path.Combine(Dir, "InPutDataFileTask5V22.txt");
                double[] valueArray = ds.LoadFromDataFile(path);

                int len = valueArray.Length;

                dataGridViewOutput_KGV.Columns.Clear();
                dataGridViewOutput_KGV.Rows.Clear();

                dataGridViewOutput_KGV.ColumnCount = 2;
                dataGridViewOutput_KGV.Columns[0].Name = "X";
                dataGridViewOutput_KGV.Columns[1].Name = "f(x)";

                
                for (var i = 0; i < len; i++)
                    dataGridViewOutput_KGV.Rows.Add(i+1, valueArray[i]);

                chartFunction_KGV.Series[0].Points.Clear();

                chartFunction_KGV.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_KGV.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                    chartFunction_KGV.Series[0].Points.AddXY(i + 1, valueArray[i]);

            }
            catch
            {
                MessageBox.Show("Нет файла", "Ошибка", MessageBoxButtons.OK);
            }


        }

        private void buttonOpenCLick(object sender, EventArgs e)
        {
            try
            {
                string Dir = "C:\\DataSprint6";
                string path = Path.Combine(Dir, "InPutDataFileTask5V22.txt");

                FileInfo fileInfo = new FileInfo(path);

                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
                
            }
            catch
            {
                MessageBox.Show("Сбой при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void buttonAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5, вариант 22 выполнил студент группы НТм-25-1 Крук Глеб Владиславович", "О программе", MessageBoxButtons.OK);
        }



        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '-') || e.KeyChar == 8))
                e.Handled = true;
        }
    }
}

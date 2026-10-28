using Tyuiu.KrukGV.Sprint6.Task2.V15.Lib;

namespace Tyuiu.KrukGV.Sprint6.Task2.V15
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

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);
                int len = valueArray.Length;
                
                dataGridViewOutput_KGV.Columns.Clear();
                dataGridViewOutput_KGV.Rows.Clear();

                dataGridViewOutput_KGV.ColumnCount = 2;
                dataGridViewOutput_KGV.Columns[0].Name = "X";
                dataGridViewOutput_KGV.Columns[1].Name = "f(x)";

                double[] arr = Enumerable.Range(startStep, stopStep - startStep + 1).Select(x => (double)x).ToArray();

                for (var i = 0; i < len; i++)
                    dataGridViewOutput_KGV.Rows.Add(arr[i], valueArray[i]);

            }
            catch
            {
                MessageBox.Show("Неверно введены значения", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void buttonAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2, вариант 15 выполнил студент группы НТм-25-1 Крук Глеб Владиславович", "О программе", MessageBoxButtons.OK);
        }



        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '-') || e.KeyChar == 8))
                e.Handled = true;
        }

    }
}

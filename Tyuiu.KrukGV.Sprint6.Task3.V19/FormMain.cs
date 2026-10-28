using System.Drawing.Drawing2D;
using Tyuiu.KrukGV.Sprint6.Task3.V19.Lib;

namespace Tyuiu.KrukGV.Sprint6.Task3.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {

            int[,] inputMatrix = new int[5, 5]
            {
                { 4, 32, -20, 27, 21 },
                { 17, 15, -1, -2, -1 },
                { -3, 18, 12, -10, 29 },
                { 7, -15, 2, -8, 12 },
                { -10, 25, 5, 27, 21 }
            };

            int[,] valueArray = ds.Calculate(inputMatrix);
            int rowsCount = valueArray.GetLength(0);
            int colsCount = valueArray.GetLength(1);

            dataGridViewOutput_KGV.Columns.Clear();
            dataGridViewOutput_KGV.Rows.Clear();

            dataGridViewOutput_KGV.ColumnCount = colsCount;

            object[] temp = new object[colsCount];
            for (var i = 0; i < rowsCount; i++)
            {
                for (var j = 0; j < colsCount; j++)
                    temp[j] = valueArray[i, j];
                dataGridViewOutput_KGV.Rows.Add(temp);
            }

            dataGridViewOutput_KGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

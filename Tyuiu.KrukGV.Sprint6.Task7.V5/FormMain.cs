using System.Text;
using Tyuiu.KrukGV.Sprint6.Task7.V5.Lib;

namespace Tyuiu.KrukGV.Sprint6.Task7.V5
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_KGV.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialogTask_KGV.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialogTask_KGV.FileName = "OutPutFileTask7.csv";
        }

        private static void FillGrid(DataGridView grid, int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.ColumnCount = columns;

            for (int j = 0; j < columns; j++)
            {
                grid.Columns[j].Width = 45;
                grid.Columns[j].HeaderText = (j + 1).ToString();
            }

            grid.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    grid[j, i].Value = matrix[i, j];

                grid.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask_KGV.ShowDialog() != DialogResult.OK) 
                return;

            try
            {
                int[,] matrix = ds.LoadMatrix1(openFileDialogTask_KGV.FileName);
                FillGrid(dataGridViewIn_KGV, matrix);

                dataGridViewOut_KGV.Rows.Clear();
                dataGridViewOut_KGV.Columns.Clear();

                groupBoxInput_KGV.Text = "Файл: " + openFileDialogTask_KGV.FileName;
                buttonCalculate_KGV.Enabled = true;
                buttonSave_KGV.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось прочитать файл:\n" + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] arrayValues = ds.GetMatrix(openFileDialogTask_KGV.FileName);

                FillGrid(dataGridViewOut_KGV, arrayValues);
                
                buttonSave_KGV.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обработке файла:\n" + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFileDialogTask_KGV.FileName);
            if (arrayValues == null) 
                return;
            if (saveFileDialogTask_KGV.ShowDialog() != DialogResult.OK) 
                return;

            try
            {
                int rows = arrayValues.GetLength(0);
                int columns = arrayValues.GetLength(1);
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        sb.Append(arrayValues[i, j]);
                        if (j != columns - 1) sb.Append(';');
                    }
                    sb.Append(Environment.NewLine);
                }

                File.WriteAllText(saveFileDialogTask_KGV.FileName, sb.ToString());
                MessageBox.Show("Файл сохранён:\n" + saveFileDialogTask_KGV.FileName, "Готово",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить файл:\n" + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAboutClick(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.Show();
        }
    }
}

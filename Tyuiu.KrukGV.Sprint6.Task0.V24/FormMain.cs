using Tyuiu.KrukGV.Sprint6.Task0.V24.Lib;
using System;
using System.Windows.Forms;

namespace Tyuiu.KrukGV.Sprint6.Task0.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0, вариант 24 выполнил студент группы НТм-25-1 Крук Глеб Владиславович", "О программе", MessageBoxButtons.OK);
        }


        private void buttonCalculateClick(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutputResult_KGV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInputX_KGV.Text)));
            }
            catch
            {
                MessageBox.Show("Введите число", "Ошибка", MessageBoxButtons.OK);
            }
        }
        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
            {
                e.Handled = true;
            }

        }
    }
}

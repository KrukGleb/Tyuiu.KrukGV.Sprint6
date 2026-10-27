
using Tyuiu.KrukGV.Sprint6.Task0.V24.Lib;

namespace Tyuiu.KrukGV.Sprint6.Task0.V24
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }


    }
}
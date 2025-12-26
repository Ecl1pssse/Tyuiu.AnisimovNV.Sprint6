using System;
using System.Windows.Forms;

namespace Tyuiu.AnisimovNV.Sprint6.Task3.V7
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}

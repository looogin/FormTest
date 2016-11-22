using System;
using System.Windows.Forms;
using System.Drawing;

namespace EmptyProject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 fr1 = new Form1();
            fr1.Size = new Size(300,300);
            fr1.Text = "Test";

            Application.EnableVisualStyles();
            Application.Run(fr1);
        }
    }


}

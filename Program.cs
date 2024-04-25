using System;
using System.Windows.Forms;

namespace Traffic_competition
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Formstart formstart = new Formstart();
            if (formstart.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Formmain());
            }
        }
    }
}

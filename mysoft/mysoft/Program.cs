using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysoft
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        public static string st_connect = @"Data Source=DESKTOP-8T9LE52\SQLEXPRESS;Initial Catalog=workers1;Integrated Security=True";

        public static int id_admin = -1;

        public static int id = -1;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

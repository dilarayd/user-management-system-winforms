using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagementSystemWinforms
{
    public static class KullaniciVeri
    {
        public static string KullaniciAdi { get; set; }
        public static string KullaniciMail { get; set; }
        public static string KullaniciSifre { get; set; }
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

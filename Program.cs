using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms;

namespace ders9_NTie_Desing_Katmanli_Mimari_calisma
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.frm_menu ());
        }
    }
}

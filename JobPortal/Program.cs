using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                new DataAccess();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            new Delegates();
            Application.Run(new HomeForm());
        }
    }
}

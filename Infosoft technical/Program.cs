using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Infosoft_technical
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PlutoContext context = new PlutoContext();
            context.Customers.ToList();
            UnitOfWork unitOfWork = new UnitOfWork(context);
            Application.Run(new MainForm(unitOfWork));

        }
    }
}

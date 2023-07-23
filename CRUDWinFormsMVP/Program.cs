using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDWinFormsMVP.Views;
using CRUDWinFormsMVP.Presenters;
using CRUDWinFormsMVP.Repository;
using CRUDWinFormsMVP.Models;
using System.Configuration;

namespace CRUDWinFormsMVP
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["PetConnectionString"].ConnectionString;

            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString);

            Application.Run((Form)view);
        }
    }
}

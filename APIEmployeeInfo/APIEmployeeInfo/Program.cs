using APIEmployeeInfo.App.Models;
using APIEmployeeInfo.App.Presenters;
using APIEmployeeInfo.App.Repositories;
using APIEmployeeInfo.App.Views;
using System;
using System.Windows.Forms;

namespace APIEmployeeInfo
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


            IEmployeeRepository repository = new EmployeeRepository();
            IEmployeeViews view = new EmployeeViews();
            new EmployeePresenter(view, repository);

            Application.Run((Form)view);

        }
    }
}

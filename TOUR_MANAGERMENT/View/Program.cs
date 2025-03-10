using TOUR_MANAGERMENT.DTO_Data_Transfer_Object;
using System;
using System.Windows.Forms;

namespace TOUR_MANAGERMENT.View
    {
    public static class GlobalData
        {
        public static User_DTO CurrentUser { get; set; } 
        }

    public static class Program
        {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
            {
            // Cấu hình ứng dụng
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Report());
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace COS_DesktopApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CanteenOrderingSystemEntities model = new CanteenOrderingSystemEntities();

            account obj = new account();
            obj.birthday = new DateTime(2000, 12, 3);
            obj.email = "thuan@123";
            obj.password = "thuan@1234";
            obj.fullname = "kakaka";
            obj.phonenumber = "0123456789";
            obj.id_role = 1;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DashBroadForm());
        }
    }
}

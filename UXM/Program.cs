using SoulsFormats;
using System;
using System.IO;
using Eto.Forms;
//using System.Windows.Media;

//[assembly: DisableDpiAwareness]
namespace UXM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Properties.Settings settings = Properties.Settings.Default;
                if (settings.UpgradeRequired)
                {
                    //settings.Upgrade();
                    settings.UpgradeRequired = false;
                    //settings.Save();
                }

                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                Eto.Style.Add<Eto.Mac.Forms.ApplicationHandler>(null, h => h.AllowClosingMainForm = true);
#if OS_MAC
                new Application(Eto.Platforms.Mac64).Run(new FormMain());
#elif OS_LINUX
                new Application(Eto.Platforms.Gtk).Run(new FormMain());
#elif OS_WINDOWS
                new Application(Eto.Platforms.WinForms).Run(new FormMain());
#endif

                settings.Save();
            } catch (Exception ex)
            {
                File.WriteAllText("crash_log.log", ex.ToString());
                throw;
            }

        }
    }
}

using System;
using System.Windows.Forms;
using System.Configuration;

namespace CuddCal
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
            Application.Run(new CuddCal());
        }

        /// <summary>
        /// Class to enable changes to app.config at runtime.
        /// Should be used sparingly, for values that are essentially constants only.
        /// </summary>
       
        public static void SetSetting(string key, string value)
        {
            Configuration configuration =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }

}

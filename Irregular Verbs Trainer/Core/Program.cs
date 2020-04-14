using IVT.Forms;
using IVT.Tools;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using IVT.Objects;
using System.Collections.Generic;
using System.Configuration;

namespace IVT.Core
{
    internal static class Program
    {

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        private static void Main(string[] entryArgs)
        {
            try
            {
                //0.LOAD DLLS
                AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
                {
                    string resourceName = new AssemblyName(args.Name).Name + ".dll";
                    string resource = Array.Find(Assembly.GetExecutingAssembly().GetManifestResourceNames(), element => element.EndsWith(resourceName));

                    using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                    {
                        Byte[] assemblyData = new Byte[stream.Length];
                        stream.Read(assemblyData, 0, assemblyData.Length);
                        return Assembly.Load(assemblyData);
                    }
                };

                if (entryArgs.Contains("-updated"))
                {
                    MessageBox.Show("Irregular Verbs Trainer was successfully updated to version " + Application.ProductVersion.ToString() + ".",
                        "Irregular Verbs Trainer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (String.IsNullOrWhiteSpace(Properties.Settings.Default.historical) | String.IsNullOrEmpty(Properties.Settings.Default.historical))
                {
                    HistoryManager.ClearTrainingHistoryList();
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new TrainerForm());
            }
            catch (Exception ex)
            {
                RunExceptionMessageHandler(ex);
            }
        }

        private static void RunExceptionMessageHandler(Exception ex)
        {
            MExceptionReporter.ReportException reportException = new MExceptionReporter.ReportException(Application.ProductName, ex);
            reportException.ShowDialog();
            return;
        }
    }
}
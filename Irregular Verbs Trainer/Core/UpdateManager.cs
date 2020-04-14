using MUpdate;
using MUpdate.Events;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace IVT.Core
{
    public class UpdateManager : IMUpdatable, IDisposable
    {
        #region "MUpdate"

        /// <summary>
        /// Returns the executing assembly.
        /// </summary>
        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        /// <summary>
        /// Returns the Application Icon.
        /// </summary>
        public Icon ApplicationIcon
        {
            get { return Properties.Resources.studentIco; }
        }

        /// <summary>
        /// Returns the Application ID.
        /// </summary>
        public string ApplicationID
        {
            get { return "IVT"; }
        }

        /// <summary>
        /// Returns the Application Name.
        /// </summary>
        public string ApplicationName
        {
            get { return "Irregular Verbs Trainer"; }
        }

        /// <summary>
        /// Returns the context.
        /// </summary>
        public Form Context
        {
            get { return null; }
        }

        /// <summary>
        /// Returns language
        /// </summary>
        public string Language
        {
            get { return "en"; }
        }

        /// <summary>
        /// Returns Uri location of the update.xml file.
        /// </summary>
        public Uri UpdateXmlLocation
        {
            get { return new Uri("https://dl.dropbox.com/s/ug3amjagujgqiul/update.xml?dl=0"); }
        }

        #endregion "MUpdate"

        private bool disposed = false;
        private MUpdater update;

        public UpdateManager()
        {
            update = new MUpdater(this);
            MUpdateEventBridge.AsyncUpdateFinished += MUpdateEventBridge_AsyncUpdateFinished;
        }

        public bool SilentMode { get; set; } = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void DoUpdateAsync()
        {
            update.DoUpdateAsync();
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
                update.Dispose();
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        private void MUpdateEventBridge_AsyncUpdateFinished(object sender, EventArgs e)
        {
            AsyncUpdateFinishedEventArgs args = (AsyncUpdateFinishedEventArgs)e;

            if (!args.Successful && args.Ex != null && !SilentMode)
            {
                MessageBox.Show("An error occured while looking for updates.\r\nDetails: " + args.Ex.Message, Application.ProductName + " - Update check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
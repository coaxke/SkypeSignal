using System;
using System.Windows.Forms;
using SkypeSignal.Properties;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkypeSignal
{
    class ProcessIcon : IDisposable
    {
        /// <summary>
        /// Notify Icon Object
        /// </summary>
        readonly NotifyIcon ni;

        public ProcessIcon()
        {
            //Instantiate the NotifyIcon Object
            ni = new NotifyIcon();
        }


        public void DisplayIcon()
        {
            //Put the icon in the System try and allow it to react to mouse-clicks:
            //ni.MouseClick += new MouseEventHandler(ni_MouseClick);
            ni.Icon = Resources.ResdevOpsSkypeSignal_Icon;
            ni.Text = "SkypeSignal Light Notification";
            ni.Visible = true;

            //Attach the context menu
            ni.ContextMenuStrip = new ContextMenus().Create();
        }


        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        public void Dispose()
        {
            // When the application closes, this will remove the icon from the system tray immediately.
            ni.Dispose();
        }

        /// <summary>
        /// Handles the MouseClick event of the ni control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        void ni_MouseClick (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Do something when single clicking on the Icon
            }
        }

    }
}

using System;
using System.Windows.Forms;


namespace SkypeSignal
{
    class ContextMenus
    {

        /// <summary>
        /// Is the About box displayed?
        /// </summary>
        bool _isAboutLoaded;

        /// <summary>
        /// Is the Flash firmware dialogue box loaded?
        /// </summary>
        private bool _isFlashFirmwareLoaded;

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>ContextMenuStrip</returns>
        public ContextMenuStrip Create()
        {
            // Add the default menu options.
            ContextMenuStrip menu = new ContextMenuStrip();

            //About
            var item = new ToolStripMenuItem {Text = "About"};
            item.Click += About_Click;
            menu.Items.Add(item);

            // Separator.
            var sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            //Flash SkypeSignal
            item = new ToolStripMenuItem {Text = "Flash SkypeSignal Firmware"};
            item.Click += FlashFirmware_Click;
            menu.Items.Add(item);

            // Separator.
            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            //Exit
            item = new ToolStripMenuItem {Text = "Exit"};
            item.Click += Exit_Click;
            menu.Items.Add(item);

            return menu;
        }

        /// <summary>
        /// Handles the Click event of the About control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void About_Click(object sender, EventArgs e)
        {
            if (!_isAboutLoaded)
            {
                _isAboutLoaded = true;
                new AboutForm().ShowDialog();
                _isAboutLoaded = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the Flash SkypeSignal Firmware control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FlashFirmware_Click(object sender, EventArgs e)
        {
            if (!_isFlashFirmwareLoaded)
            {
                _isFlashFirmwareLoaded = true;
                //new FlashFirmware().ShowDialog();
                MessageBox.Show("Feature coming soon...", "Sorry", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
                _isFlashFirmwareLoaded = false;
            }
        }

        /// <summary>
        /// Processes a menu item.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Exit_Click(object sender, EventArgs e)
        {
            // Quit without further ado.
            Environment.Exit(0);
        }
    }
}

using System;
using System.Windows.Forms;
using System.Threading;

namespace SkypeSignal
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

            //I've found that my Arduino hangs on the very first connection to work around that
            //kick-off connection to Light before we start and send a non-event code:
            SerialSender serialSender = new SerialSender();
            serialSender.SendSerialData("0");


            SkypeStatusInfo skypeStatus = new SkypeStatusInfo();
           // ProcessIcon pi = new ProcessIcon();

            Thread skypeStatusMonitor = new Thread(new ThreadStart(skypeStatus.StatusSetup));


            skypeStatusMonitor.Start();  
            
            //Show the System Tray Icon
            using (ProcessIcon pi = new ProcessIcon())
            {
                pi.DisplayIcon();

                //Make Sure the Application Runs
                Application.Run();
            }           
        }
    }
}

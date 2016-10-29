using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;


namespace SkypeSignal
{
    public partial class AboutForm : Form
    {

        public AboutForm()
        {
            InitializeComponent();
            lbl_ProductName.Text    = AssemblyProductName;
            lbl_Version.Text        = string.Format("Version {0}", AssemblyVersion);
            tb_Description.Text     = AssemblyDescription;
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btn_PartyTime_Click(object sender, EventArgs e)
        {
            SkypeStatusInfo statusInfo = new SkypeStatusInfo();

            statusInfo.PartyDown();

        }



        //Non-Generated Code:

        private void llbl_ResdevOps_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.resdevops.com");
        }


        private string AssemblyProductName
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        private string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

    }
}

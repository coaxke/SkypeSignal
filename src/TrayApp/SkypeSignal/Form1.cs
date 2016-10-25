using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Lync.Controls;
using Microsoft.Lync.Model;


namespace SkypeSignal
{
    public partial class Form1 : Form
    {

        LyncClient lyncClient;

        public Form1()
        {
            InitializeComponent();
                     


            try
            {
                var lyncClient = LyncClient.GetClient();
                label1.Text = lyncClient.Self.Contact.GetContactInformation(ContactInformationType.ActivityId).ToString();
            }
            catch (ClientNotFoundException clientNotFoundException)
            {
                Console.WriteLine(clientNotFoundException);
                return;
            }
            catch (NotStartedByUserException notStartedByUserException)
            {
                Console.Out.WriteLine(notStartedByUserException);
                return;
            }
            catch (LyncClientException lyncClientException)
            {
                Console.Out.WriteLine(lyncClientException);
                return;
            }
            catch (SystemException systemException)
            {
                // Rethrow the SystemException which did not come from the Lync Model API.
                throw;
            }




            //lyncClient.StateChanged += new EventHandler<ClientStateChangedEventArgs>(Client_StateChanged);
           // label1.Text = lyncClient.Self.Contact.GetContactInformation(ContactInformationType.ActivityId).ToString();









        }

        private void Client_StateChanged(object sender, ClientStateChangedEventArgs e)
        {

        }
    }
}

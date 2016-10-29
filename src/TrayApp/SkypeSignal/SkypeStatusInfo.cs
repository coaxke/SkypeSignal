using System;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using Microsoft.Lync.Model;

namespace SkypeSignal
{
    class SkypeStatusInfo
    {
        SerialSender _serialSender = new SerialSender();
        System.Timers.Timer _partyTimer = new System.Timers.Timer();

        LyncClient _lyncClient;

        public SkypeStatusInfo()
        {
            _partyTimer.Enabled = true;
            _partyTimer.Interval = 20000;
            _partyTimer.AutoReset = false;
            _partyTimer.Elapsed += new ElapsedEventHandler(PartyTimerElapesed);
        }

        public void StatusSetup()
        {
            while (_lyncClient == null)
            {
                try
                {
                    _lyncClient = LyncClient.GetClient();
                }
                catch (Exception)
                {                    
                    MessageBox.Show("Cannot find a lync client - Quitting", "Lync Client Process Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Quit - We cant do anything.
                    Environment.Exit(1);
                }

                if (_lyncClient != null && _lyncClient.State == ClientState.SignedIn)
                {
                    ///This is bogus, its just for testing, don't hate
                    while (true)
                    {
                        _lyncClient.Self.Contact.ContactInformationChanged -= new EventHandler<ContactInformationChangedEventArgs>(ContactChangeStatusUpdate);
                        _lyncClient.Self.Contact.ContactInformationChanged += new EventHandler<ContactInformationChangedEventArgs>(ContactChangeStatusUpdate);


                        Thread.Sleep(2000);
                    }
                }
            }
        }

        public void ContactChangeStatusUpdate(object sender, ContactInformationChangedEventArgs e)
        {
            if (e.ChangedContactInformation.Contains(ContactInformationType.ActivityId))
            {
                SetLyncStatus();
            }
        }

        public void SetLyncStatus()
        {
            _lyncClient = LyncClient.GetClient();

            //TODO Remove Echo from App on Arduino
            if (_lyncClient != null && _lyncClient.State == ClientState.SignedIn)
            {
                var Status = _lyncClient.Self.Contact.GetContactInformation(ContactInformationType.ActivityId).ToString();

                switch (Status)
                {
                    case "Free":
                        _serialSender.SendSerialData("1");
                        break;
                    case "in-a-meeting":
                    case "Busy":
                        _serialSender.SendSerialData("2");
                        break;
                    case "DoNotDisturb":
                    case "out-of-office":
                    case "urgent-interruptions-only":
                    case "presenting":
                        _serialSender.SendSerialData("3");
                        break;
                    case "Away":
                    case "BeRightBack":
                    case "off-work":
                    case "Inactive":
                        _serialSender.SendSerialData("4");
                        break;
                    case "on-the-phone":
                    case "in-a-conference":
                        _serialSender.SendSerialData("5");
                        break;
                    default:
                        _serialSender.SendSerialData("0");
                        break;
                }
            }
            else _serialSender.SendSerialData("0");
        }

        public void PartyDown()
        {
            _serialSender.SendSerialData("7");
            _partyTimer.Start();
        }

        private void PartyTimerElapesed(object source, ElapsedEventArgs e)
        {
            //Reset Light to current Lync status by forcing a Check.
            SetLyncStatus();
        }
    }
}

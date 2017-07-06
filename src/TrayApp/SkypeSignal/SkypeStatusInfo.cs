using System;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using Microsoft.Lync.Model;

namespace SkypeSignal
{
    internal class SkypeStatusInfo
    {
        readonly SerialSender _serialSender = new SerialSender();
        private readonly System.Timers.Timer _partyTimer = new System.Timers.Timer();

        LyncClient _lyncClient;

        public SkypeStatusInfo()
        {
            _partyTimer.Enabled = true;
            _partyTimer.Interval = 20000;
            _partyTimer.AutoReset = false;
            _partyTimer.Elapsed += PartyTimerElapesed;
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
                    while (true)
                    {
                        _lyncClient.Self.Contact.ContactInformationChanged -= ContactChangeStatusUpdate;
                        _lyncClient.Self.Contact.ContactInformationChanged += ContactChangeStatusUpdate;


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
                var status = _lyncClient.Self.Contact.GetContactInformation(ContactInformationType.ActivityId).ToString();

                switch (status)
                {
                    case "Free":
                        _serialSender.SendSerialData(ColourStates.Green);
                        break;
                    case "in-a-meeting":
                    case "Busy":
                        _serialSender.SendSerialData(ColourStates.Red);
                        break;
                    case "DoNotDisturb":
                    case "out-of-office":
                    case "urgent-interruptions-only":
                    case "presenting":
                        _serialSender.SendSerialData(ColourStates.Purple);
                        break;
                    case "Away":
                    case "BeRightBack":
                    case "off-work":
                    case "Inactive":
                        _serialSender.SendSerialData(ColourStates.Yellow);
                        break;
                    case "on-the-phone":
                    case "in-a-conference":
                        _serialSender.SendSerialData(ColourStates.RedFade);
                        break;
                    default:
                        _serialSender.SendSerialData(ColourStates.Off);
                        break;
                }
            }
            else _serialSender.SendSerialData(ColourStates.Off);
        }

        public void PartyDown()
        {
            _serialSender.SendSerialData(ColourStates.PartyStrobe);
            _partyTimer.Start();
        }

        private void PartyTimerElapesed(object source, ElapsedEventArgs e)
        {
            //Reset Light to current Lync status by forcing a Check.
            SetLyncStatus();
        }
    }
}

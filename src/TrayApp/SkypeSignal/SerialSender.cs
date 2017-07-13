using System;
using System.IO.Ports;
using System.Configuration;
using System.Windows.Forms;

namespace SkypeSignal
{
    internal class SerialSender
    {
        static SerialPort _serialPort;

        public void SendSerialData(string Command)
        {
            try
            {
                //Create a new SerialPort object with default setttings
                _serialPort = new SerialPort();

                //Set apporpiate Serial Settings
                _serialPort.PortName = ConfigurationManager.AppSettings["SerialPort"];
                _serialPort.BaudRate = getSerialBaudRate();

                //Set the read/write timeouts:
                _serialPort.WriteTimeout = 2500;               

                //Try and open connection the serial device.
                _serialPort.Open();

                using (_serialPort)
                {
                    //Fire the Serial command down to the Arduino
                    _serialPort.WriteLine(Command);
                }
            }
            catch (Exception Ex)
            {
                //We couldnt send a message to the serial device - We'll take the easy way out and show it to the user on screen.
                MessageBox.Show(
                    $"Could not send Skype/Lync status change command to serial device, the error was {Ex.Message} - Application quitting; Investigate and try again",
                    "Error Sending Serial Command",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                Application.Exit();
            }
        }


        private int getSerialBaudRate()
        {
            int baudrate;

            if(!int.TryParse(ConfigurationManager.AppSettings["BaudRate"], out baudrate))
            {
                baudrate = 9600;
            }

            return baudrate;
        }
    }
}

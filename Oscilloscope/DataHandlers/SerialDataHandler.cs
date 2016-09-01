using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oscilloscope.DataHandlers
{
    public class SerialDataHandler : BaseDataHandler
    {
        private SerialPort _serialPort;

        public SerialDataHandler()
        {
            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.
            _serialPort.BaudRate = 250000;
        }

        public override void Open(int port)
        {
            try
            {
                _serialPort.PortName = port.ToString();
                _serialPort.Open();

                base.Open(port);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "ERROR");
            }
        }

        public override void Close()
        {
            _serialPort.Close();
        }

        protected override double ReadData()
        {
            int value = -1;
            int loval;
            int hival;

            hival = _serialPort.ReadByte();

            if ((hival & 0x80) == 0x80)
            { // found hival flag, now read loval
                loval = _serialPort.ReadByte();

                if ((loval & 0x80) == 0)
                { // loval flag = 0, as expected
                    value = ((hival & 0x03) << 8) | ((hival & 0x10) << 3) | loval;
                }

            }

            double lastValue = value * 0.0049;
            if (value < 0)
            {
                return lastValue;
            }

            return value * 0.0049;
        }

    }
}

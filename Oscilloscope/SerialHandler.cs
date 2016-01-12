using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osciloskopas
{
    class SerialHandler
    {
        public bool _continue = false;
        static SerialPort _serialPort;
        static DateTime Jan1st1970;


        static double lastValue;

        public SerialHandler(String com)
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

            // Thread readThread = new Thread(Read);

            Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.
            _serialPort.PortName = com;
            _serialPort.BaudRate = 250000;

            //_serialPort.ReadTimeout = 50;
            //  _serialPort.WriteTimeout = 50;
        }
        public void Open()
        {
            try
            {
                _serialPort.Open();
                _continue = true;
            }
            catch (Exception ex)
            {
                _continue = false;
                MessageBox.Show("Error: " + ex.ToString(), "ERROR");

            }


        }
        public void Close()
        {

            _serialPort.Close();
        }

        public double ReadData()
        {
            long start = Millis(Jan1st1970);

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

            lastValue = value * 0.0049;
            if (value < 0)
            {
                return lastValue;
            }
            return value * 0.0049;

        }
        public static long Millis(DateTime d)
        {
            return (long)((DateTime.UtcNow - Jan1st1970).TotalMilliseconds);
        }

    }
}

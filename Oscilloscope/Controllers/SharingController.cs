using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using Oscilloscope.ChatService;
using System.Threading.Tasks;
using System.Threading;
using System.Web.Script.Serialization;
using Oscilloscope.ServiceHandlers;
using Oscilloscope.Models;

namespace Oscilloscope.Controllers
{
    internal class SharingController
    {
        private JavaScriptSerializer jsonSerializer;

        public string UserName
        {
            get;
            private set;
        }

        public BindingList<ReceivedSample> ReceivedSamples;
        public BindingList<string> UsersConnected;

        ReceiveClient receiveClient = null;

        public SharingController()
        {
            UsersConnected = new BindingList<string>();
            ReceivedSamples = new BindingList<ReceivedSample>();

            Random random = new Random();
            var randomNumber = random.Next(0, 100);
            UserName = Environment.UserName + randomNumber;

            jsonSerializer = new JavaScriptSerializer();

            // Initialize ReceiveClient
            receiveClient = new ReceiveClient();

            receiveClient.NewNames += new GotNames(receiveClient_NewNamesReceived);
            receiveClient.ReceiveMsg += new ReceviedMessage(receiveClient_ReceiveMessage);
        }

        public void Connect()
        {
            receiveClient.Start(UserName);

            //txtMsgs.Text += "Samples received: " + i.ToString() + " from " + sender;
        }

        public void Disconnect()
        {
            receiveClient.Stop(UserName);
        }

        void receiveClient_ReceiveMessage(string sender, string msg)
        {
            //Deserialize from JSON.
            var sample = jsonSerializer.Deserialize(msg, typeof(Sample)) as Sample;
            if (null == sample)
            {
                throw new Exception("Could not deserialize message to Sample");
            }

            var receivedSample = new ReceivedSample(sender, sample);
            ReceivedSamples.Add(receivedSample);
        }

        void receiveClient_NewNamesReceived(object sender, List<string> names)
        {
            UsersConnected.Clear();
            foreach (var name in names)
            {
                UsersConnected.Add(name);
            }
        }

        public void SendMessage(string sendToUsername, Sample sample)
        {
            // Serialize to JSON
            var serializedSample = jsonSerializer.Serialize(sample);

            receiveClient.SendMessage(serializedSample, UserName, sendToUsername);
        }
    }
}

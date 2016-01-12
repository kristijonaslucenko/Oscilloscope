using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Reflection;


namespace Server
{
    public delegate void ListOfNames(List<string> names, object sender);

    [ServiceContract(CallbackContract = typeof(IReceiveChatService))]
    public interface ISendChatService
    {
        [OperationContract(IsOneWay = true)]
        void SendMessage(string msg, string sender, string receiver);
        [OperationContract(IsOneWay = true)]
        void Start(string Name);
        [OperationContract(IsOneWay = true)]
        void Stop(string Name);

    }

    public interface IReceiveChatService
    {
        [OperationContract(IsOneWay = true)]
        void ReceiveMessage(string msg,string receiver);
        [OperationContract(IsOneWay = true)]
        void SendNames(List<string> names);
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ChatService : ISendChatService 
    {
        Dictionary<string, IReceiveChatService> names = new Dictionary<string, IReceiveChatService>();
        
        public static event ListOfNames ChatListOfNames;

        IReceiveChatService callback = null;

        public ChatService() { }

        public void Close()
        {
            callback = null;
            names.Clear();
        }

        public void Start(string Name)
        {
            try
            {
                if (!names.ContainsKey(Name))
                {
                    callback = OperationContext.Current.GetCallbackChannel<IReceiveChatService>();
                    AddUser(Name, callback);
                    SendNamesToAll();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Stop(string Name)
        {
            try
            {
                if (names.ContainsKey(Name))
                {
                    names.Remove(Name);
                    SendNamesToAll();
                 }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void SendNamesToAll()
        {
            foreach (KeyValuePair<string, IReceiveChatService> name in names)
            {
                IReceiveChatService proxy = name.Value;
                proxy.SendNames(names.Keys.ToList());
            }

            if (ChatListOfNames != null)
                ChatListOfNames(names.Keys.ToList(), this);
        }

        void ISendChatService.SendMessage(string msg,string sender, string receiver)
        {
            if (names.ContainsKey(receiver))
            {
                callback = names[receiver];
                callback.ReceiveMessage(msg, sender);
           }
        }

        private void AddUser(string name,IReceiveChatService callback)
        {
            names.Add(name, callback);
            if (ChatListOfNames !=null)
                ChatListOfNames(names.Keys.ToList(), this);
            
        }
    }
}

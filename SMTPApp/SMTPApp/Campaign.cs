using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTPApp
{
    public class Campaign : CampaignBase
    {
        public override void Setup()
        {
            throw new NotImplementedException();
        }
        public override void Finalizer()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, Message> Messages = new Dictionary<string, Message>();
        public Dictionary<string, string> contacts = new Dictionary<string, string>();
    }

    public class Message
    {
        int _sendType;
        public IEnumerable<To> To { get; set; }
        public string From { get; set; }
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }
        public List<string> Attachments { get; set; }
        //Reports??
    }

    public class To
    {
        public string email { get; set; }
        SendTypes type { get; set; }
    }

    public enum SendTypes
    {
        To = 1,
        CC = 2,
        BCC = 3
    }
}

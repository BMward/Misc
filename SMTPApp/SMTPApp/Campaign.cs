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

        public List<string> Contacts { get; set; }
        public List<string> Attachments { get; set; }
        public string Sender { get; set; }
        public List<DateTime> SendTimes { get; set; }

    }
}

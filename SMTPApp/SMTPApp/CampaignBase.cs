using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTPApp
{
    public abstract class CampaignBase
    {
        public abstract void Setup();
        public abstract void Finalizer();
    }
}

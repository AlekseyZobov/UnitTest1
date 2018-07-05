using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Enums
    {
        public enum EnumMasterRoleType
        {
            Admin = 0,
            Manager = 1,
            Advertiser = 2,// obsolete
            Jedi = 3,
            NetworkOperator = 10,
            NetworkAccountManager = 11,
            Agency = 12, //obsolete
            Client = 13,
            Bookkeeper = 14,
            TradeDeskFullAcces = 15
        }
        public enum EnumSubscriptionType
        {
            Publisher = 0,
            Network = 1,
            Advertiser = 2,//creatives
            SSPPublisher = 3,
            NetworkAdvertiser = 4,//trade desk
            PublisherClient = 5,
            AdvertiserClient = 6,
            Master = 7,
            AdvertiserPublisher = 8,
            Teaser = 9,
            TradeDeskMaster = 10,
            AdmixerGoogleAdX = 11,
            Translator = 12,
            AdmixerAdX = 13,
            SSP = 14,
            AdmixerDSP = 15,
            AdmixerDMP = 16,
            TradeDesk = 17,
            TradeDeskClient = 18
        }
    }
}

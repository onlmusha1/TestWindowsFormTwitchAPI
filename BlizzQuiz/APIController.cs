using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Api;
using TwitchLib.Api.Interfaces;
using TwitchLib.Api.Sections;

namespace BlizzQuiz
{
    class APIController : ITwitchAPI
    {
        public APIController()
        {

        }

        public Auth Auth => throw new NotImplementedException();

        public Badges Badges => throw new NotImplementedException();

        public Bits Bits => throw new NotImplementedException();

        public ChannelFeeds ChannelFeeds => throw new NotImplementedException();

        public Channels Channels => throw new NotImplementedException();

        public Chat Chat => throw new NotImplementedException();

        public Clips Clips => throw new NotImplementedException();

        public Collections Collections => throw new NotImplementedException();

        public Communities Communities => throw new NotImplementedException();

        public Debugging Debugging => throw new NotImplementedException();

        public Games Games => throw new NotImplementedException();

        public Ingests Ingests => throw new NotImplementedException();

        public Root Root => throw new NotImplementedException();

        public Search Search => throw new NotImplementedException();

        public IApiSettings Settings => throw new NotImplementedException();

        public Streams Streams => throw new NotImplementedException();

        public Teams Teams => throw new NotImplementedException();

        public ThirdParty ThirdParty => throw new NotImplementedException();

        public Undocumented Undocumented => throw new NotImplementedException();

        public Users Users => throw new NotImplementedException();

        public Videos Videos => throw new NotImplementedException();

        public Webhooks Webhooks => throw new NotImplementedException();
    }
}

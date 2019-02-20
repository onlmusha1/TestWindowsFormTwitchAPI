using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client;
using TwitchLib.Client.Enums;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Models;
namespace BlizzQuiz
{
    class Messager
    {
        private TwitchClient client;
        private string uName;
        private string oAuthToken;
        private ConnectionCredentials credentials;

        public Messager(string userName, string oAuthToken)
        {
            
            this.uName = userName;
            this.oAuthToken = oAuthToken;
            this.client = new TwitchClient();
            this.credentials = new ConnectionCredentials(this.uName, this.oAuthToken);
            this.client.Initialize(this.credentials);
            

        }
        private void onJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            client.SendMessage(e.Channel, "It's time for BLIZZZZZZQUIZZZZZZZ");
        }


    }
}

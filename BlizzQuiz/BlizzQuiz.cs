using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Media;
using System.Diagnostics;
using TwitchLib.Client;
using TwitchLib.Client.Models;
using TwitchLib.Client.Services;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Events;
namespace BlizzQuiz
{
    public partial class BlizzQuiz : Form
    {
        #region variables
        private TwitchClient client;
        private ConnectionCredentials creds;
        private JoinedChannel currChannel;
        private ChatCommands chatCommands = new ChatCommands();
        #endregion

        public BlizzQuiz()
        {
            InitializeComponent();
            
        }
        private void BlizzQuiz_Load(object sender, EventArgs e)
        {
            this.client = new TwitchClient();
            
            this.creds = new ConnectionCredentials("onlmusha1", "egdp04490r2izbwtkndkmtwrelu5q7");
            this.client.Initialize(this.creds);
            this.client.AddChatCommandIdentifier('!');
            this.client.OnChatCommandReceived += new EventHandler<OnChatCommandReceivedArgs>(chatCommandRecieved);
            
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            if (this.client.IsConnected)
            {
                chatTxtBox.Text += Environment.NewLine + txtBoxSendMsg.Text;
                this.client.SendMessage(this.currChannel, txtBoxSendMsg.Text);
            }
            else
            {
                MessageBox.Show("Please Connect the Bot First!", "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void chatCommandRecieved(object sender, OnChatCommandReceivedArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            var test = e.Command.CommandText;
            var thirdTest = e.Command.ArgumentsAsString;
            string ret = this.chatCommands.controller(e.Command.CommandText, e.Command.ArgumentsAsString);
            if(ret != "CheckMe")
            {
                this.client.SendMessage(this.currChannel, ret);
            }
        }
        private void globalChatMessageRecieved(object sender, OnMessageReceivedArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            

            string chatFormat = Environment.NewLine +"<<"+ e.ChatMessage.Username + ">> : " + e.ChatMessage.Message;
            chatTxtBox.Text += chatFormat;
            this.chatTxtBox.SelectionStart = this.chatTxtBox.Text.Length;
            this.chatTxtBox.ScrollToCaret();
        }


        private void enterCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #region connection methods
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxChannel.Text))
            {
                MessageBox.Show("Please Type a Channel First!", "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxChannel.Focus();
            }
            else
            {
                client.OnConnected += new EventHandler<OnConnectedArgs>(onConnected);
                this.client.Connect();
                chatTxtBox.Text += Environment.NewLine + "Connecting. . .";
            }
            

        }
        public void onConnected(object sender, OnConnectedArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
           
            if (this.client.IsConnected)
            {
                chatTxtBox.Text += Environment.NewLine + "<< Connected to chat server >>";
                this.currChannel = new JoinedChannel(txtBoxChannel.Text);
                this.client.JoinChannel(txtBoxChannel.Text);
                chatTxtBox.Text += Environment.NewLine + "<< Connected to " + txtBoxChannel.Text + " >>";
                this.txtBoxChannel.Text = "";

                //initalizing event handlers
                this.client.OnMessageReceived += new EventHandler<OnMessageReceivedArgs>(globalChatMessageRecieved);
            }
        }
        

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            this.client.OnLeftChannel += new EventHandler<OnLeftChannelArgs>(onLeave);
            this.client.OnDisconnected += new EventHandler<OnDisconnectedArgs>(onDisconnected);
            this.client.LeaveChannel(this.currChannel);
            this.client.Disconnect();
        }

        private void onLeave(object sender, OnLeftChannelArgs e)
        {

            chatTxtBox.Text += Environment.NewLine + "Leaving Channel . . .";
            chatTxtBox.Text += Environment.NewLine + "<< Left Channel " + this.currChannel.Channel +">>";
            this.currChannel = new JoinedChannel("");
           
        }
        private void onDisconnected(object sender, OnDisconnectedArgs e)
        {
            chatTxtBox.Text += Environment.NewLine + "Disconnecting . . .";
            chatTxtBox.Text += Environment.NewLine + "<< Disconnected >>";
            
        }
        #endregion
    }
}

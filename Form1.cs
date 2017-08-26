using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TwitchChatBot
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new System.Timers.Timer(70000);
            timer.Elapsed += OnTimedEvent;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void Button_Disconnect_Click(object sender, EventArgs e)
        {
            timer.AutoReset = false;
            timer.Enabled = false;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            StartMessagingChannels();
        }

        public void StartMessagingChannels()
        {
            var userName = "YOUR_USERNAME";
            var oathToken = "YOUR_TOKEN_HERE";
            var message = "";

            var channels = new List<string>();

            if (Textbox_ChannelName.Text != "")            
                channels = Textbox_ChannelName.Text.Split(',').ToList();

            if (Textbox_Message.Text != "")
                message = Textbox_Message.Text;

            if (Textbox_Username.Text != "" && Textbox_Oath.Text != "")
            {
                userName = Textbox_Username.Text;
                oathToken = Textbox_Oath.Text;
            }

            IrcClient irc = new IrcClient("irc.twitch.tv", 6667, userName, oathToken);
            var logs = "";
            foreach(var channel in channels)
            {
                irc.JoinRoom(channel.Trim());
                irc.SendChatMessage(message);
                irc.LeaveRoom(channel);
            }
                


            //while (true)
            //{
            //    string message = irc.ReadMessage();
            //    if (message.Contains("!hello"))
            //    {
            //        irc.SendChatMessage("Hello to you");
            //    }

            //    if (message.Contains("!test"))
            //    {
            //        irc.SendChatMessage("Do not be alarmed, this is only a test!");
            //    }
            //}
        }

        private void Button_ListenToChannel_Click(object sender, EventArgs e)
        {
            IrcClient irc = new IrcClient("irc.twitch.tv", 6667, "USERNAME", "YOUR_TOKEN_HERE");
            irc.JoinRoom("ROOM_TO_JOIN");

            //irc.SendChatMessage("Bot test");

            while (true)
            {
                string message = irc.ReadMessage();

                if (message.StartsWith("PING "))
                {
                    irc.PongResponse();
                }


                if (message.Contains("reported") || message.Contains("Reported"))
                {
                    irc.SendChatMessage("Report bot has reported your report for reporting.");
                }
                if (message.Contains("!test"))
                {
                    irc.SendChatMessage("Do not be alarmed, this is only a test!");
                }
            }
        }
    }
}

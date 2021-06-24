using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using Server;
using Message = Server.Message;

namespace DesktopClient
{
    public partial class Form1 : Form
    {
        static HubConnection hubConnection;
        public Form1()
        {
            InitializeComponent();
            hubConnection = new HubConnectionBuilder().WithUrl("https://localhost:44349/messages")
                                                      .WithAutomaticReconnect().Build();
            hubConnection.On<NewMessage>(
            "Send", message => AppendTextToTextBox(message.Sender, message.Text, Color.Black));
            hubConnection.Closed += error =>
            {
                MessageBox.Show($@"Connection closed. {error.Message}");
                return Task.CompletedTask;
            };
            hubConnection.Reconnected += id =>
           {
               MessageBox.Show($@"Connection reconnected. {id}");
               return Task.CompletedTask;
           };
            hubConnection.Reconnecting += error =>
           {
               MessageBox.Show($@"Connection reconnecting. {error.Message}");
               return Task.CompletedTask;
           };
        }
        void AppendTextToTextBox(string sender, string text, Color color)
        {
            outputBox.SelectionStart = outputBox.TextLength;
            outputBox.SelectionLength = 0;
            outputBox.SelectionColor = color;
            var n = Environment.NewLine;
            outputBox.AppendText($"Author: {sender}{n}Text: {text}{n}{n}");
            outputBox.SelectionColor = outputBox.ForeColor;
        }

        async void button1_Click(object sender, EventArgs e)
        {
            if (hubConnection.State == HubConnectionState.Disconnected)
            {
                try
                {
                    await hubConnection.StartAsync();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                if (hubConnection.State != HubConnectionState.Connected) return;
                connectButton.Text = @"Disconnect";
                stateLabel.ForeColor = Color.Green;
                stateLabel.Text = @"Connected";
            }
            else if (hubConnection.State == HubConnectionState.Connected)
            {
                await hubConnection.StopAsync();
                connectButton.Text = @"Connect";
                stateLabel.ForeColor = Color.Red;
                stateLabel.Text = @"Disconnected";
            }
        }

        async void getButton_Click(object sender, EventArgs e)
        {
            if (hubConnection.State != HubConnectionState.Connected) return;
            try
            {
                var name = await hubConnection.InvokeAsync<string>("GetName");
                nameBox.Text = string.IsNullOrWhiteSpace(name) ? "Anonymous" : name;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        async void setButton_Click(object sender, EventArgs e)
        {
            if (hubConnection.State != HubConnectionState.Connected) return;
            try
            {
                await hubConnection.SendAsync("SetName", nameBox.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        async void sendButton_Click(object sender, EventArgs e)
        {
            if (hubConnection.State != HubConnectionState.Connected) return;
            try
            {
                var message = new Message {Text = messageBox.Text};
                await hubConnection.SendAsync("SendToOthers", new Message {Text = message.Text });
                AppendTextToTextBox("", message.Text, Color.Green);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                messageBox.Clear();
            }
        }
    }
}

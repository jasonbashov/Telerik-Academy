namespace SimpleChat.UIClient
{
    using System;
    using System.Linq;
    using System.Windows;
    using System.Windows.Threading;

    using MongoDB.Driver;

    using SimpleChat.Data;

    public partial class ChatWindow : Window
    {
        const string DatabaseHost = "mongodb://admin:123456@ds052837.mongolab.com:52837/academychat";
        //const string DatabaseHost = "mongodb://localhost";
        const string DatabaseName = "academychat";

        private MongoDatabase db;

        public ChatWindow(User user)
        {
            InitializeComponent();
            this.SessionUser = user;
            this.db = GetDatabase(DatabaseName, DatabaseHost);
            DispatcherTimer dispTimer = new DispatcherTimer(DispatcherPriority.SystemIdle);

            dispTimer.Interval = TimeSpan.FromSeconds(1);
            dispTimer.Tick += new EventHandler(TimerElapsed);
            dispTimer.IsEnabled = true;
            dispTimer.Start();
        }
        
        private User SessionUser { get; set; }

        void TimerElapsed(object sender, EventArgs e)
        {
            ReloadMessages();
        }

        private void ReloadMessages()
        {
            var messages = this.db.GetCollection<Message>("messages");

            var allmsgs = messages.FindAll().ToList();
            ListBoxMessages.Items.Clear();
            foreach (var msg in allmsgs)
            {
                ListBoxMessages.Items.Add(string.Format("[{0:dd:mm:yyyy:hh:mm}]{1} : {2}", msg.LogDate, msg.MessageUser, msg.Text));
            }
            ListBoxMessages.IsEnabled = true;
            if (this.ListBoxMessages.Items.Count > 0)
            {
                this.ListBoxMessages.ScrollIntoView(this.ListBoxMessages.Items[this.ListBoxMessages.Items.Count - 1]);
            }
        }

        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            var newMessage = new Message() { LogDate = DateTime.Now, Text = NewMsg.Text, MessageUser = this.SessionUser.Username };

            this.AddPost(newMessage);

            ReloadMessages();
        }

        private MongoDatabase GetDatabase(string name, string fromHost)
        {
            var mongoClient = new MongoClient(fromHost);
            var server = mongoClient.GetServer();
            return server.GetDatabase(name);
        }

        private void AddPost(Message newMessage)
        {
            var messages = this.db.GetCollection<Message>("messages");

            messages.Insert(newMessage);
        }
    }
}

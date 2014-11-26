namespace SimpleChat.UIClient
{
    using System.Windows;

    using SimpleChat.Data;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ShowCrowdChatWindow(string username)
        {
            var user = new User() { Username = username };
            var mainWindow = new ChatWindow(user);
            mainWindow.Show();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            var username = LoginTxt.Text;
            this.Hide();
            this.ShowCrowdChatWindow(username);
            this.Close();
        }
    }
}

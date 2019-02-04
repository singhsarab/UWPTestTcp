using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using PortableTcpClient;
using System;

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static bool restart = false;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!restart)
            {
                var client = new TcpClientConnect();
                var port = Convert.ToInt32(this.portTextBox.Text);
                client.ConnectToClinet(port);
                restart = true;
            }
            else
            {
                this.textBlock1.Text = "Restart App to try again.";
            }
        }
    }
}

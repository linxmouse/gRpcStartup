using System.ComponentModel;
using System.Windows;
using greeter.hello;
using Grpc.Core;

namespace HelloClient
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Channel channel;
        private Greeter.GreeterClient client;

        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            channel = new Channel("localhost", 8099, ChannelCredentials.Insecure);
            client = new Greeter.GreeterClient(channel);
            var response = client.SayHello(new HelloRequest() { Name = "Link Sun" });
            lvResponse.Items.Add(response);
        }

        private void TbHello_OnClick(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            var response = client.SayHello(new HelloRequest() { Name = name });
            lvResponse.Items.Add(response);
        }

        private void TbWorld_OnClick(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            var response = client.SayWorld(new HelloRequest() { Name = name });
            lvResponse.Items.Add(response);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            channel?.ShutdownAsync().Wait();
            base.OnClosing(e);
        }
    }
}

using System.ComponentModel;
using System.Windows;
using greeter.hello;
using Grpc.Core;
using HelloServer.gRpcService;

namespace HelloServer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Server server;

        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            server = new Server()
            {
                Services = { Greeter.BindService(new GreeterService())},
                Ports = { new ServerPort("localhost", 8099, ServerCredentials.Insecure)}
            };
            server.Start();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            server?.ShutdownAsync().Wait();
            base.OnClosing(e);
        }
    }
}

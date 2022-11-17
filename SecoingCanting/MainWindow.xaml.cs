using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;


namespace SecoingCanting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CancellationTokenSource cts;
        private Task task;
        private readonly Count count = new Count { i = 0 };

        public MainWindow()
        {
            InitializeComponent();
        }



        public void SendSeconds(Count count)
        {
            CancellationToken token = cts.Token;

            while (true)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                count.i++;
                if (count.i == int.MaxValue)
                {
                    count.i = 0;
                }

                Thread.Sleep(1000);
                _ = Dispatcher.Invoke(() => label1.Content = count.i);
            }

        }

        public void StartCount()
        {
            cts = new CancellationTokenSource();
            task = new Task(() => SendSeconds(count));
            task.Start();

        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StartCount();
        }

        public void Window_Closed(object sender, EventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cts.Cancel();
            Thread.Sleep(2000);
            StartCount();
        }
    }
}

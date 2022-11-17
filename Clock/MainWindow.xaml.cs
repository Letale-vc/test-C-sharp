using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Clock
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thread secondsCountingThread;
        Thread daysCountingThread;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            secondsCountingThread = new Thread(new ThreadStart(CountSeconds));
            daysCountingThread = new Thread(new ThreadStart(CountDays));
            daysCountingThread.Start();
            secondsCountingThread.Start();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            secondsCountingThread.Abort();
            daysCountingThread.Abort();
        }
    }
}

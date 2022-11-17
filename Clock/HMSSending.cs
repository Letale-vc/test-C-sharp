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
    delegate void SendTime(string t);

    public partial class MainWindow : Window
    {

        private SendTime sT;
        private DateTime dT;
        private HMS hms;

        private void CountSeconds()
        {

            sT = new SendTime(SendSeconds);


            while (true)
            {

                dT = DateTime.Now;
                hms = new HMS(dT);

                SendSeconds($"{hms.H}:{hms.M}:{hms.S}");

            }
        }

        public void SendSeconds(String text)
        {
            if (!label1.Dispatcher.CheckAccess())
            {
                _ = label1.Dispatcher.Invoke(sT, new object[] { text });

            }
            else
            {
                label1.Content = DateTime.Now.ToLongTimeString();
            }
        }
    }
}

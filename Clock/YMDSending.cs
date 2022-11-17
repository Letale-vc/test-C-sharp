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
    delegate void SendDate(string t);

    public partial class MainWindow : Window
    {
        private SendDate sD;
        private YMD ymd;

        private void CountDays()
        {

            sD = new SendDate(SendDays);


            while (true)
            {

                dT = DateTime.Now;

                ymd = new YMD(dT);

                SendDays($"{ymd.D}.{ymd.M}.{ymd.Y}");
                Thread.Sleep(1000);
            }
        }

        public void SendDays(string text)
        {
            if (!label2.Dispatcher.CheckAccess())
            {
                _ = label2.Dispatcher.Invoke(sD, new object[] { text });

            }
            else
            {
                label2.Content = DateTime.Now.ToLongDateString();
            }


        }
    }
}

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
    public class HMS
    {
        public HMS(DateTime dateTime)


        {
            if (dateTime.Hour < 10)
            {
                H = $"0{dateTime.Hour}";
            }
            else
            {
                H = $"{dateTime.Hour}";
            }

            if (dateTime.Minute < 10)
            {
                M = $"0{dateTime.Minute}";
            }

            else
            {
                M = $"{dateTime.Minute}";
            }
            if (dateTime.Second < 10)
            {
                S = $"0{dateTime.Second}";
            }
            else
            {
                S = $"{dateTime.Second}";
            }



        }
        public string H { get; }
        public string M { get; }
        public string S { get; }
    }
}

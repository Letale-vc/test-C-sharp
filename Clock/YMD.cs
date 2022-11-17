using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class YMD
    {
        public YMD(DateTime dateTime)


        {

            Y = $"{dateTime.Year}";

            if (dateTime.Minute < 10)
            {
                M = $"0{dateTime.Month}";
            }
            else
            {
                M = $"{dateTime.Month}";
            }
            if (dateTime.Second < 10)
            {
                D = $"0{dateTime.Day}";
            }
            else
            {
                D = $"{dateTime.Day}";
            }



        }
        public string Y { get; }
        public string M { get; }
        public string D { get; }
    }
}

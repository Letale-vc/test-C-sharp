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
using Microsoft.Win32;
using System.Reflection;

namespace AutoStartWin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetAutoRunValue(true, Assembly.GetExecutingAssembly().Location);

            _ = MessageBox.Show("HELLOW BITCH!", "Hello box", MessageBoxButton.OK, MessageBoxImage.Asterisk);

        }
        private bool SetAutoRunValue(bool autorun, string path)
        {
            const string name = "HELLOW BITCH!";
            string ExePath = path;
            RegistryKey reg;

            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun) { reg.SetValue(name, ExePath); }
                else
                {
                    reg.DeleteValue(name);


                }



                reg.Flush();
                reg.Close();
            }
            catch (Exception err)
            {

                return false;

            }

            return true;

        }
    }
}

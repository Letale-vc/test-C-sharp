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

namespace Form1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "user1" && textBox2.Password == "12345")
            {

                AcceptWindow s = new AcceptWindow();
                s.Show();
                this.Close();

            }

            else
            {
                textBox1.Text = "";
                textBox2.Password = "";
                MessageBox.Show("Login or password felse");

            }
        }
    }
}

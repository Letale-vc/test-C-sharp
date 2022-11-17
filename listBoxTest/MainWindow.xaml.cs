using System;
using System.Windows;
using System.Diagnostics;
using System.Windows.Input;
using System.IO;
using System.Windows.Forms;


namespace listBoxTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBox1.Text = Directory.GetCurrentDirectory();


        }

        // pereuti po path
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TextBox1.Text = fbd.SelectedPath.ToString();
                    webBrowser.Source = new Uri(TextBox1.Text);
                }
            }

        }




        //load failov i papok - back button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();

        }

        private void backPath(string path)
        {
            while (path[path.Length - 1] != '\\')
            {
                path = path.Remove(path.Length - 1, 1);
            }


            TextBox1.Text = path;

        }



        private void forwardButton_Click(object sender, RoutedEventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();

        }
    }
}

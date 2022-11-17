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
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace weatherApp
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

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WebRequest request = WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?q=Pavlohrad&&units=metric&appid=86e06add66862b54c97ca4a4d47f6829");

            request.Method = "POST";
            request.ContentType = "application/x-www-urlencoded";

            WebResponse response = await request.GetResponseAsync();

            string answer = string.Empty;

            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    answer = await reader.ReadToEndAsync();
                }
            }
            response.Close();

            richTextBox1.Document.Blocks.Add(new Paragraph(new Run(answer)));

            OpenWeather.OpenWeather openweather = JsonConvert.DeserializeObject<OpenWeather.OpenWeather>(answer);

            image1.Source = new BitmapImage(new Uri($"{Environment.CurrentDirectory}/icons/{openweather.weather[0].icon}.png"));

            BitmapImage testUri = new BitmapImage(new Uri($"icons/03d.png", UriKind.Relative));




        }
    }
}

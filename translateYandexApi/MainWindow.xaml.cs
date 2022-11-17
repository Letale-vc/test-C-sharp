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
using System.IO;

namespace translateYandexApi
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tested();


        }

        private async void tested()
        {
            try
            {
                using (FileStream fstream = File.OpenRead("text.txt"))
                {
                    byte[] array = new byte[fstream.Length];
                    // асинхронное чтение файла
                    await fstream.ReadAsync(array, 0, array.Length);

                    string textFromFile = System.Text.Encoding.Default.GetString(array);

                    string[] arrayComboBox = textFromFile.Split(' ');



                    foreach (string el in arrayComboBox)
                    {
                        comboBox1.Items.Add(el);
                        comboBox2.Items.Add(el);

                    }

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

    }
}

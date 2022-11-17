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
using System.Data;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    [System.Runtime.InteropServices.Guid("7E095549-365B-4A50-A260-725519474DC8")]
    public partial class MainWindow : Window
    {
        double a, b, result;
        int count;
        bool znak = true;
        string[] strArrayCheck = new string[] { "+", "-", "*", "/" };
        public MainWindow()
        {
            InitializeComponent();



        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "0";
            else
                textBox.Text = textBox.Text + 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.IndexOf(",") > -1) textBox.Text = textBox.Text + "";
            else textBox.Text = textBox.Text + ",";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)

        {
            if (textBox.Text == "0")
                textBox.Text = "1";
            else
                textBox.Text = textBox.Text + 1;


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "2";
            else
                textBox.Text = textBox.Text + 2;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "3";
            else
                textBox.Text = textBox.Text + 3;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "4";
            else
                textBox.Text = textBox.Text + 4;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "5";
            else
                textBox.Text = textBox.Text + 5;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "6";
            else
                textBox.Text = textBox.Text + 6;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "7";
            else
                textBox.Text = textBox.Text + 7;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "8";
            else
                textBox.Text = textBox.Text + 8;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "9";
            else
                textBox.Text = textBox.Text + 9;
        }
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            checkAndSwapZnaki("+", 1);

        }
        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            checkAndSwapZnaki("-", 2);
        }
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {

            checkAndSwapZnaki("*", 3);
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            //  znak "="

            b = Convert.ToDouble(textBox.Text);

            if (result != 0)
            {

                textLabel.Content = result + this.strArrayCheck[count - 1] + a;

            }
            if (b != 0)
                textLabel.Content = b + this.strArrayCheck[count - 1] + a;

            calculate();


        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            checkAndSwapZnaki("/", 4);
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            textBox.Text = "0";
            b = 0;
            a = 0;
            result = 0;

        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            string text = textBox.Text;
            textBox.Clear();
            for (int i = 0; i < textBox.Text.Length - 1; i++)
            {
                textBox.Text = textBox.Text + text[i];
            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            if (znak == true)
            {
                textBox.Text = "-" + textBox.Text;
                znak = false;

            }
            {
                textBox.Text = "+" + textBox.Text;
                znak = true;

            }



        }


        private void checkAndSwapZnaki(string str, int count)
        {
            bool isFind = false;

            foreach (string el in strArrayCheck)
            {

                if (textLabel.Content.ToString().Length > 0 && textLabel.Content.ToString()[textLabel.Content.ToString().Length - 1].ToString() == el)
                {
                    textLabel.Content = textLabel.Content.ToString().Remove(textLabel.Content.ToString().Length - 1) + str;
                    this.count = count;
                    isFind = true;
                }


            }
            if (!isFind)
            {

                a = Convert.ToDouble(textBox.Text);
                this.count = count;
                if (result != 0)
                    textLabel.Content = result + str;
                else
                    textLabel.Content = a + str;
                znak = true;

            }

        }


        private void calculate()
        {


            switch (count)
            {
                case 1:


                    result = a + b;
                    textBox.Text = result.ToString();

                    break;
                case 2:

                    result = a - b;
                    textBox.Text = result.ToString();

                    break;
                case 3:

                    result = a * b;
                    textBox.Text = result.ToString();

                    break;
                case 4:

                    result = a / b;
                    textBox.Text = result.ToString();

                    break;
                default:
                    break;
            }


        }
    }


}

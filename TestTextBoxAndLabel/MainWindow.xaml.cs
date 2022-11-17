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

namespace TestTextBoxAndLabel
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


        //private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{

        //    if (textBox1.IsKeyboardFocused == true || textBox1.IsFocused == true)
        //    {
        //        label.Content = textBox1.Text;
        //        textBox1.Visibility = Visibility.Hidden;
        //        Keyboard.ClearFocus();
        //        FocusManager.SetFocusedElement(this, null);
        //    }
        //}



        private void window1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (textBox1.IsFocused && textBox1.IsKeyboardFocused)
            {
                grid1.Focus();
                Keyboard.ClearFocus();

            }
        }

        private void textBox1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textBox1.Visibility = Visibility.Visible;
            textBox1.Focus();
            Mouse.AddPreviewMouseDownOutsideCapturedElementHandler(this, OnMouseDownOutsideElement);
        }


        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            textBox1.Text = label.Content.ToString();


        }
        private void OnMouseDownOutsideElement(object sender, MouseButtonEventArgs e)
        {
            Mouse.RemovePreviewMouseDownOutsideCapturedElementHandler(this, OnMouseDownOutsideElement);
            ReleaseMouseCapture();
            textBox1.Visibility = Visibility.Hidden;
        }

    }
}

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

namespace TestConntextMenu
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



        //private void MenuChange(Object sender, RoutedEventArgs ags)
        //{
        //    RadioButton rb = sender as RadioButton;
        //    if (rb == null || cxm == null) return;

        //    switch (rb.Name)
        //    {
        //        case "rbCustom":
        //            listBox1.ContextMenu = cxm;
        //            break;
        //        case "rbDefault":
        //            // Clearing the value of the ContextMenu property
        //            // restores the default TextBox context menu.
        //            listBox1.ClearValue(ContextMenuProperty);
        //            break;
        //        case "rbDisabled":
        //            // Setting the ContextMenu propety to
        //            // null disables the context menu.
        //            listBox1.ContextMenu = null;
        //            break;
        //        default:
        //            break;
        //    }
        //}

        void ClickPaste(Object sender, RoutedEventArgs args) { listBox1.Items.Add(Clipboard.GetText()); }
        void ClickCopy(Object sender, RoutedEventArgs args) { Clipboard.SetText((listBox1.SelectedItem as ListBoxItem).Content.ToString()); }
        void ClickRemove(Object sender, RoutedEventArgs args) { listBox1.Items.Remove(listBox1.SelectedItem); }



        void CxmOpened(Object sender, RoutedEventArgs args)
        {
            // Only allow copy/cut if something is selected to copy/cut.
            if (listBox1.SelectedItem == null)
                cxmItemCopy.IsEnabled = cxmItemRemove.IsEnabled = false;
            else
                cxmItemCopy.IsEnabled = cxmItemRemove.IsEnabled = true;

            // Only allow paste if there is text on the clipboard to paste.
            if (Clipboard.ContainsText())
                cxmItemPaste.IsEnabled = true;
            else
                cxmItemPaste.IsEnabled = false;
        }
    }


}

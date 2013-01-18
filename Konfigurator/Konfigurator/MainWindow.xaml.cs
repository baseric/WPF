using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Konfigurator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //asd
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbZamowienia.ItemsSource = MyDB.Instance.GetZamowienia();
        }

        private void EditCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

            ListBox lb = e.Parameter as ListBox;

            if (lb == null)
                return;

            if (lb.SelectedIndex < 0)
                e.CanExecute = false;

        }

        private void Edytuj(object sender, ExecutedRoutedEventArgs e)
        {
            /*ListBox lb = e.Parameter as ListBox;

            lb.Items.Insert(0, Zdjete.Text);
            Zdjete.Text = "";
            lb.Items.Refresh();*/

            e.Handled = true;
        }

        private void Usun(object sender, ExecutedRoutedEventArgs e)
        {
            /*ListBox lb = e.Parameter as ListBox;

            lb.Items.Insert(0, Zdjete.Text);
            Zdjete.Text = "";
            lb.Items.Refresh();*/

            e.Handled = true;
        }

        private void Eksport(object sender, ExecutedRoutedEventArgs e)
        {
            /*ListBox lb = e.Parameter as ListBox;

            lb.Items.Insert(0, Zdjete.Text);
            Zdjete.Text = "";
            lb.Items.Refresh();*/

            e.Handled = true;
        }
      
    }
}

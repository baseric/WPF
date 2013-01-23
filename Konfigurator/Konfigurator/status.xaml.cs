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
using System.Windows.Shapes;

namespace Konfigurator
{
    /// <summary>
    /// Interaction logic for status.xaml
    /// </summary>
    public partial class status : Window
    {
        private Zamowienie z;
        private string old;
        string[] statusy = { "Nowe", "W trakcie realizacji", "Zrealizowane" };

        public Zamowienie Z
        {
            set { z = value; }
            get { return z; }
        }

        public string Old
        {
            get { return old; }
            set { old = value; }
        }

        public status(Zamowienie _z)
        {
            z = _z;
            old = z.getStatus;
            InitializeComponent();

            cbStatus.ItemsSource = statusy;

        }
        private void Anuluj_Click(object sender, RoutedEventArgs e)
        {
            z.getStatus = old;
            DialogResult = false;
            Close();
        }

        private void Zmien_Click(object sender, RoutedEventArgs e)
        {
            z.getStatus = cbStatus.SelectedItem.ToString();
            DialogResult = true;
            Close();
        }
        private void Border_MouseLeftButtonDown(object sender,MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    
    
    }



}

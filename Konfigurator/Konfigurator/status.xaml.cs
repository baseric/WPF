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
        public status()
        {
            InitializeComponent();
        }
        private void Anuluj_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void Zmien_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
        private void Border_MouseLeftButtonDown(object sender,MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    
    
    }



}

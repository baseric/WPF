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
    /// Interaction logic for dodatki.xaml
    /// </summary>
    public partial class dodatki : Page
    {
        public dodatki()
        {
            InitializeComponent();
        }

        private void Dalej(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new podsumowanie());
        }

        private void Zamknij(object sender, RoutedEventArgs e)
        {
            Switcher.close(false);
        }

        private void Wstecz(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new kolor_wnetrza());
        }

       
    }
}

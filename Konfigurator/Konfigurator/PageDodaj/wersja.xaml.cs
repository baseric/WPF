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
    /// Interaction logic for wersja.xaml
    /// </summary>
    public partial class wersja : Page
    {
        public wersja()
        {
            InitializeComponent();
        }

        private void Dalej(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new silnik());
        }

        private void DalejCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;

            if (rbWersja1 == null)
                return;

            if ((bool)rbWersja1.IsChecked)
            {
                e.CanExecute = true;
                return;
            }
            else if ((bool)rbWersja2.IsChecked)
            {
                e.CanExecute = true;
                return;
            }
            else if ((bool)rbWersja3.IsChecked)
            {
                e.CanExecute = true;
                return;
            }
            else if ((bool)rbWersja4.IsChecked)
            {
                e.CanExecute = true;
                return;
            }
            else if ((bool)rbWersja5.IsChecked)
            {
                e.CanExecute = true;
                return;
            }
            else if ((bool)rbWersja6.IsChecked)
            {
                e.CanExecute = true;
                return;
            }

        }

        private void Zamknij(object sender, RoutedEventArgs e)
        {
            Switcher.close(false);
        }

        private void Wstecz(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new model());
        }

        private void btnNowaKonfiguracja_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Pojazd = new Pojazd();
            Switcher.Switch(new model());
        }
    }
}

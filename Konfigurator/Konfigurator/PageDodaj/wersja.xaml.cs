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
        int postep;

        public wersja(int _postep)
        {
            postep = _postep;

            if (Switcher.Pojazd.Model.Equals("a7"))
            {
                if (Switcher.Pojazd.Wersja != null)
                {
                    if (Switcher.Pojazd.Wersja.Equals("basic") || Switcher.Pojazd.Wersja.Equals("advanced") || Switcher.Pojazd.Wersja.Equals("top"))
                        Switcher.Pojazd.Wersja = "";
                }
            }

            InitializeComponent();

            if (Switcher.Pojazd.Model.Equals("a7"))
            {
                rbWersja1.IsEnabled = false;
                rbWersja2.IsEnabled = false;
                rbWersja3.IsEnabled = false;
            }

            switch (postep)
            {
                case 0:
                    btnModel.Visibility = System.Windows.Visibility.Visible;
                    break;
                case 1:
                    btnWersja.Visibility = System.Windows.Visibility.Visible;
                    goto case 0;
                case 2:
                    btnSilnik.Visibility = System.Windows.Visibility.Visible;
                    goto case 1;
                case 3:
                    btnKolorNadwozia.Visibility = System.Windows.Visibility.Visible;
                    goto case 2;
                case 4:
                    btnKolorWnetrza.Visibility = System.Windows.Visibility.Visible;
                    goto case 3;
                case 5:
                    btnDodatki.Visibility = System.Windows.Visibility.Visible;
                    goto case 4;
                case 6:
                    btnPodsumowanie.Visibility = System.Windows.Visibility.Visible;
                    goto case 5;
            }
        }

        private void Dalej(object sender, RoutedEventArgs e)
        {
            if (postep < 2)
                postep = 2;
            Switcher.Switch(new silnik(postep));
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
            Switcher.Switch(new model(postep));
        }

        private void btnNowaKonfiguracja_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Pojazd = new Pojazd();
            Switcher.Switch(new model(0));
        }

        private void PrzejdzModel(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new model(postep));
        }

        private void PrzejdzWersja(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new wersja(postep));
        }

        private void PrzejdzSilnik(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new silnik(postep));
        }

        private void PrzejdzKolorNadwozia(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new kolor_nadwozia(postep));
        }

        private void PrzejdzKolorWnetrza(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new kolor_wnetrza(postep));
        }

        private void PrzejdzDodatki(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new dodatki(postep));
        }

        private void PrzejdzPodsumowanie(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new podsumowanie(postep));
        }
    }
}

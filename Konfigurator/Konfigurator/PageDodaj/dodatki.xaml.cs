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
        int postep;

        public dodatki(int _postep)
        {
            postep = _postep;

            InitializeComponent();

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
            if (postep < 6)
                postep = 6;
            Switcher.Switch(new podsumowanie(postep));
        }

        private void Zamknij(object sender, RoutedEventArgs e)
        {
            Switcher.close(false);
        }

        private void Wstecz(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new kolor_wnetrza(postep));
        }

        private void btnNowaKonfiguracja_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Pojazd = new Pojazd();
            Switcher.Switch(new model(0));
        }

       
    }
}

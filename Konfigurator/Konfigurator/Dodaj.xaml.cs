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
using System.Windows.Navigation;

namespace Konfigurator
{
    /// <summary>
    /// Interaction logic for Dodaj.xaml
    /// </summary>
    public partial class Dodaj : Window
    {

        public Pojazd p;
        public Klient k;

        public Dodaj(Pojazd _p, Klient _k, int postep)
        {
            p = _p;
            k = _k;
            InitializeComponent();
            Switcher.dodaj = this;
            Switcher.Switch(new model(postep));  
        }

        public void Navigate(Page nextPage)
        {
            this.Content = nextPage;
        }

        public Pojazd P
        {
            set { p = value; }
            get { return p; }
        }

        public Klient K
        {
            set { k = value; }
            get { return k; }
        }

    }
}

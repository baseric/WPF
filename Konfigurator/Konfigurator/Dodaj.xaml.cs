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

        public Pojazd p = new Pojazd();
        public Klient k = new Klient();

        public Dodaj()
        {
            InitializeComponent();
            Switcher.dodaj = this;
            Switcher.Switch(new model());  
        }

        public void Navigate(Page nextPage)
        {
            this.Content = nextPage;
        }

    }
}

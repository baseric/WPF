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
    /// Interaction logic for podsumowanie.xaml
    /// </summary>
    public partial class podsumowanie : Page
    {
        public podsumowanie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new dane_klienta());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Switcher.close(false);
        }
    }
}

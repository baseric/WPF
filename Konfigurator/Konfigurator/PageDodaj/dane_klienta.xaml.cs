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
    /// Interaction logic for dane_klienta.xaml
    /// </summary>
    public partial class dane_klienta : Page
    {
        private int _errors = 0;

        public dane_klienta()
        {
            InitializeComponent();
        }

        private void Zapisz(object sender, RoutedEventArgs e)
        {
            Switcher.close(true);
        }

        private void DalejCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

            e.CanExecute = _errors == 0;      
          
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Switcher.close(false);
        }

        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                _errors++;
            else
                _errors--;
        }
    }
}

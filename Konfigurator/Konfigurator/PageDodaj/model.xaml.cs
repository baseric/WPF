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
    /// Interaction logic for model.xaml
    /// </summary>
    public partial class model : Page
    {
        public model()
        {
            InitializeComponent();
        }

        private void Dalej(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new wersja());
        }

        private void DalejCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;

            if (radioButton1 == null)
                return;

            if ((bool)radioButton1.IsChecked)
            {
                e.CanExecute = true;
                return;
            }
            else if ((bool)radioButton2.IsChecked)
            {
                e.CanExecute = true;
                return;
            }
            else if ((bool)radioButton3.IsChecked)
            {
                e.CanExecute = true;
                return;
            }
            else if ((bool)radioButton4.IsChecked)
            {
                e.CanExecute = true;
                return;
            }

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Switcher.close(false);
        }
    }
}

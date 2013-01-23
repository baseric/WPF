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
    /// Interaction logic for dane.xaml
    /// </summary>
    public partial class dane : Window
    {
        Zamowienie z;

        public Zamowienie Z
        {
            set { z = value; }
            get { return z; }
        }

        public dane(Zamowienie _z)
        {
            z = _z;
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == true)
            {
                // Define a margin.
                int pageMargin = 5;
                // Get the size of the page.
                Size pageSize = new Size(printDialog.PrintableAreaWidth -
                       pageMargin * 2, 520);
                // Trigger the sizing of the element.
                Zamowienie.Measure(pageSize);
                Zamowienie.Arrange(new Rect(pageMargin, pageMargin,
                                       pageSize.Width, pageSize.Height));
                printDialog.PrintVisual(Zamowienie, "Zamówienie");

                Zamowienie.Arrange(new Rect(0,0,634,500));

            }
        }
    }
}

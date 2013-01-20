using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Konfigurator
{
    class Switcher
    {
        public static Dodaj dodaj;

        public static void Switch(Page newPage)
        {
            dodaj.Navigate(newPage);
        }

        public static void close(bool dialog)
        {
            dodaj.DialogResult = dialog;
            dodaj.Close();
        }

        public static Pojazd Pojazd
        {
            set { dodaj.p = value; }
            get { return dodaj.p; }
        }

        public static Klient Klient
        {
            set { dodaj.k = value; }
            get { return dodaj.k; }
        }
    }
}

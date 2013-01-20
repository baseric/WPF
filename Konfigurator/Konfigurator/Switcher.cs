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
            set { dodaj.P = value; }
            get { return dodaj.P; }
        }

        public static Klient Klient
        {
            set { dodaj.K = value; }
            get { return dodaj.K; }
        }

        public static bool Edycja
        {
            set { dodaj.edycja = value; }
            get { return dodaj.edycja; }
        }
    }
}

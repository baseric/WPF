using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media.Imaging;

namespace Konfigurator
{
    class PojazdToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Pojazd p = (Pojazd)value;

            string path = "";
            string katalog = "";
            string model = "";
            string drzwi = "";
            string kolor = "bialy";

            if (p == null)
            {
                return new BitmapImage();
            }

            if (p.Model != null)
            {

                if (p.Model.Equals("a1"))
                {
                    katalog = model = "a1";
                }
                else if (p.Model.Equals("a3"))
                {
                    katalog = model = "a3";
                }
                else if (p.Model.Equals("a5"))
                {
                    katalog = model = "a5";
                }
                else if (p.Model.Equals("a7"))
                {
                    katalog = "a7";
                }
            }

            if (p.Wersja != null)
            {
                if (p.Wersja.Equals("basic") || p.Wersja.Equals("advanced") || p.Wersja.Equals("top"))
                {
                    drzwi = "3drzwi";
                }
            }

            if (p.Kolor_nadwozia != null)
            {
                if (p.Kolor_nadwozia.Equals("bialyzw"))
                {
                    kolor = "bialy";
                }
                else if (p.Kolor_nadwozia.Equals("czarnyzw"))
                {
                    kolor = "czarny";
                }
                else if (p.Kolor_nadwozia.Equals("czerwonyzw"))
                {
                    kolor = "czerwony";
                }
                else if (p.Kolor_nadwozia.Equals("srebrnymet"))
                {
                    kolor = "srebrny";
                }
                else if (p.Kolor_nadwozia.Equals("niebieskimet"))
                {
                    kolor = "niebieski";
                }
                else if (p.Kolor_nadwozia.Equals("brazowymet"))
                {
                    kolor = "brazowy";
                }
            }

            if (katalog.Equals("a7"))
            {
                path = "/Konfigurator;component/images/" + katalog + "/" + kolor + ".jpg";
            }
            else
            {
                path = "/Konfigurator;component/images/" + katalog + "/" + model + kolor + drzwi + ".jpg";
            }
            

            return new BitmapImage(new Uri(path, UriKind.Relative));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}

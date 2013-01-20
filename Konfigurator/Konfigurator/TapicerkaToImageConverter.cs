using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media.Imaging;

namespace Konfigurator
{
    class TapicerkaToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string tapicerka = (string)value;

            string path = "";

            string kolor = "srebrna materialowa";


            if (tapicerka != null)
            {
                if (tapicerka.Equals("srebrnamat"))
                {
                    kolor = "srebrna materialowa";
                }
                else if (tapicerka.Equals("czarnamat"))
                {
                    kolor = "czarna materialowa";
                }
                else if (tapicerka.Equals("bezowamat"))
                {
                    kolor = "bezowa materialowa";
                }
                else if (tapicerka.Equals("satynowask"))
                {
                    kolor = "satynowa skora";
                }
                else if (tapicerka.Equals("brazowask"))
                {
                    kolor = "brazowa skora";
                }
                else if (tapicerka.Equals("bezowask"))
                {
                    kolor = "bezowa skora";
                }
            }

            path = "/Konfigurator;component/images/" + kolor + ".jpg";


            return new BitmapImage(new Uri(path, UriKind.Relative));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}

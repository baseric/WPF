using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Konfigurator
{
    class MyDB
    {
        private static Collection<Zamowienie> list = new ObservableCollection<Zamowienie>();

        static MyDB()
        {
            Klient k = new Klient("asd","ul. asd 1/21", "15-000", "asd", "1234567890");
            Pojazd p = new Pojazd();
            list.Add(new Zamowienie(k, p));
            list.Add(new Zamowienie(k, p));
        }

        private static MyDB singleton = null;

        public static MyDB Instance
        {
            get
            {
                if (singleton == null)
                    singleton = new MyDB();
                return singleton;
            }
        }

        public Collection<Zamowienie> GetZamowienia()
        {
            return list;
        }
    }
}

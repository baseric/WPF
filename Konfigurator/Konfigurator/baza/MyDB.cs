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
            Klient k = new Klient("asd","ul. asd 1/21", "15-000", "asd", "1234567890", "0700");
            Pojazd p = new Pojazd();
            p.Model = "a3";
            p.Wersja = "advanced";
            p.Silnik = "1.6";
            p.Kolor_nadwozia = "srebrnymet";
            p.Kolor_wnetrza = "brazowask";
            p.Klimatyzacja = true;
            p.Radio = true;
            list.Add(new Zamowienie(k, p));
            list.Add(new Zamowienie(k, p));
            list.Add(new Zamowienie(k, p, DateTime.Now.AddMonths(-1)));
            list.Add(new Zamowienie(k, p, DateTime.Now.AddDays(-5)));
            list.Add(new Zamowienie(k, p, DateTime.Now.AddMonths(-1)));
            list.Add(new Zamowienie(k, p, DateTime.Now.AddMonths(-2)));
            list.Add(new Zamowienie(k, p, DateTime.Now.AddDays(-17)));
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

        public void AddZamowienie(Klient k, Pojazd p)
        {
            list.Add(new Zamowienie(k, p));
        }

        public Collection<Zamowienie> GetZamowienia()
        {
            return list;
        }

        public void RemoveZamowienie(Zamowienie z)
        {
            list.Remove(z);
        }
    }
}

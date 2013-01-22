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
        private static Collection<Pojazd> listKonf = new ObservableCollection<Pojazd>();

        static MyDB()
        {
            Klient k = new Klient("Jan Kowalski","ul. asd 1/21", "15-000", "Białystok", "1234567890", "857666666");
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

            Pojazd p1 = new Pojazd(p);
            p1.Model = "a1";
            listKonf.Add(p1);

            Pojazd p2 = new Pojazd(p);
            p2.Model = "a3";
            listKonf.Add(p2);

            Pojazd p3 = new Pojazd(p);
            p3.Model = "a5";
            listKonf.Add(p3);

            Pojazd p4 = new Pojazd(p);
            p4.Model = "a7";
            listKonf.Add(p4);
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

        public Collection<Pojazd> GetPojazdy
        {
            get
            {
                return listKonf;
            }
        }

        public void RemoveZamowienie(Zamowienie z)
        {
            list.Remove(z);
        }
    }
}

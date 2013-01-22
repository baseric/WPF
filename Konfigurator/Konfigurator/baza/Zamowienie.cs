using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Konfigurator
{
    class Zamowienie : INotifyPropertyChanged
    {
        Klient k;
        Pojazd p;
        DateTime date;
        string status;

        public Zamowienie(Klient _k, Pojazd _p)
        {
            k = _k;
            p = _p;
            date = DateTime.Now;
            status = "Nowe";
        }

        public Zamowienie(Klient _k, Pojazd _p, DateTime _date)
        {
            k = _k;
            p = _p;
            date = _date;
            status = "Nowe";
        }

        public string getKlient
        {
            get
            {
                return k.getName();
            }
        }

        public string getPojazd
        {
            get
            {
                return p.Model + ", " + p.Wersja + ", " + p.Silnik ;
            }
        }

        public string getStatus
        {
            get
            {
                return status;
            }
        }

        public Pojazd Pojazd
        {
            set
            {
                p = value;
                OnPropertyChanged("");
            }
            get
            {
                return p;
            }
        }

        public Klient Klient
        {
            set
            {
                k = value;
                OnPropertyChanged("");
            }
            get
            {
                return k;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
        }

        public string getData
        {
            get
            {
                return date.ToString("dd-MM-yyyy");
            }
        }

        public string getModel
        {
            get
            {
                return "K";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                         new PropertyChangedEventArgs(property));
        }
    }
}

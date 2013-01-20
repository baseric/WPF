using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konfigurator
{
    class Zamowienie
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
                return "Pojazd";
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
            get
            {
                return p;
            }
        }

        public Klient Klient
        {
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
    }
}

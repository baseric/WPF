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

        public string getData
        {
            get
            {
                return date.ToString("d-MM-yyyy");
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

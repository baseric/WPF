using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konfigurator
{
    class Klient
    {
        string name;
        string adres;
        string kod;
        string msc;
        string nip;

        public Klient(string _name, string _adres, string _kod, string _msc, string _nip)
        {
            name = _name;
            adres = _adres;
            kod = _kod;
            msc = _msc;
            nip = _nip;
        }

        public string getName()
        {
            return name;
        }
    }
}

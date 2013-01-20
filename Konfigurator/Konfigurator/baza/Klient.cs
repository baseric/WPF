using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konfigurator
{
    public class Klient
    {
        string name;
        string adres;
        string kod;
        string msc;
        string nip;
        string tel;

        public Klient()
        {
        }

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

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Adres
        {
            set { adres = value; }
            get { return adres; }
        }

        public string Kod
        {
            set { kod = value; }
            get { return kod; }
        }

        public string Msc
        {
            set { msc = value; }
            get { return msc; }
        }

        public string Nip
        {
            set { nip = value; }
            get { return nip; }
        }

        public string Tel
        {
            set { tel = value; }
            get { return tel; }
        }
    }
}

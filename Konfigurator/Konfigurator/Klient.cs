using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konfigurator
{
    class Klient
    {
        String name;
        String adres;
        String kod;
        String msc;
        String nip;

        public Klient(String _name, String _adres, String _kod, String _msc, String _nip)
        {
            name = _name;
            adres = _adres;
            kod = _kod;
            msc = _msc;
            nip = _nip;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Konfigurator
{
    public class Klient : IDataErrorInfo
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

        public Klient(Klient k)
        {
            name = k.Name;
            adres = k.Adres;
            kod = k.Kod;
            msc = k.Msc;
            nip = k.Nip;
            tel = k.Tel;
        }

        public Klient(string _name, string _adres, string _kod, string _msc, string _nip, string _tel)
        {
            name = _name;
            adres = _adres;
            kod = _kod;
            msc = _msc;
            nip = _nip;
            tel = _tel;
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

        public string this[string columnName]
        {
            get
            {

                if (columnName == "Name")
                {
                    if (name == null || name == "")
                        return "Imię i Nazwisko lub nazwa firmy muszą być podane.";
                }

                if (columnName == "Adres")
                {
                    if (adres == null || adres == "")
                        return "Adres musi być podany.";
                }

                if (columnName == "Msc")
                {
                    if (msc == null || msc == "")
                        return "Miejscowość musi być podana.";
                }

                if (columnName == "Tel")
                {
                    if (tel == null || tel == "")
                        return "Telefon kontaktowy musi być podany.";
                }

                if (columnName == "Nip")
                {
                    if (nip == null || nip == "")
                        return "NIP musi być podany.";
                }

                if (columnName == "Kod")
                {
                    int pom;
                    if (kod == null || kod == "")
                        return "Kod pocztowy musi być podany.";
                    else if (kod.Length < 6)
                        return "Podany kod pocztowy jest za krótki.";
                    else if (kod.Length > 6)
                        return "Podany kod pocztowy jest za długi.";
                    else if (kod[2]!='-')
                        return "Błedny format podanego kodu pocztowego.";
                    else if (!int.TryParse(kod.Substring(0,2) + kod.Substring(3,3), out pom))
                        return "Błedny format podanego kodu pocztowego.";
                }

                return null;
            }
        }

        public string Error { get { return null; } }
    }
}

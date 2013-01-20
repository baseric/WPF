using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Konfigurator
{
    public class Pojazd : INotifyPropertyChanged
    {
        private string model;
        public string Model
        {
            set { model = value; OnPropertyChanged(""); }
            get { return model; }
        }
        
        private string wersja;
        public string Wersja
        {
            set { wersja = value; OnPropertyChanged(""); }
            get { return wersja; }
        } 

        private string silnik;
        public string Silnik
        {
            set { silnik = value; OnPropertyChanged(""); }
            get { return silnik; }
        }

        private string kolor_wnetrza;
        public string Kolor_wnetrza
        {
            set { kolor_wnetrza = value; OnPropertyChanged(""); }
            get { return kolor_wnetrza; }
        }

        private string kolor_nadwozia;
        public string Kolor_nadwozia
        {
            set { kolor_nadwozia = value; OnPropertyChanged(""); }
            get { return kolor_nadwozia; }
        }  

        private bool felgi;
        public bool Felgi
        {
            set { felgi = value;  }
            get { return felgi; }
        }

        private bool chrom;
        public bool Chrom
        {
            set { chrom = value;  }
            get { return chrom; }
        }

        private bool ksenony;
        public bool Ksenony
        {
            set { ksenony = value;  }
            get { return ksenony; }
        }

        private bool kliamtyzacja;
        public bool Klimatyzacja
        {
            set { kliamtyzacja = value;  }
            get { return kliamtyzacja; }
        }

        private bool radio;
        public bool Radio
        {
            set { radio = value; }
            get { return radio; }
        }

        private bool podgrz_siedzenia;
        public bool Podgrz_siedzenia
        {
            set { podgrz_siedzenia = value;  }
            get { return podgrz_siedzenia; }
        }

        public Pojazd Self
        {
            get { return this; }
        }

        public Pojazd()
        {
        }

        public Pojazd(Pojazd p)
        {
            model = p.Model;
            wersja = p.Wersja;
            silnik = p.Silnik;
            kolor_nadwozia = p.Kolor_nadwozia;
            kolor_wnetrza = p.kolor_wnetrza;
            felgi = p.Felgi;
            chrom = p.Chrom;
            ksenony = p.Ksenony;
            kliamtyzacja = p.Klimatyzacja;
            radio = p.Radio;
            podgrz_siedzenia = p.Podgrz_siedzenia;
        }

        public string Dodatki
        {
            set { }
            get {
                string dodatki = "";
                if (felgi)
                {
                    dodatki += "Felgi aluminiowe, ";
                }
                if (chrom)
                {
                    dodatki += "Elementy chromowane, ";
                }
                if (ksenony)
                {
                    dodatki += "Reflektory ksenonowe, ";
                }
                if (kliamtyzacja)
                {
                    dodatki += "Klimatyzacja, ";
                }
                if (radio)
                {
                    dodatki += "Radio, ";
                }
                if (podgrz_siedzenia)
                {
                    dodatki += "Podgrzewane siedzenia, ";
                }
                return dodatki; 
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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konfigurator
{
    public class Pojazd
    {
        private string model;
        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        
        private string wersja;
        public string Wersja
        {
            set { wersja = value;  }
            get { return wersja; }
        } 

        private string silnik;
        public string Silnik
        {
            set { silnik = value; }
            get { return silnik; }
        }

        private string kolor_wnetrza;
        public string Kolor_wnetrza
        {
            set { kolor_wnetrza = value;  }
            get { return kolor_wnetrza; }
        }

        private string kolor_nadwozia;
        public string Kolor_nadwozia
        {
            set { kolor_nadwozia = value;  }
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
    }
}

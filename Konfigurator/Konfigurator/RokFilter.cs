using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konfigurator
{
    class RokFilter
    {
        public int MinRok
        {
            get;
            set;
        }

        public int MaxRok
        {
            get;
            set;
        }

        public RokFilter(int min, int max)
        {
            MinRok = min;
            MaxRok = max;
        }

        public bool FilterItem(Object item)
        {
            Zamowienie z = item as Zamowienie;
            if (z != null)
            {
                if (z.Date.Year < MinRok)
                    return false;
                if (z.Date.Year > MaxRok)
                    return false;
                return true;
            }
            return false;
        }
    }
}

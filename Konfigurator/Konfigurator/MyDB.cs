using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Konfigurator
{
    class MyDB
    {
        private static Collection<Zamowienie> list = new ObservableCollection<Zamowienie>();

        static MyDB()
        {
            list.Add(new Zamowienie("Jan", "Kowalski", "", ""));
            list.Add(new Zamowienie("Roman", "Kowalski", "", ""));
            list.Add(new Zamowienie("Zdzisław", "Kowalski", "", ""));
            list.Add(new Zamowienie("Wiesław", "Kowalski", "", ""));
        }

        private static MyDB singleton = null;

        public static MyDB Instance
        {
            get
            {
                if (singleton == null)
                    singleton = new MyDB();
                return singleton;
            }
        }
    }
}
